using chm2jekyll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using chm2jekyll.CHMParser;
using System.IO;
using System.Linq;
using HtmlAgilityPack;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Configuration;

namespace chm2jekyll.SourceProducer
{
    class HHPGenerator : ITopicProcessor, ISitemapEntryProcessor, IFileProcessor
    {
        class FixTagRule
        {
            public string TagName { set; get; }
            public string ResAttrName { set; get; }
            public string FolderToRelocateRes { set; get; }
        }

        string _imgFolder;
        string _miscFolder;
        string _projectFolder;
        int _projectFolderLength;
        Dictionary<string, List<string>> _files = new Dictionary<string, List<string>>();
        Parser _parser;
        string[] _processingFileExt = { ".htm", ".html", ".jpeg", ".jpg", ".gif", ".css", ".js", ".swf", ".bmp" };
        public List<string> PopupResources { private set; get; } = new List<string>();

        public HHPGenerator(Parser parser, string projectFolder)
        {
            _projectFolder = projectFolder;
            _miscFolder = _projectFolder + "misc" + Path.DirectorySeparatorChar;
            _imgFolder = _projectFolder + "img" + Path.DirectorySeparatorChar;
            _projectFolderLength = projectFolder.Length;
            _parser = parser;
            Directory.CreateDirectory(_miscFolder);
            Directory.CreateDirectory(_imgFolder);
        }

        /// <summary>
        /// TOC entries processing
        /// </summary>
        /// <param name="entry"></param>
        public void ProcessTopic(SitemapEntry entry)
        {
            string topicFileName    = entry.Context[EntryContextType.topicFileName].ToLower();
            string topicPath        = entry.Context[EntryContextType.topicFullPath];
            string topicRelPath     = topicPath.Substring(_projectFolderLength);

            if (!_files.ContainsKey(topicFileName))
                _files.Add(topicFileName, new List<string> { topicRelPath });
            else
                _files[topicFileName].Add(topicRelPath);

            FixTopicPath(entry.Node, topicRelPath);
        }

        /// <summary>
        /// Index processing
        ///  - if file is not in the hash of known files then we should move it into misc and update hash
        /// </summary>
        /// <param name="entry"></param>
        public void OnEntry(SitemapEntry entry)
        {
            //process topics only
            if (!entry.IsTopic)
                return;

            //enumerate all referred topics
            string[] topics = entry.Params.Where(x => string.Compare(x.Key, "local", true) == 0).Select(y => y.Value.ToLower().Trim()).ToArray();
            foreach (string file in topics)
            {
                string topicNewRelPath = string.Empty;

                if (!_files.ContainsKey(file))
                {
                    //copy file into /misc/<file> folder
                    string destPath = _miscFolder + file;
                    _parser.CopyTopic(file, destPath);

                    //update hash
                    topicNewRelPath = destPath.Substring(_projectFolderLength);
                    _files.Add(file, new List<string> { topicNewRelPath });
                }
                else
                {
                    topicNewRelPath = _files[file].First();
                    if (_files[file].Count > 1)
                    {
                        Console.WriteLine($"WARN: many entries for {file}:");
                        foreach (string f in _files[file])
                            Console.WriteLine($"  {f}");
                    }
                }

                FixTopicPath(entry.Node, topicNewRelPath, file);
            }
        }

        private string GetRelPath(string diskPath)
        {
            return diskPath.Substring(_projectFolderLength - 1).Replace('\\', '/');
        }

        private void FixTopicPath(HtmlNode node, string topicNewPath, string topicCurPath = null)
        {
            foreach (HtmlNode c in node.ChildNodes)
            {
                if (c.Attributes.Any(y => string.Compare(y.Name, "name", true) == 0 && string.Compare(y.Value, "Local", true) == 0))
                {
                    if (topicCurPath == null || (string.Compare(c.Attributes["Value"].Value, topicCurPath, true) == 0))
                    {
                        c.Attributes["Value"].Value = topicNewPath;
                        break;
                    }
                }
            }
        }

        public void ProcessFile(string fileFullPath)
        {
            string fileName = Path.GetFileName(fileFullPath).ToLower();

            //no need to process if file is known
            if (_files.ContainsKey(fileName))
                return;

            //ignore all but with known extensions
            string ext = Path.GetExtension(fileName);
            if (!_processingFileExt.Contains(ext))
            {
                Console.WriteLine($"Ignore file ({ext}): {fileFullPath}");
                return;
            }

            string destPath = _miscFolder + fileName;
            _parser.CopyTopic(fileName, destPath);

            //update hash
            _files.Add(fileName, new List<string> { destPath.Substring(_projectFolderLength) });
        }

        public void Save(Parser parser, string projectTitle)
        {
            string projectFileName = Path.GetFileNameWithoutExtension(parser.CHMFilePath);

            var header = new List<string>();
            header.Add("[OPTIONS]");
            header.Add($"Title={projectTitle}");
            header.Add($"Contents file={projectFileName + ".hhc"}");
            header.Add($"Index file={projectFileName + ".hhk"}");
            header.Add("Full-text search=Yes");
            header.Add(string.Empty);
            header.Add("[FILES]");

            File.WriteAllLines(_projectFolder + projectFileName + ".hhp", header);

            var files = new List<string>();
            foreach(var entry in _files)
                files.AddRange(entry.Value); 
            File.AppendAllLines(_projectFolder + projectFileName + ".hhp", files);


            var mapping = new List<string>();
            mapping.Add("[ALIAS]");
            mapping.AddRange(parser.Aliases.Where(x => _files.ContainsKey(x.Value.ToLower())).Select(x => $"helpid_{x.Key}={_files[x.Value.ToLower()].First()}"));
            mapping.Add(string.Empty);
            mapping.Add("[MAP]");
            mapping.AddRange(parser.Aliases.Where(x => _files.ContainsKey(x.Value.ToLower())).Select(x => $"#define helpid_{x.Key} {x.Key}"));

            File.AppendAllLines(_projectFolder + projectFileName + ".hhp", mapping);
        }

        private void PrepareHAP()
        {
            if (HtmlNode.ElementsFlags.ContainsKey("li"))
                HtmlNode.ElementsFlags.Remove("li");

            HtmlNode.ElementsFlags.Add("li", HtmlElementFlag.Empty);

            if (HtmlNode.ElementsFlags.ContainsKey("p"))
                HtmlNode.ElementsFlags.Remove("p");
        }

        public void FixRefs()
        {
            PrepareHAP();

            var fixRules = new FixTagRule[]
            {
                new FixTagRule { TagName = "img", ResAttrName = "src", FolderToRelocateRes = _imgFolder },
                new FixTagRule { TagName = "link", ResAttrName = "href", FolderToRelocateRes = null },
                new FixTagRule { TagName = "script", ResAttrName = "src", FolderToRelocateRes = null },
                new FixTagRule { TagName = "a", ResAttrName = "href", FolderToRelocateRes = null },
                new FixTagRule { TagName = "area", ResAttrName = "href", FolderToRelocateRes = null },
                new FixTagRule { TagName = "embed", ResAttrName = "src", FolderToRelocateRes = null }
            };

            FixRefsUsingRules(fixRules);
        }

        private void FixRefsUsingRules(IEnumerable<FixTagRule> rules)
        {
            EnumHtmlFiles(f =>
            {
                HtmlDocument doc = new HtmlDocument();
                try
                {
                    doc.Load(f);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to load {f}: {e.ToString()}");
                    return;
                }


                var errors = new List<string>();
                foreach (FixTagRule rule in rules)
                    FixRefs(doc, rule, f, errors);
                doc.Save(f);

                if (errors.Count > 0)
                {
                    //Console.WriteLine($"{f}");
                    foreach (string e in errors)
                        if(!e.Contains(".chm::"))
                            Console.WriteLine($"{e}");
                }
            });
        }

        private void EnumHtmlFiles(Action<string> onHtmlFile)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(_projectFolder, "*.htm", SearchOption.AllDirectories);
            foreach (string f in files)
                onHtmlFile(f);
        }

        private void FixRefs(HtmlDocument doc, FixTagRule rule, string srcFile, List<string> errors)
        {
            HtmlNodeCollection tags = doc.DocumentNode.SelectNodes("//" + rule.TagName);
            if (tags != null)
            {
                foreach (HtmlNode tag in tags)
                {
                    HtmlAttribute attr = tag.Attributes.Where(x => string.Compare(x.Name, rule.ResAttrName, true) == 0).FirstOrDefault();
                    if (attr != null)
                        FixTagRef(tag, attr, rule.FolderToRelocateRes, srcFile, errors);
                }
            }
        }
        private void FixTagRef(HtmlNode tag, HtmlAttribute attr, string folderToRelocate, string srcFile, List<string> errors)
        {
            string resName;
            string anchorRef = string.Empty;
            string valPattern = "{0}";

            {
                string curResPathEncoded = attr.Value.ToLower().Trim();
                string curRelPath = Uri.UnescapeDataString(curResPathEncoded);
                if (curResPathEncoded.Contains(".chm::"))
                {
                    resName = curResPathEncoded;
                }
                else if (curResPathEncoded.Contains("#"))
                {
                    string[] parts = curRelPath.Split('#');
                    resName = Path.GetFileName(parts[0]);
                    anchorRef = "#" + parts[1];
                }
                else if (curResPathEncoded.Contains("bsscpopup"))
                {
                    const string pattern = @"javascript:bsscpopup\('(.*)'\);";
                    var match = Regex.Match(curResPathEncoded, pattern);
                    if (match.Success && match.Groups.Count > 0 && match.Groups[0].Success)
                    {
                        resName = match.Groups[1].Value;
                        valPattern = "javascript:BSSCPopup('{0}');";
                        //mark resource as popup
                        PopupResources.Add(Path.GetFileName(resName).Trim().ToLower());
                    }
                    else
                        resName = Path.GetFileName(curRelPath);
                }
                else
                {
                    resName = Path.GetFileName(curRelPath);
                }
            }

            string newRelPath = string.Empty;
            if(!_files.ContainsKey(resName))
            {
                errors.Add($"{attr.Name}: {resName + anchorRef}");
                return;
            }

            //relocate if needed
            if (!string.IsNullOrEmpty(folderToRelocate))
            {
                string destPath = folderToRelocate + resName;
                newRelPath = destPath.Substring(_projectFolderLength - 1).Replace('\\', '/');

                //check if it was already relocated
                List<string> resRelLocations = _files[resName];
                if (!resRelLocations.Contains(destPath.Substring(_projectFolderLength)))
                {
                    File.Move(_miscFolder + resName, destPath);
                    resRelLocations.Clear();
                    resRelLocations.Add(destPath.Substring(_projectFolderLength));
                }
            }
            else
            {
                newRelPath = "/" + _files[resName].FirstOrDefault().Replace('\\', '/');
            }


            if(newRelPath.StartsWith("/"))
            {
                newRelPath = ConfigurationManager.AppSettings["baseUrl"] + newRelPath;
            }
            else
            {
                Console.WriteLine($"WARN: Relative link: {newRelPath}");
            }

            attr.Value = string.Format(valPattern, newRelPath.ToHtmlExt() + anchorRef);
        }

    }
}
