using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace chm2jekyll.SourceProducer
{
    static class ProducerExt
    {
        public static string SEO(this string input)
        {
            return Regex.Replace(input.ToLower(), @"[^A-Za-z0-9_\.~]+", "-");
        }
    }
}
