using Microsoft.EntityFrameworkCore;
using NewsAggregator.Domain.Entities;

namespace NewsAggregator.Application.Common;

public interface IApplicationDbContext
{
    public DbSet<AggregationRule> AggregationRules { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<ArticleEmotion> ArticleEmotions { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<ChangeArticleRequestData> ChangeArticleRequestData { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<NotificationTemplate> NotificationTemplates { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserLogin> UsersLogin { get; set; }
    public DbSet<Source> Sources { get; set; }
    public DbSet<SourceNotificationSubscribe> SourceNotificationSubscribes { get; set; }
    public DbSet<WordAggregationPattern> WordAggregationPatterns { get; set; }
}
