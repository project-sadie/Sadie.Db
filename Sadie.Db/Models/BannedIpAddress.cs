using Sadie.Db.Models.Players;

namespace Sadie.Db.Models;

public class BannedIpAddress
{
    public int Id { get; set; }
    public required long CreatorId { get; init; }
    public required Player Creator { get; init; }
    public required string Reason { get; init; }
    public required string IpAddress { get; set; }
    public DateTime CreatedAt { get; init; }
    public DateTime? ExpiresAt { get; init; }
}