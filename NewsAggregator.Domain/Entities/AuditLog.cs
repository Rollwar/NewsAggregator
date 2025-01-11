using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class AuditLog : Entity
{
    public Guid UserId { get; set; }
    public string? Description { get; set; }
    public string? Comment { get; set; }
}
