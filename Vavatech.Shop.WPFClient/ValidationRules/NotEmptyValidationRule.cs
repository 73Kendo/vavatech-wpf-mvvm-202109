using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Vavatech.Shop.WPFClient.ValidationRules
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string text = (string)value;

            if (string.IsNullOrEmpty(text))
            {
                return new ValidationResult(false, "Tekst nie może być jest pusty");
            }

            else

                return ValidationResult.ValidResult;

            // return new ValidationResult(true, string.Empty);
        }
    }
}
