using Sadie.Db.Models.Players;
using Sadie.Db.Models.Players.Furniture;
using Sadie.Db.Models.Rooms.Chat;
using Sadie.Db.Models.Rooms.Rights;

namespace Sadie.Db.Models.Rooms;

public interface IRoom
{
    int Id { get; init; }
    string Name { get; set; }
    int LayoutId { get; set; }
    RoomLayout? Layout { get; set; }
    long OwnerId { get; init; }
    Player Owner { get; set; }
    int MaxUsersAllowed { get; set; }
    string Description { get; set; }
    bool IsMuted { get; init; }
    RoomSettings Settings { get; set; }
    RoomPaintSettings? PaintSettings { get; set; }
    RoomChatSettings? ChatSettings { get; set; }
    ICollection<RoomPlayerRight> PlayerRights { get; init; }
    ICollection<RoomChatMessage> ChatMessages { get; init; }
    ICollection<RoomTag> Tags { get; init; }
    ICollection<PlayerRoomLike> PlayerLikes { get; init; }
    ICollection<PlayerFurnitureItemPlacementData> FurnitureItems { get; init; }
    DateTime CreatedAt { get; init; }
    Group? Group { get; init; }
    RoomDimmerSettings? DimmerSettings { get; set; }
    ICollection<PlayerRoomBan> PlayerBans { get; init; }
}