using MediatR;

namespace CqrsDemo.Application.Features.Products.Events
{
    public record ProductCreatedEvent(
        Guid ProductId,
        string Name,
        decimal Price
    ) : INotification;
}

