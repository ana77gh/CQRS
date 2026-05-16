using FluentValidation;

namespace CqrsDemo.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Product name is required.");

            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithMessage("Product price must be greater than zero.");
        }
    }
}
