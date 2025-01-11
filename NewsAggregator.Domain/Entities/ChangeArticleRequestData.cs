using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class ChangeArticleRequestData : Entity
{
    public Guid ArticleId { get; set; }
    public Guid UserId { get; set; }
    public int PositionForChanging { get; set; }
    public string UpdatedText { get; set; }
    public DateTime RequestDate { get; set; }
}
