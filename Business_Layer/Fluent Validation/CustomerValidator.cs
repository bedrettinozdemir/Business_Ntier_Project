using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Fluent_Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Customer Name not allowed to be empty");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Customer City must be aleast 3 vovel");
            RuleFor(x => x.Name).MaximumLength(12).WithMessage("Customer name mustbe maksimum 12 character");
        }
    }
}
