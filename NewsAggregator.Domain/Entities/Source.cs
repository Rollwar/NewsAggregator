using NewsAggregator.Domain.Common;
using NewsAggregator.Domain.Enums;

namespace NewsAggregator.Domain.Entities;

public class Source : Entity
{
    public string SourceName { get; set; }
    public string SourceConnection { get; set; }
    public byte[]? DefaultArticleImage { get; set; }
    public SourceType SourceType { get; set; }
    public ICollection<AggregationRule> AggregationRules { get; set; }
    public ICollection<Article> Articles { get; set; }
}
