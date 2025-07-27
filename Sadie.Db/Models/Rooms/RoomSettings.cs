using Sadie.Enums.Game.Rooms;

namespace Sadie.Db.Models.Rooms;

public class RoomSettings
{
    public int Id { get; init; }
    public int RoomId { get; init; }
    public bool WalkDiagonal { get; init; }
    public RoomAccessType AccessType { get; init; }
    public string? Password { get; init; } = ""; 
    public int WhoCanMute { get; init; }
    public int WhoCanKick { get; init; }
    public int WhoCanBan { get; init; }
    public bool AllowPets { get; init; }
    public bool CanPetsEat { get; init; }
    public bool HideWalls { get; init; }
    public int WallThickness { get; init; }
    public int FloorThickness { get; init; }
    public bool CanUsersOverlap { get; init; }
    public RoomTradeOption TradeOption { get; init; }
}