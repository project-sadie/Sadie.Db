using System.ComponentModel;

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
    [DefaultValue(0)] public int AchievementScore { get; init; }
    [DefaultValue(true)] public bool AllowFriendRequests { get; init; }
    [DefaultValue(false)] public bool IsOnline { get; set; }
    public DateTime? LastOnline { get; set; }
}