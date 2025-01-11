using Microsoft.EntityFrameworkCore;
using NewsAggregator.Application.Common;

namespace NewsAggregator.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // TODO - add init values for init project
    }
}
