using MediatR;

namespace CqrsDemo.Application.Features.Products.Queries.GetAllProducts
{
    public record GetAllProductsQuery : IRequest<List<ProductDto>>;
}
