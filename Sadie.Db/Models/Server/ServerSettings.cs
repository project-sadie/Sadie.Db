namespace Sadie.Db.Models.Server;

public class ServerSettings
{
    public int Id { get; set; }
    
    public string? PlayerWelcomeMessage { get; init; }
    public bool FairCurrencyRewards { get; init; }
}