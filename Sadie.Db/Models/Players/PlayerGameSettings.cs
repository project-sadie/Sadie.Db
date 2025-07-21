using System.ComponentModel;

namespace Sadie.Db.Models.Players;

public class PlayerGameSettings
{
    public int Id { get; set; }
    public long PlayerId { get; set; }
    public Player? Player { get; set; }
    [DefaultValue(100)] public int SystemVolume { get; init; }
    [DefaultValue(100)] public int FurnitureVolume { get; init; }
    [DefaultValue(100)] public int TraxVolume { get; init; }
    [DefaultValue(false)] public bool PreferOldChat { get; init; }
    [DefaultValue(false)] public bool BlockRoomInvites { get; init; }
    [DefaultValue(false)] public bool BlockCameraFollow { get; init; }
    [DefaultValue(1)] public int UiFlags { get; init; }
    [DefaultValue(true)] public bool ShowNotifications { get; init; }
} 