using System.ComponentModel.DataAnnotations.Schema;
using Sadie.Db.Models.Players.Furniture;
using Sadie.Db.Models.Rooms;
using Sadie.Db.Models.Server;
using Sadie.Enums.Game.Players;

namespace Sadie.Db.Models.Players;

public class Player
{
    public Player()
    {
    }

    public long Id { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
    public ICollection<Role> Roles { get; init; } = [];
    public DateTime CreatedAt { get; init; }
    public PlayerData? Data { get; init; }
    public PlayerAvatarData? AvatarData { get; init; }
    public List<PlayerTag> Tags { get; init; } = [];
    public ICollection<PlayerRoomLike> RoomLikes { get; init; } = [];
    [InverseProperty("OriginPlayer")] public ICollection<PlayerRelationship> Relationships { get; init; } = [];
    
    public PlayerNavigatorSettings? NavigatorSettings { get; init; }
    
    public PlayerGameSettings? GameSettings { get; init; }
    
    public ICollection<PlayerBadge> Badges { get; init; } = [];

    public ICollection<PlayerFurnitureItem> FurnitureItems { get; init; }
    
    public ICollection<PlayerWardrobeItem> WardrobeItems { get; init; } = [];
    public ICollection<PlayerSubscription> Subscriptions { get; init; } = [];
    [InverseProperty("TargetPlayer")] public ICollection<PlayerRespect> Respects { get; init; } = [];
    public ICollection<PlayerSavedSearch> SavedSearches { get; init; } = [];
    
    [InverseProperty("OriginPlayer")]  public ICollection<PlayerFriendship> OutgoingFriendships { get; init; }
    [InverseProperty("TargetPlayer")]  public ICollection<PlayerFriendship> IncomingFriendships { get; init; }
    
    public ICollection<ServerPeriodicCurrencyRewardLog> RewardLogs { get; init; } = [];
    
    public ICollection<Room> Rooms { get; set; }
    public ICollection<PlayerIgnore> Ignores { get; set; }

    public ICollection<Group> Groups { get; init; } = [];
    public ICollection<PlayerBot> Bots { get; init; } = [];
    public ICollection<PlayerRoomVisit> RoomVisits { get; init; } = [];
    public ICollection<PlayerBan> Bans { get; init; } = [];
    
    public int GetAcceptedFriendshipCount()
    {
        return IncomingFriendships.Count(x => x.Status == PlayerFriendshipStatus.Accepted) + 
               OutgoingFriendships.Count(x => x.Status == PlayerFriendshipStatus.Accepted);
    }

    public List<PlayerFriendship> GetMergedFriendships()
    {
        return OutgoingFriendships
            .Concat(IncomingFriendships)
            .Where(x => x.Status == PlayerFriendshipStatus.Accepted)
            .ToList();
    }

    public bool IsFriendsWith(int targetId)
    {
        return IncomingFriendships.FirstOrDefault(x =>
                   x.OriginPlayerId == targetId && x.Status == PlayerFriendshipStatus.Accepted) !=
               null 
               ||
               OutgoingFriendships.FirstOrDefault(x =>
                   x.TargetPlayerId == targetId && x.Status == PlayerFriendshipStatus.Accepted) !=
               null;
    }

    public PlayerFriendship? TryGetAcceptedFriendshipFor(long targetId)
    {
        var incoming = IncomingFriendships
            .FirstOrDefault(x => x.OriginPlayerId == targetId && x.Status == PlayerFriendshipStatus.Accepted);

        if (incoming != null)
        {
            return incoming;
        }
        
        return OutgoingFriendships
            .FirstOrDefault(x => x.OriginPlayerId == targetId && x.Status == PlayerFriendshipStatus.Accepted);
    }

    public PlayerFriendship? TryGetFriendshipFor(long targetId)
    {
        var incoming = IncomingFriendships
            .FirstOrDefault(x => x.OriginPlayerId == targetId);

        if (incoming != null)
        {
            return incoming;
        }
        
        return OutgoingFriendships
            .FirstOrDefault(x => x.TargetPlayerId == targetId);
    }

    public void DeleteFriendshipFor(long targetId)
    {
        var incoming = IncomingFriendships
            .FirstOrDefault(x => x.OriginPlayerId == targetId);

        if (incoming != null)
        {
            IncomingFriendships.Remove(incoming);
        }

        var outgoing = OutgoingFriendships
            .FirstOrDefault(x => x.OriginPlayerId == targetId);
        
        if (outgoing != null)
        {
            OutgoingFriendships.Remove(outgoing);
        }
    }

    public bool HasPermission(string name)
    {
        return Roles.Any(r => r.Permissions.Any(x => x.Name == name));
    }
}