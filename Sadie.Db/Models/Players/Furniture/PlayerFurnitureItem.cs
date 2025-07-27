using Sadie.Db.Models.Furniture;

namespace Sadie.Db.Models.Players.Furniture;

public class PlayerFurnitureItem
{
    public int Id { get; init; }
    public long PlayerId { get; init; }

    public required Player Player { get; init; }
    public required FurnitureItem FurnitureItem { get; init; }

    public PlayerFurnitureItemPlacementData? PlacementData { get; init; }

    public required string LimitedData { get; init; }
    public required string MetaData { get; init; }

    public DateTimeOffset CreatedAt { get; init; }
}