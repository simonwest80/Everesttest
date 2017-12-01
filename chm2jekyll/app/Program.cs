using chm2jekyll.CHMParser;
using chm2jekyll.SourceProducer;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace chm2jekyll
{
    class Program
    {
        // Debug command lines:
        // "C:\everest\work\Help Files\Everest_Help\working-with-everest.chm"  "c:\temp\wwe" "C:\everest-docs\chm2jekyll\app\wwe-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\setting-up-a-company.chm"  "c:\temp\sc" "C:\everest-docs\chm2jekyll\app\sc-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\business-processes.chm"  "c:\temp\bp" "C:\everest-docs\chm2jekyll\app\bp-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\forms_designer.chm"  "c:\temp\fd" "C:\everest-docs\chm2jekyll\app\fd-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\managing-items.chm" "c:\temp\mi" "C:\everest-docs\chm2jekyll\app\mi-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\managing-vendors.chm" "c:\temp\mv" "C:\everest-docs\chm2jekyll\app\mv-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\managing-customers.chm" "c:\temp\mc"
        // "C:\everest\work\Help Files\Everest_Help\custom-tracking.chm" "c:\temp\ct"
        // "C:\everest\work\Help Files\Everest_Help\the-purchase-process.chm" "c:\temp\pp" "C:\everest-docs\chm2jekyll\app\pp-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\building-assemblies.chm" "c:\temp\ba" "C:\everest-docs\chm2jekyll\app\ba-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\warehouse-management.chm" "c:\temp\wm" "C:\everest-docs\chm2jekyll\app\wm-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\the-sales-process.chm" "c:\temp\sp" "C:\everest-docs\chm2jekyll\app\sp-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\point-of-sale.chm" "c:\temp\pos" "C:\everest-docs\chm2jekyll\app\pos-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\contact-manager.chm" "c:\temp\cm" "C:\everest-docs\chm2jekyll\app\cm-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\time-clock.chm" "c:\temp\tc"
        // "C:\everest\work\Help Files\Everest_Help\accounting.chm" "c:\temp\acc" "C:\everest-docs\chm2jekyll\app\acc-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\utility.chm" "c:\temp\utl" "C:\everest-docs\chm2jekyll\app\utl-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\Everest_Advanced_Dashboard.chm" "c:\temp\db"
        // "C:\everest\work\Help Files\Everest_Help\reports.chm" "c:\temp\rpt"
        // "C:\everest\work\Help Files\Everest_Help\report-manager.chm" "c:\temp\rmgr" "C:\everest-docs\chm2jekyll\app\rmgr-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\everest-us-payroll.chm" "c:\temp\prl" "C:\everest-docs\chm2jekyll\app\prl-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\everest-e-mail.chm" "c:\temp\eml"
        // "C:\everest\work\Help Files\Everest_Help\mailbridge.chm" "c:\temp\mb" "C:\everest-docs\chm2jekyll\app\mb-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\acrm.chm" "c:\temp\crm" "C:\everest-docs\chm2jekyll\app\crm-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\everest-advanced-edition---utilities.chm" "c:\temp\advutl" "C:\everest-docs\chm2jekyll\app\advutl-shorts.txt"
        // "C:\everest\work\Help Files\Everest_Help\Everest_Advance_Edition_Glossary.chm" "c:\temp\gloss"

        static int Main(string[] args)
        {
            if(args.Length < 2)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("chm2jekyll.exe <chm full path> <folder to extract to> [file with shorten]");
                return -1;
            }

            string chmFilePath = args[0];
            string dstDir = args[1];
            if (!File.Exists(chmFilePath))
            {
                Console.WriteLine("Cannot find source CHM ({0})", chmFilePath);
                return -2;
            }

            string shortsFile = null;
            if (args.Length >= 3)
            {
                shortsFile = args[2];
                if(!VerifyShortNames(shortsFile))
                {
                    return -3;
                }
            }


            if (!dstDir.EndsWith(Path.DirectorySeparatorChar.ToString()))
                dstDir += Path.DirectorySeparatorChar;

            Parser parser = new Parser();
            parser.Parse(args[0]);

            var producer = new Producer();
            producer.Generate(parser, dstDir, shortsFile);

            return 0;
        }

        static private bool VerifyShortNames(string shortsFile)
        {
            bool res = true;
            var names = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines(shortsFile);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (names.ContainsKey(parts[0]))
                {
                    if (string.Compare(names[parts[0]], parts[1], true) != 0)
                    {
                        Console.WriteLine($"Diff vals for the same key {parts[0]}");
                        res = false;
                    }
                    continue;
                }
                names.Add(parts[0], parts[1]);
            }
            return res;
        }

    }




}