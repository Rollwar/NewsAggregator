using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class Feedback : Entity
{
    public Guid UserId { get; set; }
    public string HeaderText { get; set; }
    public string BodyText { get; set; }
}
