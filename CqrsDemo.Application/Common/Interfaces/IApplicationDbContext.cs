using Microsoft.EntityFrameworkCore;
using CqrsDemo.Domain.Entities;
using System.Threading.Tasks;

namespace CqrsDemo.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
