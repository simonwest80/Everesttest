using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chm2jekyll
{
    class Logger
    {
        static List<string> _warns = new List<string>();
        static List<string> _infos = new List<string>();

        public static void Warn(string msg)
        {
            _warns.Add(msg);
        }

        public static void Info(string msg)
        {
            _infos.Add(msg);
        }

        public static void Dump()
        {
            Console.WriteLine("******* WARNINGS *******");
            foreach (string w in _warns)
                Console.WriteLine("{0}", w);

            Console.WriteLine("******* INFOS *******");
            foreach (string i in _infos)
                Console.WriteLine("{0}", i);
        }
    }
}
