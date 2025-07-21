﻿using System.ComponentModel;
using Sadie.Enums.Unsorted;

namespace Sadie.Db.Models.Rooms;

public class RoomLayout
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? HeightMap { get; set; }
    public int DoorX { get; set; }
    public int DoorY { get; set; }
    public HDirection DoorDirection { get; set; }
    [DefaultValue(false)] public bool RequiresClubMembership { get; set; }
    public string? ExtraData { get; set; }
}