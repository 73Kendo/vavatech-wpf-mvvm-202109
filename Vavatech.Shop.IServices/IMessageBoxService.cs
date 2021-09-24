using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.IServices
{
    public interface IMessageBoxService
    {
        void ShowInformation(string message);

        DialogResult ShowQuestion(string question);
    }

    public enum DialogResult
    {
        Yes = 6,
        No = 7,
        IDontKown
    }
}
