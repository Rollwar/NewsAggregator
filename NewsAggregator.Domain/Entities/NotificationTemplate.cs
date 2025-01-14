﻿using NewsAggregator.Domain.Common;

namespace NewsAggregator.Domain.Entities;

public class NotificationTemplate : Entity
{
    public string Subject { get; set; }
    public string BodyPlainText { get; set; }
    public Guid SourceId { get; set; }
    public Source Source { get; set; }
}
