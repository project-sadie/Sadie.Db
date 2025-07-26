namespace Sadie.Db.Models;

public class OauthClient
{
    public int Id { get; init; }
    public required string Secret { get; init; }
    public required string Domain { get; init; }
}