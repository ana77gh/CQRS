using MediatR;

namespace CqrsDemo.Application.Features.Products.Commands.CreateProduct
{
    public record CreateProductCommand(
        string Name, 
        decimal Price
        ) : IRequest<Guid>;

}
