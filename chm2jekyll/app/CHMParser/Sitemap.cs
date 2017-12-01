using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace chm2jekyll.CHMParser
{
    class Sitemap
    {


        string _sitemapFilePath;
        HtmlNode _rootNode;
        public SitemapEntry RootEntry { private set; get; }

        public void Parse(string filePath)
        {
            _sitemapFilePath = filePath;

            //do not auto close "li" tag
            if(!HtmlNode.ElementsFlags.ContainsKey("li"))
                HtmlNode.ElementsFlags.Add("li", HtmlElementFlag.Empty);

            var doc = new HtmlDocument();
            doc.Load(filePath);
            //doc.Save(Console.Out);

            _rootNode = doc.DocumentNode;
            RootEntry = new SitemapEntry { Node = _rootNode };

            BuildEntriesTree();

            //PrintEntries(_rootEntry, 0);
        }
        public void Save(string destinationFilePath)
        {
            _rootNode.OwnerDocument.Save(destinationFilePath);
        }
        public void EnumerateNodes(Action<HtmlNode> onNodeStart, Action<HtmlNode> onNode, Action<HtmlNode> onNodeEnd)
        {
            EnumerateNodesInternal(_rootNode, onNodeStart, onNode, onNodeEnd);
        }
        private void EnumerateNodesInternal(HtmlNode root, Action<HtmlNode> onNodeStart, Action<HtmlNode> onNode, Action<HtmlNode> onNodeEnd)
        {
            onNodeStart?.Invoke(root);

            onNode?.Invoke(root);

            foreach (HtmlNode node in root.ChildNodes)
            {
                if (node.ChildNodes.Count > 0)
                    EnumerateNodesInternal(node, onNodeStart, onNode, onNodeEnd);
                else
                    onNode?.Invoke(node);
            }

            onNodeEnd?.Invoke(root);
        }
        public void EnumerateEntries(Action<SitemapEntry> onEntryStart, Action<SitemapEntry> onEntry, Action<SitemapEntry> onEntryEnd)
        {
            if(RootEntry != null)
                EnumerateEntriesInternal(RootEntry, onEntryStart, onEntry, onEntryEnd);
        }
        private void EnumerateEntriesInternal(SitemapEntry root, Action<SitemapEntry> onEntryStart, Action<SitemapEntry> onEntry, Action<SitemapEntry> onEntryEnd)
        {
            onEntryStart?.Invoke(root);

            onEntry?.Invoke(root);

            foreach (SitemapEntry entry in root.Childs)
            {
                if (entry.Childs.Count > 0)
                    EnumerateEntriesInternal(entry, onEntryStart, onEntry, onEntryEnd);
                else
                    onEntry?.Invoke(entry);
            }

            onEntryEnd?.Invoke(root);
        }

        private void BuildEntriesTree()
        {
            Stack<SitemapEntry> entriesStack = new Stack<SitemapEntry>();
            SitemapEntry lastObject = null;

            EnumerateNodes(
                n =>
                {
                    if (string.Compare(n.Name, "ul", true) == 0)
                    {
                        if (lastObject == null)
                            entriesStack.Push(RootEntry);
                        else
                            entriesStack.Push(lastObject);
                    }
                },
                n =>
                {
                    // process only if root ul was processed
                    if (entriesStack.Count > 0)
                    {
                        if (string.Compare(n.Name, "object", true) == 0)
                        {
                            SitemapEntry parent = entriesStack.Peek();
                            lastObject = new SitemapEntry { Node = n, Parent = parent };
                            parent.Childs.Add(lastObject);
                        }
                        else if (string.Compare(n.Name, "param", true) == 0)
                        {
                            lastObject.Params.Add(new KeyValuePair<string, string>(n.Attributes["name"].Value, n.Attributes["value"].Value));
                        }
                    }
                },
                n =>
                {
                    if (string.Compare(n.Name, "ul", true) == 0)
                        entriesStack.Pop();
                }
           );
        }

        private void PrintEntries(SitemapEntry entry, int level)
        {
            string strParams = string.Join(",", entry.Params.Select(x => $"{x.Key}:{x.Value}"));
            if (!string.IsNullOrEmpty(strParams))
                strParams = $"[{strParams}]";

            Console.WriteLine($"{new String(' ', level)} {strParams}");
            foreach (var e in entry.Childs)
            {
                if (e.Childs.Count > 0)
                    PrintEntries(e, level + 1);
                else
                {
                    strParams = string.Join(",", e.Params.Select(x => $"{x.Key}:{x.Value}"));
                    if (!string.IsNullOrEmpty(strParams))
                        strParams = $"[{strParams}]";

                    Console.WriteLine($"{new String(' ', level + 1)} {strParams}");
                }
            }
        }
    }
}
