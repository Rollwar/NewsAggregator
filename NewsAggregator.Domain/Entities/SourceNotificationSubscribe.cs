using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class SourceNotificationSubscribe : Entity
{
    public Guid UserId { get; set; }
    public Guid SourceId { get; set; }
    public User User { get; set; }
    public Source Source { get; set; }
}
