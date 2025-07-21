sshusing System.ComponentModel;
using Sadie.Enums.Game.Rooms;

namespace Sadie.Db.Models.Rooms;

public class RoomSettings
{
    public int Id { get; init; }
    public int RoomId { get; init; }
    [DefaultValue(true)] public bool WalkDiagonal { get; init; }
    [DefaultValue(RoomAccessType.Open)] public RoomAccessType AccessType { get; set; }
    [DefaultValue(null)] public string? Password { get; set; } = "";
    [DefaultValue(0)] public int WhoCanMute { get; set; }
    [DefaultValue(0)] public int WhoCanKick { get; set; }
    [DefaultValue(0)] public int WhoCanBan { get; set; }
    [DefaultValue(true)] public bool AllowPets { get; set; }
    [DefaultValue(true)] public bool CanPetsEat { get; set; }
    [DefaultValue(false)] public bool HideWalls { get; set; }
    [DefaultValue(0)] public int WallThickness { get; set; }
    [DefaultValue(0)] public int FloorThickness { get; set; }
    [DefaultValue(false)] public bool CanUsersOverlap { get; set; }
    public RoomTradeOption TradeOption { get; set; }
}