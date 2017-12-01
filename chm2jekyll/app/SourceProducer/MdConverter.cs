using chm2jekyll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using chm2jekyll.CHMParser;
using System.IO;
using System.Linq;
using HtmlAgilityPack;

namespace chm2jekyll.SourceProducer
{
    /// <summary>
    /// Copy source topics into new folder structure.
    /// All htm renamed to html
    /// 
    /// Add context entries:
    /// topic.FileName
    /// topic.Name
    /// topic.FullPath
    /// </summary>
    class MdConverter : ITopicProcessor
    {
        ReverseMarkdown.Converter _mdConverter;
        private List<string> _popupResources;

        public MdConverter(List<string> popupResources)
        {
            _popupResources = popupResources;

            string unknownTagsConverter = "pass_through";
            bool githubFlavored = true;
            var config = new ReverseMarkdown.Config(unknownTagsConverter, githubFlavored);
            _mdConverter = new ReverseMarkdown.Converter(config);
            _mdConverter.Unregister("span");
            _mdConverter.Register("span", new SpanEx(_mdConverter));

            _mdConverter.Unregister("p");
            _mdConverter.Register("p", new PEx(_mdConverter));

            _mdConverter.Unregister("table");
            _mdConverter.Register("table", new TableEx(_mdConverter));

            _mdConverter.Unregister("img");
            _mdConverter.Register("img", new ImgEx(_mdConverter));

            _mdConverter.Unregister("a");
            _mdConverter.Register("a", new AEx(_mdConverter));


            _mdConverter.Register("object", new ObjectEx(_mdConverter));

            _mdConverter.Unregister("td");
            _mdConverter.Unregister("th");
            _mdConverter.Register("td", new TdEx(_mdConverter));
            _mdConverter.Register("th", new TdEx(_mdConverter));


            if (HtmlNode.ElementsFlags.ContainsKey("li"))
                HtmlNode.ElementsFlags.Remove("li");
        }
        public void ProcessTopic(SitemapEntry entry)
        {
            ProcessFile(entry.Context[EntryContextType.topicFullPath], entry.Context[EntryContextType.topicName]);
        }

        internal void ProcessFile(string topicFullPath, string topicName = null)
        {
            string fileBase;
            string mdFilePath;

            HtmlDocument doc = new HtmlDocument();
            try
            {
                fileBase = Path.GetDirectoryName(topicFullPath) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(topicFullPath);
                mdFilePath = Path.GetDirectoryName(topicFullPath) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(topicFullPath) + ".md";
                doc.Load(topicFullPath);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Failed to load {topicFullPath}: {e.ToString()}");
                return;
            }
            var bodyNode = doc.DocumentNode.SelectSingleNode("//body");

            if (string.IsNullOrEmpty(topicName))
            {
                var titleNode = doc.DocumentNode.SelectSingleNode("//title");
                if (titleNode != null)
                    topicName = titleNode.InnerText.Trim();
            }

            if (string.IsNullOrEmpty(topicName))
            {
                var h1Node = bodyNode.ChildNodes.Where(x => x.NodeType == HtmlNodeType.Element).FirstOrDefault();
                if (h1Node != null && string.Compare(h1Node.Name, "h1", true) == 0)
                    topicName = h1Node.InnerText;
            }

            var lines = new List<string>();
            lines.Add("---");
            string resName = Path.GetFileName(topicFullPath).ToLower();
            if(_popupResources.Contains(resName))
                lines.Add("layout: popup");
            if(!string.IsNullOrEmpty(topicName))
                lines.Add($"title: {topicName.Replace("'", "\\'")}");
            lines.Add("---");


            string md = _mdConverter.Convert(bodyNode.OuterHtml);

            File.WriteAllLines(mdFilePath, lines);
            File.AppendAllText(mdFilePath, md);

            //File.Delete(topicFullPath);
            File.Move(topicFullPath, fileBase + ".html");
        }
    }
}
