using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class AggregationRule : Entity
{
    public Guid SourceId { get; set; }
    public Guid WordAggregationPatternId { get; set; }
    public bool IsExclude { get; set; } = false;
}
