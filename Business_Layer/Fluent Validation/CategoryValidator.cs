using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Fluent_Validation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Category name should be filled");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Category name should be minumum 5 length");
        }
    }
}
