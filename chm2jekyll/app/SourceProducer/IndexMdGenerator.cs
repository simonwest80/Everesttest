using chm2jekyll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using chm2jekyll.CHMParser;
using System.IO;
using System.Linq;

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
    class IndexMdGenerator : ISectionProcessor
    {
        public IndexMdGenerator()
        {
        }
        public void ProcessSection(SitemapEntry entry)
        {
            var lines = new List<string>();

            lines.Add("---");
            //lines.Add("layout: default");
            lines.Add($"title: {entry.Context[EntryContextType.sectionName]}");

            List<SitemapEntry> childSections = entry.Childs.Where(x => x.IsSection).ToList();
            List<SitemapEntry> childPages = entry.Childs.Where(x => x.IsTopic).ToList();

            if(childSections.Count > 0)
            {
                lines.Add("sections:");
                foreach(SitemapEntry sec in childSections)
                    lines.Add($"  - \"{sec.Context[EntryContextType.folderName]}\"");
            }

            if(childPages.Count > 0)
            {
                lines.Add("sorted_pages:");
                foreach (SitemapEntry page in childPages)
                    lines.Add($"  - \"{Path.GetFileNameWithoutExtension(page.Context[EntryContextType.topicFileName])}\"");
            }

            lines.Add("---");
            lines.Add("# {{page.title}}");

            File.AppendAllLines(entry.Context[EntryContextType.folderFullPath] + "index.md", lines);
        }
    }
}
