
using HtmlAgilityPack;
using ReverseMarkdown;
using ReverseMarkdown.Converters;
using System;
using System.Linq;

namespace chm2jekyll.SourceProducer
{
	public class ImgEx
		: ConverterBase
	{
		public ImgEx(Converter converter)
			: base(converter)
		{
		}

		public override string Convert(HtmlNode node)
		{
			string alt = node.GetAttributeValue("alt", string.Empty);
			string src = node.GetAttributeValue("src", string.Empty);
			string title = this.ExtractTitle(node);

			title = title.Length > 0 ? string.Format(" \"{0}\"", title) : "";

            var result = string.Format("![{0}]({1}{2})", alt, src, title);


            //handle image map
            string htmlAttr = string.Empty;
            string usemap = node.GetAttributeValue("usemap", null);
            if(usemap != null)
            {
                htmlAttr = $"usemap=\"{usemap}\"";
                string style = node.GetAttributeValue("style", null);
                if (style != null)
                {
                    style = style.Replace("\r", "");
                    style = style.Replace("\n", "");
                    style = style.Replace("\t", "");
                    style = style.Replace(" ", "");
                    htmlAttr += $" style=\"{style}\"";
                }
            }

            if (!string.IsNullOrEmpty(htmlAttr))
                result += "{:" + htmlAttr + "}";

            if (src.ToLower().Contains("kanadi.gif"))
                result = "{:.see_also}" + Environment.NewLine + "See also";

            return result;
		}
	}
}
