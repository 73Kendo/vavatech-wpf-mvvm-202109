using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.Models.SearchCriterias
{
    public abstract class SearchCriteria : Base
    {

    }

    public class ProductSearchCriteria : SearchCriteria
    {
        public string Color { get; set; }
        public decimal? FromUnitPrice { get; set; }
        public decimal? ToUnitPrice { get; set; }
    }
}
