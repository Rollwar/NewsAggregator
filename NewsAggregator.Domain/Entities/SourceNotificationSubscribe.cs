using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class SourceNotificationSubscribe : Entity
{
    public Guid UserId { get; set; }
    public Guid SourceId { get; set; }
}
