using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Sadie.Shared.Attributes;

namespace Sadie.Db.Models.Players;

public class PlayerNavigatorSettings
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public Player? Player { get; init; }
    [DefaultValue(50)] [PacketData] public int WindowX { get; set; }
    [DefaultValue(50)] [PacketData] public int WindowY { get; set; }
    [DefaultValue(435)] [PacketData] public int WindowWidth { get; set; }
    [DefaultValue(535)] [PacketData] public int WindowHeight { get; set; }
    [DefaultValue(false)] [PacketData] public bool OpenSearches { get; set; }
    [PacketData] [NotMapped] public int ResultsMode { get; set; }
}