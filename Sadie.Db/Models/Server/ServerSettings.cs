namespace Sadie.Db.Models.Server;

public class ServerSettings
{
    public string? PlayerWelcomeMessage { get; init; }
    public bool FairCurrencyRewards { get; init; }
    public DateTime CreatedAt { get; init; }
}