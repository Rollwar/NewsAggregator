using NewsAggregator.Domain.Common;
using System.Security;

namespace NewsAggregator.Domain.Entities;

public class User : Entity
{
    public string Email { get; set; }
    public SecureString PasswordHash { get;set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Phone { get; set; }
    public string Info { get; set; }
}
