using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.FakeServices.Fakers
{

    public class ProductFaker : Faker<Product>
    {
        public ProductFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.Name, f => f.Commerce.ProductName());
            RuleFor(p => p.UnitPrice, f => Math.Round( f.Random.Decimal(1, 1000)));
            // RuleFor(p => p.UnitPrice, f => decimal.Parse( f.Commerce.Price()));
            RuleFor(p => p.Description, f => f.Lorem.Paragraph(1));
            RuleFor(p => p.IsDiscounted, f => f.Random.Bool(0.7f));
            RuleFor(p => p.Image, f => f.Image.LoremPixelUrl("technics").ToImage());
            //Ignore(p => p.Image);
            RuleFor(p => p.Color, f => f.Commerce.Color());
            RuleFor(p => p.BarCode, f => f.Commerce.Ean13());
        }
    }

    public static class StringExtensions
    {
        public static byte[] ToImage(this string url)
        {
            return new System.Net.WebClient().DownloadData(url);
        }
    }


}
