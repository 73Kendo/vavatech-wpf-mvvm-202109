using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Vavatech.Shop.WPFClient.Behaviors
{

    // Install-Package Microsoft.Xaml.Behaviors.Wpf
    public class MouseEnterButtonBehavior : Behavior<Button>
    {
        public double Offset { get; set; }

        //public ICommand Command
        //{
        //    get
        //    { 
        //        return (ICommand) GetValue(CommandProperty); 
        //    }
        //    set
        //    {
        //        SetValue(CommandProperty, value);
        //    }
        //}

        //public static readonly DependencyProperty CommandProperty
        //    = DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(MouseEnterButtonBehavior), new PropertyMetadata());

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Command.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(MouseEnterButtonBehavior), new PropertyMetadata(null));



        protected override void OnAttached()
        {
            Button button = this.AssociatedObject;

            button.MouseEnter += Button_MouseEnter;

            button.MouseDoubleClick += Button_MouseDoubleClick;
        }

        private void Button_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // AssociatedObject.Width -= Offset;
            Command?.Execute(null);
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            AssociatedObject.Width += Offset;
        }
    }
}
