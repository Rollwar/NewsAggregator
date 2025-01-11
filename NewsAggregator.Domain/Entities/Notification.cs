using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class Notification : Entity
{
    public DateTime Created { get; set; }
    public bool IsSent { get; set; } = false;
    public uint RetryCount { get; set; } = 0;
    public string? Error { get; set; }
    public string Message { get; set; }
    public Guid UserId { get; set; }
}
