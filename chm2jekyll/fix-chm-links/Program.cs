using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace fix_chm_links
{
    class ChmArea
    {
        Dictionary<string, List<string>> _fileMap = new Dictionary<string, List<string>>();
        public ChmBaseInfo ChmInfo { private set; get; }
        string[] _files;

        public ChmArea(ChmBaseInfo chmInfo)
        {
            ChmInfo = chmInfo;
        }

        public void Parse()
        {
            //build map
            _files = Directory.EnumerateFiles(ChmInfo.Path, "*.md", SearchOption.AllDirectories).ToArray();
            foreach(var file in _files)
            {
                var name = Path.GetFileNameWithoutExtension(file).ToLower();
                var newFile = Path.Combine(Path.GetDirectoryName(file), name + ".html");

                if (!_fileMap.ContainsKey(name))
                    _fileMap[name] = new List<string>();

                _fileMap[name].Add(newFile.Substring(ChmInfo.Path.Length));
            }
        }

        internal string getLinkToResource(string resFileName)
        {
            if (!_fileMap.ContainsKey(resFileName))
            {
                //Console.WriteLine($"{ChmInfo.ChmName}: cannot find {resFileName} in the area");
                return null;
            }

            return "{{" + ChmInfo.Placeholder + "}}/" + _fileMap[resFileName].First().Replace("\\", "/");
        }

        internal void FixChmLinks(Func<string, string> linkConverterF)
        {
            var rx = new Regex(@"[^(;"" ]*\.chm::[^""); ]*");

            foreach(var file in _files)
            {
                bool hasReplacement = false;
                string[] lines = File.ReadAllLines(file);
                for(int i = 0; i < lines.Length; i++)
                {
                    MatchCollection coll = rx.Matches(lines[i]);
                    if(coll.Count > 0)
                    {
                        foreach (Match match in coll)
                        {
                            var link = match.Value.Trim('(', ')');
                            string newLink;
                            try
                            {
                                newLink = linkConverterF(link);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine($"Broken link: {link} in {file} ({e.Message})");
                                continue;
                            }

                            if (newLink != null)
                            {
                                lines[i] = lines[i].Replace(match.Value, newLink);
                                hasReplacement = true;
                            }
                            else
                            {
                                Console.WriteLine($"No link found for {match.Value}");
                            }
                        }
                    }
                }

                if (hasReplacement)
                    File.WriteAllLines(file, lines);
            }
        }
    }

    class ChmBaseInfo
    {
        public string Folder { set; get; }
        public string Placeholder { set; get; }

        public string ChmName { set; get; }

        public string Path { set; get; }
    }

    class ChmBaseInfoProvider
    {

        public static ChmBaseInfo[] GetInfos(string basePath)
        {
            ChmBaseInfo[] chmBases = new ChmBaseInfo[]
            {
                new ChmBaseInfo { Folder = "about-online-help", Placeholder = "site.aoh_chm", ChmName = "about-online-help.chm" },
                new ChmBaseInfo { Folder = "accounting", Placeholder = "site.acc_chm", ChmName = "accounting.chm" },
                new ChmBaseInfo { Folder = "building-assemblies", Placeholder = "site.ba_chm", ChmName = "building-assemblies.chm" },
                new ChmBaseInfo { Folder = "business-processes-in-everest", Placeholder = "site.bp_chm", ChmName = "business-processes.chm" },
                new ChmBaseInfo { Folder = "contact-manager", Placeholder = "site.cm_chm", ChmName = "contact-manager.chm" },
                new ChmBaseInfo { Folder = "custom-tracking", Placeholder = "site.ct_chm", ChmName = "custom-tracking.chm" },
                new ChmBaseInfo { Folder = "everest-advanced-dashboard", Placeholder = "site.db_chm", ChmName = "everest_advanced_dashboard.chm" },
                new ChmBaseInfo { Folder = "everest-advanced-edition-utilities", Placeholder = "site.advutl_chm", ChmName = "everest-advanced-edition-utilities.chm" },
                new ChmBaseInfo { Folder = "everest-crm", Placeholder = "site.crm_chm", ChmName = "acrm.chm" },
                new ChmBaseInfo { Folder = "everest-e-mail", Placeholder = "site.eml_chm", ChmName = "everest-e-mail.chm" },
                new ChmBaseInfo { Folder = "everest-mailbridge", Placeholder = "site.mb_chm", ChmName = "mailbridge.chm" },
                new ChmBaseInfo { Folder = "everest-us-payroll", Placeholder = "site.prl_chm", ChmName = "everest-us-payroll.chm" },
                new ChmBaseInfo { Folder = "forms-designer", Placeholder = "site.fd_chm", ChmName = "forms_designer.chm" },
                new ChmBaseInfo { Folder = "glossary", Placeholder = "site.gloss_chm", ChmName = "everest_advance_edition_glossary.chm" },
                new ChmBaseInfo { Folder = "managing-customers", Placeholder = "site.mc_chm", ChmName = "managing-customers.chm" },
                new ChmBaseInfo { Folder = "managing-items", Placeholder = "site.mi_chm", ChmName = "managing-items.chm" },
                new ChmBaseInfo { Folder = "managing-vendors", Placeholder = "site.mv_chm", ChmName = "managing-vendors.chm" },
                new ChmBaseInfo { Folder = "point-of-sale", Placeholder = "site.pos_chm", ChmName = "point-of-sale.chm" },
                new ChmBaseInfo { Folder = "reports", Placeholder = "site.rpt_chm", ChmName = "reports.chm" },
                new ChmBaseInfo { Folder = "reports-manager", Placeholder = "site.rmgr_chm", ChmName = "report-manager.chm" },
                new ChmBaseInfo { Folder = "sales", Placeholder = "site.sp_chm", ChmName = "the-sales-process.chm" },
                new ChmBaseInfo { Folder = "setting-up-a-company", Placeholder = "site.sc_chm", ChmName = "setting-up-a-company.chm" },
                new ChmBaseInfo { Folder = "the-purchase-process", Placeholder = "site.pp_chm", ChmName = "the-purchase-process.chm" },
                new ChmBaseInfo { Folder = "time-clock", Placeholder = "site.tc_chm", ChmName = "time-clock.chm" },
                new ChmBaseInfo { Folder = "utilities", Placeholder = "site.utl_chm", ChmName = "utility.chm" },
                new ChmBaseInfo { Folder = "warehouse-management", Placeholder = "site.wm_chm", ChmName = "warehouse-management.chm" },
                new ChmBaseInfo { Folder = "working-with-everest", Placeholder = "site.wwe_chm", ChmName = "working-with-everest.chm" },
            };
            var chmBasesResult = new List<ChmBaseInfo>();

            string[] srcFolders = chmBases.Select(x => x.Folder).ToArray();

            var dirs = Directory.EnumerateDirectories(basePath, "*", SearchOption.TopDirectoryOnly);
            foreach (var dir in dirs)
            {
                string folder = dir.Substring(dir.LastIndexOf('\\') + 1);

                var chmBaseInfo = chmBases.FirstOrDefault(x => x.Folder == folder);
                if (chmBaseInfo != null)
                {
                    chmBaseInfo.Path = dir + "\\";
                    chmBasesResult.Add(chmBaseInfo);
                }
            }

            if(chmBasesResult.Count != chmBases.Length)
                Console.WriteLine($"WARN: Epxected {chmBases.Length} folder, but found {chmBasesResult.Count}");

            return chmBasesResult.ToArray();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            string basePath = @"C:\everest-docs\docs-src\";
            ChmBaseInfo[] chmBases = ChmBaseInfoProvider.GetInfos(basePath);

            var areas = new List<ChmArea>();
            foreach(var chmBase in chmBases)
            {
                Console.WriteLine($"Parsing files for {chmBase.Path}");
                var area = new ChmArea(chmBase);
                area.Parse();
                areas.Add(area);
            }


            // process each *.md and do link tweaks as following:
            //   abc.chm::/filename => {{abc_chm}}/path/filename

            Func<string, string > linkConverterF = (string link) =>
            {
                //link verification
                link = link.ToLower().Trim();

                //expected exacty two semicolumns
                var parts = link.Split(':');
                if (parts.Length != 3)
                {
                    Console.WriteLine($"Incorrect number of entries for ':': {link}");
                    return null;
                }

                //expecting link to be like abc.chm::/path
                string chmFileName = parts[0];
                string resFileName = Path.GetFileNameWithoutExtension(parts[2]);

                ChmArea chmArea = areas.FirstOrDefault(x => x.ChmInfo.ChmName == chmFileName);
                if(chmArea == null)
                {
                    //fallback for link within main help file
                    //  search in all areas for the resource

                    var fallbackLinks = new List<string>();
                    var fallbackAreas = new List<string>();
                    if (chmFileName == "everest_help.chm")
                    {
                        foreach(ChmArea area in areas)
                        {
                            string ln = area.getLinkToResource(resFileName);
                            if (ln != null)
                            {
                                fallbackLinks.Add(ln);
                                fallbackAreas.Add(area.ChmInfo.ChmName);
                            }
                        }

                        if (fallbackLinks.Count > 1)
                        {
                            //do not fix link if resource in more than one area, need manual intervention
                            Console.WriteLine($"WARN: {link} available in the following areas {string.Join(",", fallbackAreas.ToArray())}");
                        }
                        else if (fallbackLinks.Count > 0)
                        {
                            return fallbackLinks.FirstOrDefault();
                        }
                    }

                    //Console.WriteLine($"Cannot find area for : {chmFileName}");
                    return null;
                }

                return chmArea.getLinkToResource(resFileName);
            };

            foreach(var area in areas)
            {
                area.FixChmLinks(linkConverterF);
            }
        }
    }
}




























