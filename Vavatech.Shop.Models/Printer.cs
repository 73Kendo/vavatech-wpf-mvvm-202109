using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.Models
{

    public class Sender
    {
        private decimal unitPrice;

        private decimal totalCost;

        //public void Send(string text)
        //{
        //    totalCost += text.Length * unitPrice;
        //    Console.WriteLine(totalCost);
        //}

        //public void Send(byte[] image)
        //{
        //    totalCost += image.Length * unitPrice;
        //    Console.WriteLine(totalCost);
        //}

        // Szablon metody 
        public void Send<TItem>(TItem item)
        {    
            // zła praktyka
            if (item is Product)
            {

            }

            Type type = item.GetType();            

            totalCost += item.ToString().Length * unitPrice;
            Console.WriteLine(totalCost);
        }


    }


    // Szablon
    public class Printer<TItem>
        where TItem : class
    {
        private TItem last;

        public void Print(TItem item)
        {
            last = item;

            Console.WriteLine(item);
        }
    }

    public class ImagePrinter : Printer<byte[]>
    {

    }

    public class StringPrinter : Printer<string>
    {

    }

    public class Tester
    {
        public void PrintTest()
        {
            ImagePrinter imagePrinter = new ImagePrinter();
            imagePrinter.Print(null);

            StringPrinter stringPrinter = new StringPrinter();
            stringPrinter.Print("Hello World!");
        }
    }


}
