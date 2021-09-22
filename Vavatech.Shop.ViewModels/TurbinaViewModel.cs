using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.ViewModels
{
    public class TurbinaViewModel : BaseViewModel
    {
        public ICollection<dynamic> Items { get; set; }

        public TurbinaViewModel()
        {
            Items = new List<dynamic>();

            dynamic item1 = new ExpandoObject();
            item1.Name = "Wirnik";
            item1.Speed = "100";
            item1.Resurs = "1000";

            dynamic item2 = new ExpandoObject();
            item2.Name = "Łożysko";
            item2.Speed = "50";
            item2.Resurs = "200";

            Items.Add(item1);
            Items.Add(item2);
        }
    }
}
