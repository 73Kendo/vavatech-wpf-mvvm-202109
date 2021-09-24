using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Vavatech.Shop.IServices;

namespace Vavatech.Shop.WPFClient.WpfServices
{
    public class WpfMessageBoxService : IMessageBoxService
    {
        public void ShowInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public DialogResult ShowQuestion(string question)
        {
            MessageBoxResult result = MessageBox.Show(question, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);

            return Map(result);
        }

        private static DialogResult Map(MessageBoxResult messageBoxResult)
        {
            return (DialogResult)messageBoxResult;
        }
    }
}
