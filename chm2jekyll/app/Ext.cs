using chm2jekyll.CHMParser;
using chm2jekyll.SourceProducer;
using HtmlAgilityPack;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace chm2jekyll
{
    static class Ex
    {
        public static string ToHtmlExt(this string path)
        {
            if (path.EndsWith(".htm", true, CultureInfo.CurrentCulture))
                return path.Substring(0, path.Length - 3) + "html";
            return path;
        }
    }
}