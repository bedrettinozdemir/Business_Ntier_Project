using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Fluent_Validation
{
    public class ProductValidator : AbstractValidator<Product>

    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Product name shouldn't be empty.");
            RuleFor(x => x.Price).GreaterThan(100).WithMessage("Product price must be greater than 100CZK");
            RuleFor(x => x.Stock).GreaterThan(0).WithMessage("Stock can not be 0");
        }
    }
}
