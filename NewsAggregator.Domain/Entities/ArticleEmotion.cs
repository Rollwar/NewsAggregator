using NewsAggregator.Domain.Common;
using NewsAggregator.Domain.Enums;

namespace NewsAggregator.Domain.Entities;

public class ArticleEmotion : Entity
{
    public Guid ArticleId { get; set; }
    public Emotion Emotion { get; set; }
    public Guid UserId { get; set; }
}
