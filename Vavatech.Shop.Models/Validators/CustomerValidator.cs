using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.Shop.Models.Validators
{
    // Install-Package Fluentvalidation
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
        }
    }


    // Integracja FluentValidation z WPF 
    // https://github.com/sulmar/sulmar-inelo-wpf-mvvm

}
