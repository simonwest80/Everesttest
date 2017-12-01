using chm2jekyll.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using chm2jekyll.CHMParser;
using System.IO;

namespace chm2jekyll.SourceProducer
{
    /// <summary>
    /// Builds folder structure
    /// 
    /// Updates sitemap entry context with:
    /// folder.FullPath
    /// folder.Name
    /// section.Name
    /// </summary>
    class FoldersGenerator : ISectionProcessor
    {
        string _baseFolder;
        Dictionary<string, string> _shortNames;

        public FoldersGenerator(string outputFolder, Dictionary<string, string> shortNames = null)
        {
            _shortNames = shortNames;
            _baseFolder = Path.GetFullPath(outputFolder).ToLower();
            if (!_baseFolder.EndsWith(Path.DirectorySeparatorChar.ToString()))
                _baseFolder += Path.DirectorySeparatorChar;
        }

        static int idx = 100000000;

        public void ProcessSection(SitemapEntry entry)
        {
            string sectionName = string.Empty, name = string.Empty, folderFullPath = string.Empty;

            if (entry.Parent != null)
            {
                //retrieve section name (getting last name since it was seen sometimes there are more than one Name param)
                sectionName = entry.GetLastParam("name");
                name = sectionName.SEO();

                string shortName;
                if (_shortNames != null && _shortNames.TryGetValue(name, out shortName))
                    name = shortName;

                //name = $"{idx++}";
                //File.AppendAllText(@"c:\temp\bp-shorts.txt", $"{sectionName.SEO()},{name}{Environment.NewLine}");

                folderFullPath = entry.Parent.Context[EntryContextType.folderFullPath] + name + Path.DirectorySeparatorChar;
            }
            else
            {
                //make sure base folder exists and empty
                if (Directory.Exists(_baseFolder))
                    Directory.Delete(_baseFolder, true);

                folderFullPath = _baseFolder;
            }

            Directory.CreateDirectory(folderFullPath);

            entry.Context[EntryContextType.folderFullPath] = folderFullPath;
            entry.Context[EntryContextType.folderName] = name;
            entry.Context[EntryContextType.sectionName] = sectionName;
        }
    }
}
