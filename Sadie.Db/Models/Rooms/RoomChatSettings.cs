using System.ComponentModel;

namespace Sadie.Db.Models.Rooms;

public class RoomChatSettings
{
    public int Id { get; init; }
    public int RoomId { get; init; }
    [DefaultValue(0)] public int ChatType { get; set; }
    [DefaultValue(1)] public int ChatWeight { get; set; }
    [DefaultValue(1)] public int ChatSpeed { get; set; }
    [DefaultValue(50)] public int ChatDistance { get; set; }
    [DefaultValue(1)] public int ChatProtection { get; set; }
}