using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class Article : Entity
{
    public Guid SourceId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public ICollection<ArticleEmotion> ArticleEmotionss { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<ChangeArticleRequestData> ChangeArticleRequests { get; set; }
}
