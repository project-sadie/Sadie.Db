namespace Sadie.Db.Models.Rooms;

public class RoomPaintSettings
{
    public int Id { get; init; }
    public Room? Room { get; init; }
    public int RoomId { get; init; }
    public required string FloorPaint { get; set; }
    public required string WallPaint { get; set; }
    public required string LandscapePaint { get; set; }
}