using System.ComponentModel;
using Sadie.Db.Models.Furniture;

namespace Sadie.Db.Models.Players.Furniture;

public class PlayerFurnitureItem
{
    public int Id { get; init; }
    public long PlayerId { get; set; }
    public required Player Player { get; set; }
    public required FurnitureItem FurnitureItem { get; init; }
    public PlayerFurnitureItemPlacementData? PlacementData { get; set; }
    [DefaultValue("")] public required string LimitedData { get; init; }
    [DefaultValue("")] public required string MetaData { get; set; }
    public DateTime CreatedAt { get; init; }
}