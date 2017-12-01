
using System;

using HtmlAgilityPack;
using ReverseMarkdown.Converters;
using ReverseMarkdown;
using System.Linq;

namespace chm2jekyll.SourceProducer
{
	public class TableEx
		: ConverterBase
	{
		public TableEx(Converter converter)
			: base(converter)
		{
		}

		public override string Convert(HtmlNode node)
		{
            string content = string.Empty;

            var trs = node.Descendants("tr").ToArray();
            var tds = node.Descendants("td").ToArray();
            if (trs.Length == 1)
            {
                if (tds.Length == 2)
                {
                    //get content of the first td
                    var html = tds[0].InnerHtml.ToLower();

                    //replace various constructions
                    /*                if (html.Contains("example.gif"))
                                        content = "![]({{site.wwe_baseurl}}/img/example.gif)";
                                    else if(html.Contains("steps.gif"))
                                        content = "![]({{site.wwe_baseurl}}/img/steps.gif)";
                                    else if (html.Contains("note.gif"))
                                        content = "![]({{site.wwe_baseurl}}/img/note.gif)";
                                    else if (html.Contains("refer.gif"))
                                        content = "![]({{site.wwe_baseurl}}/img/refer.gif)";
                                    else if (html.Contains("hint.gif"))
                                        content = "![]({{site.wwe_baseurl}}/img/hint.gif)";
                                    else if (html.Contains("warning.gif"))
                                        content = "![]({{site.wwe_baseurl}}/img/warning.gif)";*/

                    var style = string.Empty;
                    if (html.Contains("example.gif"))
                        style = "{:.example}";
                    else if (html.Contains("steps.gif"))
                        style = "{:.steps}";
                    else if (html.Contains("note.gif"))
                        style = "{:.note}";
                    else if (html.Contains("refer.gif"))
                        style = "{:.refer}";
                    else if (html.Contains("hint.gif"))
                        style = "{:.hint}";
                    else if (html.Contains("warning.gif"))
                        style = "{:.warn}";

                    if (!string.IsNullOrEmpty(style))
                    {
                        content = style + Environment.NewLine + this.TreatChildren(tds[1]).Trim();
                    }

                }
                else if(tds.Length == 1)
                {
                    if (tds[0].InnerHtml.ToLower().Contains("<object"))
                        content = Environment.NewLine + this.TreatChildren(tds[0]).Trim();
                }
            }

            if (string.IsNullOrEmpty(content))
            {
                Converter.InsideTable = true;
                content = this.TreatChildren(node);
                Converter.InsideTable = false;
            }

            var result =  Environment.NewLine + Environment.NewLine + content + Environment.NewLine;
            return result;
		}
	}
}
