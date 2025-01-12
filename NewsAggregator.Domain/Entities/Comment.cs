using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class Comment : Entity
{
    public Guid ArticleId { get; set; }
    public Guid UserId { get; set; }
    public string CommentText { get; set; }
    public User User { get; set; }
}
