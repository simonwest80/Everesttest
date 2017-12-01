using chm2jekyll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using chm2jekyll.CHMParser;

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
    class HtmlTopicsGenerator : ITopicProcessor
    {
        Parser _parser;
        public HtmlTopicsGenerator(Parser parser)
        {
            _parser = parser;
        }
        public void ProcessTopic(SitemapEntry entry)
        {
            string topicFilename = entry.GetLastParam("local").ToLower();
            entry.Context[EntryContextType.topicFileName] = topicFilename;
            

            //retrieve topic name (getting last name since it was seen sometimes there are more than one Name param)
            entry.Context[EntryContextType.topicName] = entry.GetLastParam("name");


            string topicFullPath;
            //sometime section has linked topic so copy the file into topic's folder (otherwise into parent folder)
            if (entry.IsSection && entry.IsTopic)
            {
                topicFullPath = entry.Context[EntryContextType.folderFullPath] + topicFilename;
                Console.WriteLine($"!!!!!!!!!! ATTENTION: Topic and Section in the same entry: {topicFullPath}");
            }
            else if (entry.IsTopic)
                topicFullPath = entry.Parent.Context[EntryContextType.folderFullPath] + topicFilename;
            else
                throw new Exception("HtmlTopicsGenerator - cannot handle section only entry");
            try
            {
                //topicFullPath = @"\\?\" + topicFullPath;
                _parser.CopyTopic(topicFilename, topicFullPath);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Failed to copy topic {topicFullPath} {e.Message}");
            }
            entry.Context[EntryContextType.topicFullPath] = topicFullPath;
        }
    }
}
