using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Vavatech.Shop.IServices;
using Vavatech.Shop.WPFClient.WpfServices;

namespace Vavatech.Shop.WPFClient.Behaviors
{
   
    public class CloseWindowBehavior : Behavior<Window>
    {
        private readonly IMessageBoxService messageBoxService;

        public CloseWindowBehavior()
            : this(new WpfMessageBoxService())
        {

        }

        public CloseWindowBehavior(IMessageBoxService messageBoxService)
        {
            this.messageBoxService = messageBoxService;
        }

        protected override void OnAttached()
        {
            Window window = this.AssociatedObject;

            window.Closing += AssociatedObject_Closing;
        }

        private void AssociatedObject_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult result = messageBoxService.ShowQuestion("Czy chcesz zapisać dane?");

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
