namespace Sadie.Db.Models.Constants;

public class ServerRoomConstants
{
    public int MaxChatMessageLength { get; init; }
    public int SecondsTillUserIdle { get; init; }
    public int MaxNameLength { get; init; }
    public int MaxDescriptionLength { get; init; }
    public int MaxTagLength { get; init; }
    public int WiredMaxFurnitureSelection { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
}