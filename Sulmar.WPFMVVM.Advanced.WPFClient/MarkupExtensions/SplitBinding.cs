using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.MarkupExtensions
{
    public class SplitBinding : MarkupExtension
    {
        public string Source { get; set; }
        public char Separator { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if ((Source != null) && (Separator != null))
                return Parse(Source, Separator);

            else throw new InvalidOperationException("Inputs cannot be blank");
        }

        private IList<string> Parse(string source, char separator)
        {
            var items = source.Split(separator);

            return items;

        }
    }
}
