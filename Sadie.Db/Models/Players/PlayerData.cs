namespace Sadie.Db.Models.Players;

public class PlayerData
{
    public int Id { get; init; }
    public required Player Player { get; init; }
    public long PlayerId { get; init; }
    public int? HomeRoomId { get; set; }
    public int CreditBalance { get; set; }
    public int PixelBalance { get; set; }
    public int SeasonalBalance { get; set; }
    public int GotwPoints { get; set; }
    public int RespectPoints { get; set; }
    public int RespectPointsPet { get; init; }
    public int AchievementScore { get; init; }
    public bool AllowFriendRequests { get; init; }
    public bool IsOnline { get; set; }
    public DateTimeOffset? LastOnline { get; set; }
}