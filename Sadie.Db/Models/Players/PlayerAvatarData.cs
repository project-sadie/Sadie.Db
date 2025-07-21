using System.ComponentModel;
using Sadie.Enums.Unsorted;

namespace Sadie.Db.Models.Players;

public class PlayerAvatarData
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public Player? Player { get; init; }
    public required string FigureCode { get; set; }
    public string? Motto { get; set; }
    public AvatarGender Gender { get; set; }
    [DefaultValue(0)] public ChatBubble ChatBubbleId { get; set; }
}