using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.IServices
{
    public interface IMessageAggregator
    {
        void Publish<TEvent>(TEvent @event)
            where TEvent : Message;

        void Subcribe<TEvent>(Action<TEvent> action);

    }

    //public class MessageAggregator : IMessageAggregator
    //{
    //    // private readonly ICollection subscibers = new List();

    //    public void Publish<TEvent>() where TEvent : Message
    //    {
    //        foreach (var subscibe in subscibers)
    //        {
    //            su
    //        }
    //    }

    //    public void Subcribe<TEvent>(Action<TEvent> action)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public abstract class Message
    { 

    }

    public class CustomerSelectedMessage : Message
    {
        public CustomerSelectedMessage(Customer customer)
        {
            Selected = customer;
        }

        public Customer Selected { get; }
    }

  


}
