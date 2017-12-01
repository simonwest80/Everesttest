using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chm2jekyll.CHMParser
{
    struct EntryContextType
    {
        /// <summary>
        /// Available for section entries, specify full folder path to the section
        /// </summary>
        public const string folderFullPath = "folder.FullPath";
        /// <summary>
        /// Available for section entries, specify section's folder name
        /// </summary>
        public const string folderName = "folder.Name";
        /// <summary>
        /// Available for section entries, specify section's user friendly name
        /// </summary>
        public const string sectionName = "section.Name";
        /// <summary>
        /// Available for topics, specify topic file name
        /// </summary>
        public const string topicFileName = "topic.FileName";
        /// <summary>
        /// Available for topics, specify topic user friendly name
        /// </summary>
        public const string topicName = "topic.Name";
        /// <summary>
        /// Available for topics, specify topic file full path
        /// </summary>
        public const string topicFullPath = "topic.FullPath";
    }

    public class SitemapEntry
    {
        private bool? _isTopic = null;
        private bool? _isSection = null;

        public List<KeyValuePair<string, string>> Params { private set; get; } = new List<KeyValuePair<string, string>>();
        public HtmlNode Node { set; get; }
        public List<SitemapEntry> Childs { private set; get; } = new List<SitemapEntry>();
        public bool IsSection
        {
            get
            {
                if (_isSection == null)
                    _isSection = Childs.Count > 0;
                return _isSection.Value;
            }
        }
        public bool IsTopic
        {
            get
            {
                if (_isTopic == null)
                    _isTopic = Params.Any(x => string.Compare(x.Key, "local", true) == 0);
                return _isTopic.Value;
            }
        }
        public Dictionary<string, string> Context { private set; get; } = new Dictionary<string, string>();

        public SitemapEntry Parent { set; get; } = null;

        public string GetLastParam(string paramName)
        {
            KeyValuePair<string, string> lastParam = Params.FindLast(x => string.Compare(x.Key, paramName, true) == 0);
            return lastParam.Value;
        }
    }
}
