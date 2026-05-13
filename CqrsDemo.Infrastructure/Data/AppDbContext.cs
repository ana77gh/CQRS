using CqrsDemo.Application.Common.Interfaces;
using CqrsDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CqrsDemo.Infrastructure.Data
{
    public class AppDbContext : DbContext, IApplicationDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();
    }
}
