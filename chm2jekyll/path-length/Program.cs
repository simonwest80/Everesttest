using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace path_length
{
    class Program
    {
        static void Main(string[] args)
        {
            //string folder = @"C:\temp\sc2\setting-up-a-company\";
            //            string folder = @"C:\temp\sc1\100000000\";
            //string folder = @"C:\temp\wwe\working-with-everest\";
            //string folder = @"C:\temp\bp\business-processes-in-everest\";
            //string folder = @"C:\temp\fd\forms-designer\";
            //string folder = @"C:\temp\mi\managing-items\";
            //string folder = @"C:\temp\mv\managing-vendors\";
            //string folder = @"C:\temp\mc\managing-customers\";
            //string folder = @"C:\temp\ct\custom-tracking\";
            //string folder = @"C:\temp\pp1\purchasing\";
            //string folder = @"C:\temp\ba\building-assemblies\";
            //string folder = @"C:\temp\wm\warehouse-management\";
            //string folder = @"C:\temp\sp\sales\";
            //string folder = @"C:\temp\pos\point-of-sale\";
            //string folder = @"C:\temp\cm\contact-manager\";
            //string folder = @"C:\temp\tc\time-clock\";
            //string folder = @"C:\temp\acc\accounting\";
            //string folder = @"C:\temp\utl\utilities\";
            //string folder = @"C:\temp\db\everest-advanced-dashboard\";
            //string folder = @"C:\temp\rpt\reports\";
            //string folder = @"C:\temp\rmgr\reports-manager\";
            //string folder = @"C:\temp\prl\everest-us-payroll\";
            //string folder = @"C:\temp\eml\everest-e-mail\";
            //string folder = @"C:\temp\mb\everest-mailbridge\";
            //string folder = @"C:\temp\crm\everest-crm\";
            string folder = @"C:\temp\advutl\everest-advanced-edition-utilities\";


            IEnumerable <string> files = Directory.EnumerateFiles(folder, "*", SearchOption.AllDirectories);

            int maxLen = 1;
            foreach (var filePath in files)
            {
                int curLen = filePath.Length;

                if (curLen > 140)
                {
                    maxLen = curLen;
                    Console.WriteLine($"{filePath}");
                }
            }

            Console.WriteLine($"Max length: {maxLen}");

        }
    }
}


