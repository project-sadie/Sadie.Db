namespace Sadie.Db.Models.Server;

public class ServerSettings
{
    public int Id { get; init; }
    public string? PlayerWelcomeMessage { get; init; }
    public bool FairCurrencyRewards { get; init; }
}