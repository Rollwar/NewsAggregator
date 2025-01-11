using NewsAggregator.Domain.Common;
using NewsAggregator.Domain.Enums;

namespace NewsAggregator.Domain.Entities;

public class UserLogin : Entity
{
    public LoginProvider LoginProvider { get; set; }
    public string ProviderKey { get; set; }
    public Guid UserId { get; set; }
}