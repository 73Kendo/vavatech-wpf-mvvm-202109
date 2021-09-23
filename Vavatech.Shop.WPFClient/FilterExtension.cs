using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.WPFClient
{
    public class FilterExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new FilterEventHandler((s, e) =>
            {
                Product product = e.Item as Product;

                e.Accepted = product.IsDiscounted;

            });
        }
    }
}
