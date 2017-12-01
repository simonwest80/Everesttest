
using HtmlAgilityPack;
using ReverseMarkdown;
using ReverseMarkdown.Converters;
using System;

namespace chm2jekyll.SourceProducer
{
	public class TdEx
		: ConverterBase
	{
		public TdEx(Converter converter)
			: base(converter)
		{
		}

		public override string Convert(HtmlNode node)
		{
            string content = this.TreatChildren(node).Trim();
            content = content.Replace(Environment.NewLine, "<br/>");

			return string.Format(" {0} |", content);
		}
    }
}
