using System.ComponentModel.DataAnnotations;
using Sadie.Enums.Game.Players;
using Sadie.Enums.Miscellaneous;

namespace Sadie.Db.Models.Players;

public class PlayerAvatarData
{
    public int Id { get; init; }
    public long PlayerId { get; init; }

    public Player? Player { get; init; }

    [MaxLength(120)]
    public required string FigureCode { get; init; }

    [MaxLength(50)]
    public string? Motto { get; init; }

    public PlayerAvatarGender Gender { get; init; }
    public ChatBubble ChatBubbleId { get; init; }
}