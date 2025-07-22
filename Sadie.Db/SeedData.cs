using Microsoft.EntityFrameworkCore;
using Sadie.Db.Models;
using Sadie.Db.Models.Catalog;
using Sadie.Db.Models.Catalog.FrontPage;
using Sadie.Db.Models.Constants;
using Sadie.Db.Models.Navigator;
using Sadie.Db.Models.Players;
using Sadie.Db.Models.Rooms;
using Sadie.Db.Models.Server;

namespace Sadie.Db;

public static class SeedData
{
    public static void SeedPermissions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Permission>().HasData(
            new Permission { Id = 1, Name = "moderator" },
            new Permission { Id = 2, Name = "command_shutdown" },
            new Permission { Id = 3, Name = "command_hotel_alert" },
            new Permission { Id = 4, Name = "command_user_info" },
            new Permission { Id = 5, Name = "command_kick" },
            new Permission { Id = 6, Name = "command_kick_all" },
            new Permission { Id = 7, Name = "command_unload" },
            new Permission { Id = 8, Name = "any_room_owner" },
            new Permission { Id = 9, Name = "any_room_rights" }
        );
    }

    public static void SeedRoles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "User" },
            new Role { Id = 5, Name = "Moderator" },
            new Role { Id = 6, Name = "Admin" }
        );
    }

    public static void SeedRoomLayouts(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoomLayout>().HasData(
            new RoomLayout
            {
                Name = "model_basa",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxx\r\nx22222222222222222222x\r\nx22222222222222222222x\r\nx22222222222222222222x\r\nx22222222222222222222x\r\nx22222222222222222222x\r\nx22222222222222222222x\r\nx22222222222222222222x\r\nx000x11xxxxxxxx11x000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nx00000000000000000000x\r\nxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 15,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_4",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxx\r\nxXXXXXXXX9999999999999x\r\nxXXXXXXXX9999999999999x\r\nxXXXXXXXX9999999999999x\r\nxXXXXXXXX9999999999999x\r\nx00000000XXXXXXX999999x\r\nx00000000XXXXXXX999999x\r\nx00000000XXXXXXX999999x\r\nx00000000XXXXXXX999999x\r\nx000000000000000999999x\r\nx000000000000000999999x\r\nx000000000000000999999x\r\n0000000000000000999999x\r\nx000000000000000XXXXXXx\r\nx000000000000000XXXXXXx\r\nx000000000000000XXXXXXx\r\nx000000000000000XXXXXXx\r\nx000000000000000XXXXXXx\r\nx000000000000000XXXXXXx\r\nxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 12,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_3",
                Heightmap =
                    "XXXXXXXXXXXXXXXXX\r\nXXX0000000000000X\r\nXXX0000000000000X\r\nXXX0000000000000X\r\nXXX0000000000000X\r\nXXX0000000000000X\r\nXXX0000000000000X\r\nX000000000000000X\r\nX000000000000000X\r\nX000000000000000X\r\n0000000000000000X\r\nX000000000000000X\r\nX000000000000000X\r\nX000000000000000X\r\nXXXXXXXXXXXXXXXXX",
                DoorX = 0,
                DoorY = 10,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_b2g",
                Heightmap =
                    "xxxxxxxxxxxxxx\r\nx00000x000000x\r\nx000000000000x\r\nx00000x000000x\r\nx00000x000000x\r\nx00000x000000x\r\nx00000x000000x\r\nxxx0xxx000000x\r\nx000000000000x\r\nx000000000000x\r\nx000000000000x\r\nx000000000000x\r\nx000000000000x\r\nx000000000000x\r\nx000000000000x\r\nx000000000000x\r\nx000000000000x\r\nx00000xx00000x\r\nxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 0,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_opening",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxx\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx2222xx111111111111\r\nx2222xx000000000000\r\nx2222xx000000000000\r\nx2222xx000000000000\r\nx2222xx000000000000\r\nx2222xx000000000000\r\n22222xx000000000000\r\nx2222xx000000000000\r\nxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 23,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_y",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx00000000xx0000000000xx0000x\r\nx00000000xx0000000000xx0000x\r\n000000000xx0000000000xx0000x\r\nx00000000xx0000000000xx0000x\r\nx00000000xx0000xx0000xx0000x\r\nx00000000xx0000xx0000xx0000x\r\nx00000000xx0000xx0000000000x\r\nx00000000xx0000xx0000000000x\r\nxxxxx0000xx0000xx0000000000x\r\nxxxxx0000xx0000xx0000000000x\r\nxxxxx0000xx0000xxxxxxxxxxxxx\r\nxxxxx0000xx0000xxxxxxxxxxxxx\r\nx00000000xx0000000000000000x\r\nx00000000xx0000000000000000x\r\nx00000000xx0000000000000000x\r\nx00000000xx0000000000000000x\r\nx0000xxxxxxxxxxxxxxxxxx0000x\r\nx0000xxxxxxxxxxxxxxxxxx0000x\r\nx00000000000000000000000000x\r\nx00000000000000000000000000x\r\nx00000000000000000000000000x\r\nx00000000000000000000000000x\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 3,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_oscar",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx11111111xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxx11xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111x11111111x00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111x11111111x00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111x11111111x00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111111111111100000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111111111111100000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111x11111111x00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111x11111111x00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111111x11111111x00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxx11xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 15,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_u",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxx\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\n11111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nx1111100000000000000000x\r\nxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 17,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_z",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxx00000000000000000000\r\nxxxxxxxxxxx00000000000000000000\r\nxxxxxxxxxxx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\n000000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nx00000000xx00000000000000000000\r\nxxxxxxxxxxx00000000000000000000\r\nxxxxxxxxxxx00000000000000000000\r\nxxxxxxxxxxx00000000000000000000\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 9,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_w",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx2222xx1111111111xx11111111\r\nx2222xx1111111111xx11111111\r\n222222111111111111111111111\r\nx22222111111111111111111111\r\nx22222111111111111111111111\r\nx22222111111111111111111111\r\nx2222xx1111111111xx11111111\r\nx2222xx1111111111xx11111111\r\nx2222xx1111111111xxxx1111xx\r\nx2222xx1111111111xxxx0000xx\r\nxxxxxxx1111111111xx00000000\r\nxxxxxxx1111111111xx00000000\r\nx22222111111111111000000000\r\nx22222111111111111000000000\r\nx22222111111111111000000000\r\nx22222111111111111000000000\r\nx2222xx1111111111xx00000000\r\nx2222xx1111111111xx00000000\r\nx2222xxxx1111xxxxxxxxxxxxxx\r\nx2222xxxx0000xxxxxxxxxxxxxx\r\nx2222x0000000000xxxxxxxxxxx\r\nx2222x0000000000xxxxxxxxxxx\r\nx2222x0000000000xxxxxxxxxxx\r\nx2222x0000000000xxxxxxxxxxx\r\nx2222x0000000000xxxxxxxxxxx\r\nx2222x0000000000xxxxxxxxxxx",
                DoorX = 0,
                DoorY = 3,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_x",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxx\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nxxx00xxx0000xxx00xxx\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\n0000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000xxxxxx000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 12,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "park_b",
                Heightmap =
                    "0000x0000000\r\n0000xx000000\r\n000000000000\r\n00000000000x\r\n000000000000\r\n00x0000x0000",
                DoorX = 11,
                DoorY = 2,
                DoorDirection = 6,
                RequiresClubMembership = false,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_0",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx00000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx00000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx00000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000\r\n000000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000\r\nx00000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000\r\nx00000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0000\r\nx00000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx00000000xx00000000xx00000000xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 4,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_v",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxx\r\nx222221111111111111x\r\nx222221111111111111x\r\n2222221111111111111x\r\nx222221111111111111x\r\nx222221111111111111x\r\nx222221111111111111x\r\nxxxxxxxx1111xxxxxxxx\r\nxxxxxxxx0000xxxxxxxx\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx00000000000x000000x\r\nx00000000000x000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nxxxxxxxx00000000000x\r\nx000000x00000000000x\r\nx000000x0000xxxxxxxx\r\nx00000000000x000000x\r\nx00000000000x000000x\r\nx00000000000x000000x\r\nx00000000000x000000x\r\nxxxxxxxx0000x000000x\r\nx000000x0000x000000x\r\nx000000x0000x000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nx000000000000000000x\r\nxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 3,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_t",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nx222222222222222222222222222x\r\nx222222222222222222222222222x\r\n2222222222222222222222222222x\r\nx222222222222222222222222222x\r\nx2222xxxxxx222222xxxxxxx2222x\r\nx2222xxxxxx111111xxxxxxx2222x\r\nx2222xx111111111111111xx2222x\r\nx2222xx111111111111111xx2222x\r\nx2222xx11xxx1111xxxx11xx2222x\r\nx2222xx11xxx0000xxxx11xx2222x\r\nx22222111x00000000xx11xx2222x\r\nx22222111x00000000xx11xx2222x\r\nx22222111x00000000xx11xx2222x\r\nx22222111x00000000xx11xx2222x\r\nx22222111x00000000xx11xx2222x\r\nx22222111x00000000xx11xx2222x\r\nx2222xx11xxxxxxxxxxx11xx2222x\r\nx2222xx11xxxxxxxxxxx11xx2222x\r\nx2222xx111111111111111xx2222x\r\nx2222xx111111111111111xx2222x\r\nx2222xxxxxxxxxxxxxxxxxxx2222x\r\nx2222xxxxxxxxxxxxxxxxxxx2222x\r\nx222222222222222222222222222x\r\nx222222222222222222222222222x\r\nx222222222222222222222222222x\r\nx222222222222222222222222222x\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 3,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_s",
                Heightmap = "xxxxxx\r\nx00000\r\nx00000\r\n000000\r\nx00000\r\nx00000\r\nx00000\r\nx00000",
                DoorX = 0,
                DoorY = 3,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "park_a",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx0xxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx00xxxxxxxxxxxx\r\nxxxxxxxxxxxxx0x00xxxxxxxxxxx0x000xxxxxxxxxxx\r\nxxxxxxxxxxxx0000000000000000000000xxxxxxxxxx\r\nxxxxxxxxxxx000000000000000000000000xxxxxxxxx\r\nxxxxxxxxxxx0000000000000000000000000xxxxxxxx\r\nxxxxxxxxxxx00000000000000000000000000xxxxxxx\r\nxxxxxxxx000000000000000000000000000000xxxxxx\r\nxxxxxxx00000000000000000000000000000000xxxxx\r\nxxxxxxx000000000000000000000000000000000xxxx\r\nxxxxxxx0000000000000000000000000000000000xxx\r\nxxxxxxxxx000000000000000000000000000000000xx\r\n00000000000000000000xx00000000000000000000xx\r\n0000000000000000000xxxx00000000000xxxxxxx0xx\r\n0000000000000000000xxxx00000000000x00000xxxx\r\nxxxxx00x0000000000xxxxx0xxxxxx0000x0000000xx\r\nxxxxx0000000000000xxxxx0xx000x0000x000000xxx\r\nxxxxx0000000000000xxxxx0x000000000x00000xxxx\r\nxxxxx000000x0000000xxxx0x000000000xxx00xxxxx\r\nxxxxxxxx000x0000000xxx00xxx000000x0000xxxxxx\r\nxxxxxxxx000x000000xxxx0x0000000000000xxxxxxx\r\nxxxxxxxx000x000000011100000000000000xxxxxxxx\r\nxxxxxxxx000x00000001110000000000000xxxxxxxxx\r\nxxxxxxxxx00x0000000111x00000000x00xxxxxxxxxx\r\nxxxxxxxxxx0x0000000xxx0000000xxxxxxxxxxxxxxx\r\nxxxxxxxxxxxx000000xxxx0000000xxxxxxxxxxxxxxx\r\nxxxxxxxxxxxx000000xxx00xxxxx00xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxx0xxx0xx000x00xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxx0xxx0x000000xxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxx0xxxxx00000xxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxx0xxxxx00xxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxx0xxxxxxxxxxxxxxxxxxxx",
                DoorX = 2,
                DoorY = 15,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "RPHN527parkfence2SFQAHHHN529parkfence2QGQAHHHM619parkfence1SDRAHHHO620parkfence3PERAHPAHO621parkfence3QERAHPAHO622parkfence3RERAHPAHN623parkfence2SERAHPAHO624parkfence3PFRAHPAHO625parkfence3QFRAHPAHO626parkfence3RFRAHPAHM627parkfence1SFRAHJHO629parkfence3QGRAHJHN717parkfence2QDSAHHHO719parkfence3SDSAHJHO723parkfence3SESAHJHO727parkfence3SFSAHJHO729parkfence3QGSAHJHO817parkfence3QDPBHJHO819parkfence3SDPBHJHN821parkfence2QEPBHHHO823parkfence3SEPBHJHN825parkfence2QFPBHHHO827parkfence3SFPBHJHO829parkfence3QGPBHJHL98bench2PBQBHPAHK99benchQBQBHPAHO917parkfence3QDQBHJHN919parkfence2SDQBHRAHO921parkfence3QEQBHJHN923parkfence2SEQBHRAHO925parkfence3QFQBHJHN927parkfence2SFQBHRAHO929parkfence3QGQBHJHO1017parkfence3QDRBHJHO1021parkfence3QERBHJHO1025parkfence3QFRBHJHO1029parkfence3QGRBHJHL117bench2SASBHJHM1117parkfence1QDSBHPAHO1118parkfence3RDSBHPAHO1119parkfence3SDSBHPAHO1120parkfence3PESBHPAHN1121parkfence2QESBHJHO1122parkfence3RESBHPAHO1123parkfence3SESBHPAHO1124parkfence3PFSBHPAHN1125parkfence2QFSBHJHO1126parkfence3RFSBHPAHO1127parkfence3SFSBHPAHO1128parkfence3PGSBHPAHM1129parkfence1QGSBHRAHK127benchSAPCHJHL1635bench2SHPDHJHL1637bench2QIPDHPAHK1638benchRIPDHPAHK1735benchSHQDHJHL1827bench2SFRDHPAHK1828benchPGRDHPAHL1835bench2SHRDHJHL1925bench2QFSDHJHK1935benchSHSDHJHK2025benchQFPEHJHL2925bench2QFQGHPAHK2926benchRFQGHPAHL3023bench2SERGHJHK3123benchSESGHJ@`SGSBMRDPBPA0.0I2Mqueue_tile2JMPGRAH0.0I2Mqueue_tile2SAMPFSAJ0.0I2Mqueue_tile2QBMRFSAPA0.0I2Mqueue_tile2SFMSERBJ0.0I2Mqueue_tile2SCMRFPBPA0.0I2Mqueue_tile2REMPGQBH0.0I2Mqueue_tile2PGMPFRBH0.0I2Mqueue_tile2PCMPEPBH0.0I2Mqueue_tile2QGMRFRBJ0.0I2Mqueue_tile2QDMRDQBPA0.0I2Mqueue_tile2RFMRERBJ0.0I2Mqueue_tile2PFMSDRBJ0.0I2Mqueue_tile2PDMPGPBH0.0I2Mqueue_tile2RGMSFRBJ0.0I2Mqueue_tile2RAMRESAPA0.0I2Mqueue_tile2RBMPGSAH0.0I2Mqueue_tile2SDMREQBPA0.0I2Mqueue_tile2QEMRFQBPA0.0I2Mqueue_tile2RCMPFPBH0.0I2Mqueue_tile2KMRDSAPA0.0I2Mqueue_tile2PAMPESAJ0.0I2Mqueue_tile2PBMQFSAJ0.0I2Mqueue_tile2IMPGQAH0.0I2Mqueue_tile2SEMRDRBJ0.0I2Mqueue_tile2QCMREPBPA0.0I2Mqueue_tile2SGMPGRBH0.0I2Mqueue_tile2QAMQESAJ0.0I2Mqueue_tile2QFMPERBH0.0I2Mqueue_tile2RDMPEQBH0.0I2Mqueue_tile2PEMPFQBH0.0I2Mqueue_tile2"
            },
            new RoomLayout
            {
                Name = "the_den",
                Heightmap =
                    "00000000xxxxxxxx\r\n0000000000000000\r\n0000000000000000\r\n000000000000xx00\r\n0000000000000000\r\n0000000000000000\r\n0000000000000000\r\nx000000000000000\r\n0000000000000000\r\n0000000000000000\r\n0000000000000000\r\n0000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nxxx00xxxxxxxxxxx\r\nxxx00xxxxxxxxxxx\r\nxxx00xxxxxxxxxxx\r\nGV00000000xxxxxxxx\r\n0000000000000000\r\n0000000000000000\r\n000000000000xx00\r\n0000000000000000\r\n0000000000000000\r\n0000000000000000\r\nx000000000000000\r\n0000000000000000\r\n0000000000000000\r\n0000000000000000\r\n0000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nx000000000000000\r\nxxx00xxxxxxxxxxx\r\nxxx00xxxxxxxxxxx\r\nxxx00xxxxxxxxxxx",
                DoorX = 3,
                DoorY = 22,
                DoorDirection = 0,
                RequiresClubMembership = false,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "cinema_a",
                Heightmap =
                    "xxxxxxx1xx11111111xxxxxx\r\nxxx1111111111111111xxxxx\r\nxxx111xxxx1111111111xxxx\r\nxxxx2xxxxxxxxxxxxxxxxxxx\r\nxx3x3x333311xxxxxxxxxx11\r\nxx3333333311111111111111\r\nxx3333333311111111111111\r\nxx3333333311111111122111\r\nxx3333333311x22222222111\r\nxx3333333311x22222222111\r\nxx3333333311xxxxxxxxx111\r\nxx3333333311111111111111\r\nxx3333333311111111111111\r\nxx3333333311111111111111\r\nxx3333333311111xxxx11111\r\nxx3333333311111xxxx11111\r\nxx3333333311111xxxx11111\r\nxx3333333311111xxxx11111\r\nxx3333333311111xxxx11111\r\nxx3333333311111xxxx11111\r\nxx3333333311111xxxx11111\r\n333333332111111xxxx11111\r\n333333332111111111111111\r\n333333332111111111111111\r\n333333332111111111111111\r\nxx3333332111111111111111\r\nxxxxxxxxxxxxxxxxxxx11111\r\nxxxxxxxxxxxxxxxxxxx11111\r\nxxxxxxxxxxxxxxxxxxx11111",
                DoorX = 20,
                DoorY = 27,
                DoorDirection = 0,
                RequiresClubMembership = false,
                ExtraData =
                    "PUHC42orangeJPAKHHA47loungey_chairSAPAKJHV48loungey_tablebigbPBPAKHHA49loungey_chairQBPAKRAHA52loungey_chairJQAKPAHA57loungey_chairSAQAKJHU58loungey_tablebigaPBQAKHHA59loungey_chairQBQAKRAHB62loungey_tableJRAKHHA72loungey_chairJSAKHHh713theater_chairQCSAIHHh714theater_chairRCSAIHHh715theater_chairSCSAIHHh716theater_chairPDSAIHHh717theater_chairQDSAIHHh718theater_chairRDSAIHHz721stairQESAIHHL89lightpoleQBPBKHHq813pomomaskiQCPBJJHq814pomomaskiRCPBJHHq815pomomaskiSCPBJHHq816pomomaskiPDPBJHHq817pomomaskiQDPBJHHq818pomomaskiRDPBJHHq819pomomaskiSDPBJIHz821stairQEPBIHHC92orangeJQBKHHh913theater_chairQCQBJHHh914theater_chairRCQBJHHh915theater_chairSCQBJHHh916theater_chairPDQBJHHh917theater_chairQDQBJHHh918theater_chairRDQBJHHh919theater_chairSDQBJHHh920theater_chairPEQBJHHz921stairQEQBIHHA102loungey_chairJRBKPAHA109loungey_chairQBRBKPAHB112loungey_tableJSBKHHB119loungey_tableQBSBKHHA122loungey_chairJPCKHHA129loungey_chairQBPCKHHd1217cubicb_chairQDPCIRAHc1219cubico_chairSDPCIJHd1315cubicb_chairSCQCIJHL1319lightpoleSDQCIHHd1320cubicb_chairPEQCIRAHL149lightpoleQBRCKHHA152loungey_chairJSCKPAHd1514cubicb_chairRCSCIPAHc1519cubico_chairSDSCIPAHB162loungey_tableJPDKHHA167loungey_chairSAPDKJHB168loungey_tablePBPDKJHA169loungey_chairQBPDKRAHd1613cubicb_chairQCPDIJHd1614cubicb_chairRCPDIRAHC1619orangeSDPDIHHA172loungey_chairJQDKHHA177loungey_chairSAQDKJHB178loungey_tablePBQDKJHA179loungey_chairQBQDKRAHd1719cubicb_chairSDQDIJHC182orangeJRDKHHd1814cubicb_chairRCRDIPAHK192bardesqueJSDKHHK202bardesqueJPEKIHb203bar_chairKPEKRAHL209lightpoleQBPEKHHd2014cubicb_chairRCPEIHHd2019cubicb_chairSDPEIJHc2020cubico_chairPEPEIRAHK212bardesqueJQEKIHb213bar_chairKQEKRAHd2119cubicb_chairSDQEIHHK222bardesqueJREKIHb223bar_chairKREKRAHL2216lightpolePDREIHHc2218cubico_chairRDREIHHK232bardesqueJSEKIHb233bar_chairKSEKRAHK242bardesqueJPFKIHb243bar_chairKPFKRAHK252bardesqueJQFKJ"
            },
            new RoomLayout
            {
                Name = "picnic",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxx22222xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\n22xxxxxxxxxxxxx22xxxxxxxxxxxxxxxxxxxxx\r\n2222222222222222222x222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222xxx222222222222222222222222\r\n2222222222xx33x22222222222222222222222\r\n222222222xx3333x2222222222222222222222\r\n222222222x333333x222222222222222222222\r\n222222222x333333x222222222222222222222\r\n2222222222x3332x2222222222222222222222\r\n22222222222x33x22222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222x22222xxxx22222222222222222222\r\n22222222222222xxxx22222222222222222222\r\n22222222222222xxx222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222\r\n22222222222222222222222222222222222222",
                DoorX = 16,
                DoorY = 5,
                DoorDirection = 4,
                RequiresClubMembership = false,
                ExtraData =
                    "PcHh710hedge7RBSAJPAHh711hedge7SBSAJPAHh712hedge7PCSAJPAHh713hedge7QCSAJPAHy714hedge8RCSAJPAHs718hedge2RDSAJPAHh719hedge7SDSAJPAHh720hedge7PESAJPAHh721hedge7QESAJPAHz814hedge9RCPBJPAHz818hedge9RDPBJPAHv93hedge5KQBJPAHz103hedge9KRBJPAHc1112picnic_dummychair1PCSBKPAHc1113picnic_dummychair1QCSBKPAHc1114picnic_dummychair1RCSB`hFFPAHc1310picnic_dummychair1RBQCKJHc1315picnic_dummychair1SCQCKRAHb1321picnic_groundQEQCJPAHb147picnic_groundSARCJPAHc1410picnic_dummychair1RBRCKJHc1415picnic_dummychair1SCRCKRAHb1519picnic_groundSDSCJJHb1523picnic_groundSESCJRAHb165picnic_groundQAPDJJHb169picnic_groundQBPDJRAHL1620picnic_cloth1PEPDJJHL176picnic_cloth1RAQDJJHb1721picnic_groundQEQDJHHb187picnic_groundSARDJHHa190picnic_redbench2HSDJJHA200picnic_redbench1HPEJJHw2011hedge6SBPEJPAHh2012hedge7PCPEJPAHh2013hedge7QCPEJPAHt2014hedge3RCPEJPAHu2017hedge4QDPEJPAHh2018hedge7RDPEJPAHh2019hedge7SDPEJPAHy2020hedge8PEPEJPAHv2111hedge5SBQEJPAHM2112picnic_bench1PCQEJPAHN2113picnic_bench2QCQEJPAHO2114picnic_bench3RCQEJPAHM2117picnic_bench1QDQEJPAHN2118picnic_bench2RDQEJPAHO2119picnic_bench3SDQEJPAHv2120hedge5PEQEJPAHa220picnic_redbench2HREJJHv2211hedge5SBREJPAHv2220hedge5PEREJPAHb2225picnic_groundQFREJPAHA230picnic_redbench1HSEJJHv2311hedge5SBSEJPAHM2312picnic_bench1PCSEJJHM2319picnic_bench1SDSEJRAHv2320hedge5PESEJPAHc246picnic_dummychair1RAPFJPAHd247picnic_dummychair4SAPFJPAHe248picnic_dummychair6PBPFJPAHv2411hedge5SBPFJPAHN2412picnic_bench2PCPFJJHN2419picnic_bench2SDPFJRAHv2420hedge5PEPFJPAHb2423picnic_groundSEPFJJHb2427picnic_groundSFPFJRAHK255picnic_stumpQAQFJJHv2511hedge5SBQFJPAHN2512picnic_bench2PCQFJJHN2519picnic_bench2SDQFJRAHv2520hedge5PEQFJPAHG2524picnic_cloth2PFQFJJHK267picnic_stumpSARFJHHv2611hedge5SBRFJPAHO2612picnic_bench3PCRFJJHH2614picnic_fireplace1RCRFJHHI2616picnic_fireplace2PDRFJJHO2619picnic_bench3SDRFJRAHv2620hedge5PERFJPAHb2625picnic_groundQFRFJHHz2711hedge9SBSFJPAHQ2712picnic_lemonadePCSFJPAHz2720hedge9PESFJPAHE298picnic_firewood2PBQGJHHa300picnic_redbench2HRGJJHD308picnic_firewood1PBRGJHHA310picnic_redbench1HSGJJHD318picnic_firewood1PBSGJHHM3112picnic_bench1PCSGJPAHN3113picnic_bench2QCSGJPAHO3114picnic_bench3RCSGJPAHM3118picnic_bench1RDSGJPAHN3119picnic_bench2SDSGJPAHO3120picnic_bench3PESGJPAHf3127picnic_carrotSFSGJHHf3128picnic_carrotPGSGJHHf3129picnic_carrotQGSGJHHf3130picnic_carrotRGSGJHHf3131picnic_carrotSGSGJHHD328picnic_firewood1PBPHJHHF3212picnic_table2PCPHJJHP3214picnic_tableRCPHJJHF3218picnic_table2RDPHJJHP3220picnic_tablePEPHJJHr333hedge1KQHJPAHD338picnic_firewood1PBQHJHHM3312picnic_bench1PCQHJHHN3313picnic_bench2QCQHJHHO3314picnic_bench3RCQHJHHM3318picnic_bench1RDQHJHHN3319picnic_bench2SDQHJHHO3320picnic_bench3PEQHJHHg3327picnic_cabbageSFQHJHHg3328picnic_cabbagePGQHJHHg3329picnic_cabbageQGQHJHHv343hedge5KRHJPAHD348picnic_firewood1PBRHJHHv353hedge5KSHJPAHD358picnic_firewood1PBSHJHHv363hedge5KPIJPAHD368picnic_firewood1PBPIJHHD378picnic_firewood1PBQIJHHM3712picnic_bench1PCQIJPAHN3713picnic_bench2QCQIJPAHO3714picnic_bench3RCQIJPAHM3718picnic_bench1RDQIJPAHN3719picnic_bench2SDQIJPAHO3720picnic_bench3PEQIJPAHD388picnic_firewood1PBRIJHHF3812picnic_table2PCRIJJHP3814picnic_tableRCRIJJHF3818picnic_table2RDRIJJHP3820picnic_tablePERIJJHJ398picnic_firewood3PBSIJHHM3912picnic_bench1PCSIJHHN3913picnic_bench2QCSIJHHO3914picnic_bench3RCSIJHHM3918picnic_bench1RDSIJHHN3919picnic_bench2SDSIJHHO3920picnic_bench3PESIJH"
            },
            new RoomLayout
            {
                Name = "custom_model",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxx0000000000000xxxx\r\nxxxxxxxxxxx000000000000000xxx\r\nxxxxxxxxxx00000000000000000xx\r\nxxxxxxxxxx00000000000000000xx\r\nxxxxxxxxxx00000000000000000xx\r\nxxxxxxxxxx11111111111111111xx\r\nxxxxxxxxxx22222222222222222xx\r\nxxxxxxxxxx22222222222222222xx\r\nxxxxxxxxxx22222222222222222xx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 0,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "theater",
                Heightmap =
                    "XXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXXXXXXXXXXXXXXXXXX\r\nXXXXXXX111111111XXXXXXX\r\nXXXXXXX11111111100000XX\r\nXXXX00X11111111100000XX\r\nXXXX00x11111111100000XX\r\n4XXX00X11111111100000XX\r\n4440000XXXXXXXXX00000XX\r\n444000000000000000000XX\r\n4XX000000000000000000XX\r\n4XX0000000000000000000X\r\n44400000000000000000000\r\n44400000000000000000000\r\n44X00000000000000000000\r\n44X11111111111111111000\r\n44X11111111111111111000\r\n33X11111111111111111000\r\n22X11111111111111111000\r\n22X11111111111111111000\r\n22X11111111111111111000\r\n22X11111111111111111000\r\n22X11111111111111111000\r\n22211111111111111111000\r\n22211111111111111111000\r\nXXXXXXXXXXXXXXXXXXXX00X\r\nXXXXXXXXXXXXXXXXXXXX00X",
                DoorX = 20,
                DoorY = 27,
                DoorDirection = 0,
                RequiresClubMembership = false,
                ExtraData =
                    "QKHm1011micSBRBIHHd112thchair2JSBPAJHd122thchair2JPCPAJHd152thchair2JSCPAJHc156thchair1RASCHHHc157thchair1SASCHHHc158thchair1PBSCHHHc159thchair1QBSCHHHc1510thchair1RBSCHHHc1512thchair1PCSCHHHc1513thchair1QCSCHHHc1514thchair1RCSCHHHc1515thchair1SCSCHHHc1516thchair1PDSCHHHd162thchair2JPDPAJHc206thchair1RAPEIHHc207thchair1SAPEIHHc208thchair1PBPEIHHc209thchair1QBPEIHHc2010thchair1RBPEIHHc2012thchair1PCPEIHHc2013thchair1QCPEIHHc2014thchair1RCPEIHHc2015thchair1SCPEIHHc2016thchair1PDPEIHHc236thchair1RASEIHHc237thchair1SASEIHHc238thchair1PBSEIHHc239thchair1QBSEIHHc2310thchair1RBSEIHHc2312thchair1PCSEIHHc2313thchair1QCSEIHHc2314thchair1RCSEIHHc2315thchair1SCSEIHHc2316thchair1PDSEIHHc266thchair1RARFIHHc267thchair1SARFIHHc268thchair1PBRFIHHc269thchair1QBRFIHHc2610thchair1RBRFIHHc2612thchair1PCRFIHHc2613thchair1QCRFIHHc2614thchair1RCRFIHHc2615thchair1SCRFIHHc2616thchair1PDRFIH"
            },
            new RoomLayout
            {
                Name = "orient",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxx00000000xxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1000000000xxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxx1xx000x000xx111x111xxx\r\nxxxxxxxxxxxxxx1xx000x000xxxxxx1111xx\r\nxxxxxxxxxxxxxx1xx000x000x111111111xx\r\nxxxxxxxxxxxxxx1xx000x000x111111111xx\r\nxxx111111111111xx000x000x111111111xx\r\nxxx1xxxxxxxxxxxxx000x000x111111111xx\r\nxxx1x1111111111000000000x111111111xx\r\nxxx1x1111111111000000000xx1111111xxx\r\nxxx1x11xxxxxx11000000000xx1111111100\r\nxxx111xxxxxxx11000000000011111111100\r\nxxx111xxxxxxx11000000000011111111100\r\nxxxxx1xxxxxxx11000000000011111111100\r\nxxxxx11xxxxxx11000000000xx1111111100\r\nxxxxx1111111111000000000xx1111111xxx\r\nxxxxx1111111111xx000x000x111111111xx\r\nxxxxxxxxxxxxxxxxx000x000x111111111xx\r\nxxxxxxxxxxxxxxxxx000x000x111111111xx\r\nxxxxxxxxxxxxxxxxx000x000x111111111xx\r\nxxxxxxxxxxxxxxxxx000x000x111111111xx\r\nxxxxxxxxxxxxxxxxx000x00xx11xxxx111xx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxx11111111xx",
                DoorX = 35,
                DoorY = 22,
                DoorDirection = 6,
                RequiresClubMembership = false,
                ExtraData =
                    "SOHd1017benchQDRBHJHd1019benchSDRBHRAHd1021benchQERBHJHd1023benchSERBHRAHd1117benchQDSBHJHd1119benchSDSBHRAHd1121benchQESBHJHd1123benchSESBHRAHb1132koc_chairPHSBIPAHd1217benchQDPCHJHd1219benchSDPCHRAHd1221benchQEPCHJHd1223benchSEPCHRAHb1231koc_chairSGPCIJHa1232koc_tablePHPCIHHb1233koc_chairQHPCIRAHd1317benchQDQCHJHd1319benchSDQCHRAHd1321benchQEQCHJHd1323benchSEQCHRAHb1325koc_chairQFQCIPAHb1332koc_chairPHQCIHHd1417benchQDRCHJHd1419benchSDRCHRAHd1421benchQERCHJHd1423benchSERCHRAHa1425koc_tableQFRCIHHb1426koc_chairRFRCIRAHd1517benchQDSCHJHd1519benchSDSCHRAHd1521benchQESCHJHd1523benchSESCHRAHb1525koc_chairQFSCIHHb1529koc_chairQGSCIJHa1530koc_tableRGSCIHHb1531koc_chairSGSCIRAHb1630koc_chairRGPDIHHc2425chairf1QFPFIJHc2433chairf1QHPFIRAHd2517benchQDQFHJHd2519benchSDQFHRAHd2521benchQEQFHJHd2523benchSEQFHRAHc2525chairf1QFQFIJHc2533chairf1QHQFIRAHd2617benchQDRFHJHd2619benchSDRFHRAHd2621benchQERFHJHd2623benchSERFHRAHc2625chairf1QFRFIJHc2633chairf1QHRFIRAHd2717benchQDSFHJHd2719benchSDSFHRAHd2721benchQESFHJHd2723benchSESFHRAHd2817benchQDPGHJHd2819benchSDPGHRAHd2821benchQEPGHJHd2823benchSEPGHRAHd2917benchQDQGHJHd2919benchSDQGHRAHd2921benchQEQGHJHd2923benchSEQG`hFFRA"
            },
            new RoomLayout
            {
                Name = "dusty_lounge",
                Heightmap =
                    "xxxxxxxxxxxxxx22xxxxxxxxxxxxx\r\nxxxxxxxxxx222x222x2xxxxxxxxxx\r\nxxxxxxx33322222222223xxxxxxx3\r\nxxxxxxx33322222222223xxxxxxx3\r\nxxxxxxx33322222222223x33333x3\r\nxxxxxxx33322222222223x33333x3\r\nxx111xx33322222222223xxxxxxx3\r\nxx111xxx332222222222333333333\r\nxx111xxxx32222222222333333333\r\nxx111xxxxxx222222222333333333\r\nxx111xxxxxxx1111111x333333333\r\nxx111xxxxxxx1111111x222222222\r\nxx111xxxxxx111111111111111111\r\nxx111xxxxxx111111111111111111\r\n11111xxxxxx111111111111111111\r\n11111xxxxxx111111111111111111\r\n11x11xxxxxx111111111111111111\r\n11xxxxxxxxx11111111111111111x\r\nx11xxxxxxxxx1111111x1111111xx\r\nxx11xxxxxxx111111111111111xxx\r\nxxx11xxxxxx11111111111111xxxx\r\nxxxx11111111111111111111xxxxx\r\nxxxxx11111111111111xxxxxxxxxx\r\nxxxxxxxxxxx11111111xxxxxxxxxx\r\nxxxxxxxxxxx11111111xxxxxxxxxx",
                DoorX = 14,
                DoorY = 1,
                DoorDirection = 4,
                RequiresClubMembership = false,
                ExtraData =
                    "QHHc48greenchair2PBPAKPAHd49greenchair1QBPAKPAHc68greenchair2PBRAKHHd69greenchair1QBRAKHHa620dustylampPERAKJHa628dustylampPGRAKJHc73greenchair2KSAIPAHd74greenchair1PASAIPAHc93greenchair2KQBIHHd94greenchair1PAQBIHHb1021yellowchairQERBKJHb1023yellowchairSERBKRAHb1026yellowchairRFRBKJHb1028yellowchairPGRBKRAHc1211greenchair2SBPCIJHc133greenchair2KQCIPAHd134greenchair1PAQCIPAHd1311greenchair1SBQCIJHa1411dustylampSBRCIJHc153greenchair2KSCIHHd154greenchair1PASCIHHc1511greenchair2SBSCIJHb1524yellowchairPFSCIPAHd1611greenchair1SBPDIJHb1722yellowchairREQDIJHa1724dustylampPFQDIJHb1726yellowchairRFQDIRAHa1911dustylampSBSDIJHb1924yellowchairPFSDIHHc2312greenchair2PCSEIJHc2314greenchair2RCSEIRAHd2412greenchair1PCPFIJHd2414greenchair1RCPFIRA"
            },
            new RoomLayout
            {
                Name = "netcafe",
                Heightmap =
                    "xxxxx1111xxxxxxxxxxx1xxxx\r\nxxxxx1111111111111111xxxx\r\nxxxxx1111111111111111xxxx\r\nxxxxx1111111111111111xxxx\r\nxxxxxxxx0000000000000xxxx\r\n111111100000000000000xxxx\r\n111111100000000000000xxxx\r\n111111100000000000000xxxx\r\nxxxx11100000000000000xxxx\r\nx1xx11100000000000000xxxx\r\nx1xx11100000000000000xxxx\r\nx1xx111000000000000000000\r\nx1xx111000000000000000000\r\nxxxx111000000000000000000\r\nxxxx11100000000000000xxxx\r\nxxxx1110000000xx11111xxxx\r\nxxxxx111110000x111111xxxx\r\nxxxxxx111100001111111xxxx\r\nxxxxxx111100001111111xxxx\r\nxxxxxx111100001111111xxxx\r\nxxxxxx111100001111111xxxx\r\nxxxxxx111100001111111xxxx\r\nxxxxxx111100001111111xxxx\r\nxxxxx1111100001111111xxxx",
                DoorX = 22,
                DoorY = 12,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "RRHi06shift1RAHIPAHj07shift2SAHIPAHm110mRBIIHHl113lQCIIHHk116kPDIIHHk119kSDIIHHh35kukat6QAKIHHg36kukat5RAKIHHc312kukat2PCKIHHb313kukat1QCKIHHc319kukat2SDKIHHb320kukat1PEKIHHi412shift1PCPAHPAHj413shift2QCPAHPAHi419shift1SDPAHPAHj420shift2PEPAHPAHi50shift1HQAIPAHj51shift2IQAIPAHi52shift1JQAIPAHj53shift2KQAIPAHk715kSCSAHJHo716table2PDSAHRAHz717tablecornerQDSAHHHm718mRDSAHRAHl815lSCPBHJHo816table2PDPBHPAHl818lRDPBHRAHm94mPAQBIRAHk99kQBQBHJHp910table3RBQBHRAHz911tablecornerSBQBHHHm912mPCQBHRAHk915kSCQBHJHo916table2PDQBHJHk918kRDQBHRAHk104kPARBIRAHm109mQBRBHJHp1010table3RBRBHPAHm1012mPCRBHRAHm1015mSCRBHJHo1016table2PDRBHHHk1018kRDRBHRAHl114lPASBIRAHl119lQBSBHJHp1110table3RBSBHJHl1112lPCSBHRAHk124kPAPCIRAHl129lQBPCHJHp1210table3RBPCHHHk1212kPCPCHRAHm134mPAQCIRAHc165kukat2QAPDIHHb166kukat1RAPDIHHc167kukat2SAPDIHHb168kukat1PBPDIHHe169kukat3QBPDIHHd1615kukka2SCPDIHHf179kukat4QBQDIHHk186kRARDIRAHe189kukat3QBRDIHHs1820sofabig3PERDIRAHf199kukat4QBSDIHHn1917table1QDSDIPAHz1918tablecornerRDSDIHHr1920sofabig2PESDIRAHn2017table1QDPEIJHr2020sofabig2PEPEIRAHm216mRAQEIRAHn2117table1QDQEIHHq2120sofabig1PEQEIRAHv2316sofalittle3PDSEIHHu2317sofalittle2QDSEIHHt2318sofalittle1RDSEIHHa2320kukkaPESEIH"
            },
            new RoomLayout
            {
                Name = "rooftop_2",
                Heightmap =
                    "x0000x000\r\nxxxxxx000\r\n000000000\r\n000000000\r\n000000000\r\n000000000\r\n000000000\r\n000000000\r\n000000000\r\n000000000\r\nxxx000xxx\r\nxxx000xxx",
                DoorX = 4,
                DoorY = 9,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "RDHk08rooftop_bigchairPBHHPAHl18rooftop_bigtablePBIHHHj20rooftop_sofabHJHPAHi21rooftop_sofaIJHPAHk28rooftop_bigchairPBJHHHk38rooftop_bigchairPBKHPAHl48rooftop_bigtablePBPAHHHj50rooftop_sofabHQAHHHi51rooftop_sofaIQAHHHk58rooftop_bigchairPBQAHHHj60rooftop_sofabHRAHPAHi61rooftop_sofaIRAHPAHj67rooftop_sofabSARAHPAHi68rooftop_sofaPBRAHPAHj90rooftop_sofabHQBHHHi91rooftop_sofaIQBHHHj97rooftop_sofabSAQBHHHi98rooftop_sofaPBQBHH"
            },
            new RoomLayout
            {
                Name = "star_lounge",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx2222x4444442222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222x444x32222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222xx4xx22222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx222222222222222xxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222222222222211111xxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222222222222222111xxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxx22222222222222222111xxxxxxxxx\r\nxxxxxxxxxxxxxxxx3333x22222222222222xxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxx3333x22222222222222xxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxx3333x22222222221111xxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxx3333xx2x22222220000xxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxx333333332222222000000xxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxx333333332222222x0000000xxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxx33333332222222x0000000xxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxx222222000000xxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 37,
                DoorY = 36,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "PXHk1521star_tableQESCJHHa1522star_sofaRESCJPAHb1523star_sofa2SESCJPAHz1524palmPFSCJHHb1621star_sofa2QEPDJJHQ1632dj1PHPDJHHW1633dj2QHPDJHHE1634dj3RHPDJHHa1721star_sofaQEQDJJHm1728star_microphonePGQDPAHHb1821star_sofa2QERDJJHa1835star_sofaSHRDJRAHa1921star_sofaQESDJJHb1935star_sofa2SHSDJRAHb2021star_sofa2QEPEJJHb2024star_sofa2PFPEJJHa2032star_sofaPHPEJRAHa2035star_sofaSHPEJRAHa2121star_sofaQEQEJJHa2124star_sofaPFQEJJHb2132star_sofa2PHQEJRAHb2135star_sofa2SHQEJRAHc2221star_sofachairQEREJJHk2224star_tablePFREJHHb2225star_sofa2QFREJHHa2226star_sofaRFREJHHb2230star_sofa2RGREJHHa2231star_sofaSGREJHHk2232star_tablePHREJHHk2235star_tableSHREJHHz2321palmQESEJHHa2335star_sofaSHSEJRAHp2422bar10REPFJHHb2435star_sofa2SHPFJRAHa2437star_sofaQIPFIPAHb2438star_sofa2RIPFIPAHa2439star_sofaSIPFIPAHb2440star_sofa2PJPFIPAHo2522bar9REQFJHHb2525star_sofa2QFQFJHHa2526star_sofaRFQFJHHb2530star_sofa2RGQFJHHa2531star_sofaSGQFJHHa2535star_sofaSHQFJRAHb2536star_sofa2PIQFIJHi2622bar8RERFJHHX2625palm1QFRFJHHV2626palm3RFRFJHHC2630palm2RGRFJHHB2631palm4SGRFJHHb2635star_sofa2SHRFJRAHa2636star_sofaPIRFIJHk2639star_tableSIRFIHHk2640star_tablePJRFIHHu2722bar7RESFJHHa2725star_sofaQFSFJPAHb2726star_sofa2RFSFJPAHa2730star_sofaRGSFJPAHb2731star_sofa2SGSFJPAHk2735star_tableSHSFJHHz2736palmPISFIHHk2737star_tableQISFIHHy2822bar6REPGJHHt2922bar5REQGJHHk2925star_tableQFQGJHHk2926star_tableRFQGJHHk3016star_tablePDRGKHHr3022bar4RERGJHHb3116star_sofa2PDSGKJHe3122bar3RESGJHHb3125star_sofa2QFSGJHHa3126star_sofaRFSGJHHa3130star_sofaRGSGJRAHa3216star_sofaPDPHKJHw3222bar2REPHJHHB3225palm4QFPHJHHX3226palm1RFPHJHHb3230star_sofa2RGPHJRAHb3316star_sofa2PDQHKJHq3322bar1REQHJHHa3325star_sofaQFQHJPAHb3326star_sofa2RFQHJPAHa3330star_sofaRGQHJRAHa3416star_sofaPDRHKJHb3430star_sofa2RGRHJRAHV3435palm3SHRHHHHC3436palm2PIRHHHHk3516star_tablePDSHKHHa3530star_sofaRGSHJRAHb3630star_sofa2RGPIJRAHc3725star_sofachairQFQIJHHb3726star_sofa2RFQIJHHa3727star_sofaSFQIJHHb3728star_sofa2PGQIJHHa3729star_sofaQGQIJHHk3730star_tableRGQIJH"
            },
            new RoomLayout
            {
                Name = "tearoom",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxx3333x33333333x\r\n333333xx3333x33333333x\r\n3333333x3333x33333333x\r\n3333333x3333x33333333x\r\n3333333xxxxxx33333333x\r\n333333333333333333333x\r\n333333333333333333333x\r\n333333333333333333333x\r\n333333333333333333333x\r\n33333333222x333333333x\r\n33333333222x333333333x\r\n33333333222x333333333x\r\n33333333222x333333333x\r\n33333333111x333333333x\r\n33333333111x333333333x\r\n33333333111x333333333x\r\nxxxxxxxx111xxxxxxxxxxx\r\n11111111111111111111xx\r\n1111111111111111111111\r\n1111111111111111111111\r\n11111111111111111111xx",
                DoorX = 21,
                DoorY = 19,
                DoorDirection = 6,
                RequiresClubMembership = false,
                ExtraData =
                    "QIHh113hardwoodsofa1QCIKPAHi114hardwoodsofa2RCIKPAHj115hardwoodsofa3SCIKPAHc116teabambooPDIKHHh118hardwoodsofa1RDIKPAHi119hardwoodsofa2SDIKPAHj120hardwoodsofa3PEIKPAHl313teasmalltable1QCKKHHk315teasmalltable2SCKKHHl318teasmalltable1RDKKHHk320teasmalltable2PEKKHHe62teastoolJRAKPAHe63teastoolKRAKPAHf68chinastoolredPBRAKPAHf69chinastoolredQBRAKPAHf610chinastoolredRBRAKPAHf611chinastoolredSBRAKPAHa82teatable1JPBKHHb83teatable2KPBKHHm92teastool2JQBKHHm93teastool2KQBKHHe916teastoolPDQBKPAHe917teastoolQDQBKPAHa1116teatable1PDSBKHHb1117teatable2QDSBKHHe122teastoolJPCKPAHe123teastoolKPCKPAHm1216teastool2PDPCKHHm1217teastool2QDPCKHHa142teatable1JRCKHHb143teatable2KRCKHHm152teastool2JSCKHHm153teastool2KSCKHHd180teavaseHRDIHHg190chinastoolgreenHSDIJHg200chinastoolgreenHPEIJHd210teavaseHQEIH"
            },
            new RoomLayout
            {
                Name = "rooftop",
                Heightmap =
                    "44xxxxxxxxxxxxxxxxxx\r\n444xxxxxxxxxxx444444\r\n4444xxxxxxxxxx444444\r\n44444xxxx4xxxx444444\r\n444444xxx44xxx444444\r\n44444444444444444444\r\n44444444444444444444\r\n44444444444444444444\r\n44444444xx44xx44xx44\r\n44444444xx44xx44xx44\r\n44444444444444444444\r\n44444444444444444444\r\n44444444444444444444\r\nx444444x444444xx4444\r\nx444444x444444xx333x\r\nx444444x444444xx222x\r\nx444444x444444xx11xx\r\nx444444x444444xxxxxx",
                DoorX = 17,
                DoorY = 12,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "PKHa10rooftop_minichairHIPAPAHd116rooftop_flatcurbPDIPAPAHe117rooftop_flatcurb2QDIPAPAHc20rooftop_rodtableHJPAHHa21rooftop_minichairIJPARAHa30rooftop_minichairHKPAHHd416rooftop_flatcurbPDPAPAHHe417rooftop_flatcurb2QDPAPAHHa62rooftop_minichairJRAPAPAHa71rooftop_minichairISAPAJHc72rooftop_rodtableJSAPAHHa73rooftop_minichairKSAPARAHa82rooftop_minichairJPBPAHHa90rooftop_minichairHQBPAPAHb100rooftop_emptytableHRBPAHHa110rooftop_minichairHSBPAHHd131rooftop_flatcurbIQCPAJHd136rooftop_flatcurbRAQCPARAHd138rooftop_flatcurbPBQCPAJHd1313rooftop_flatcurbQCQCPARAHf141rooftop_flatcurb3IRCPAJHf146rooftop_flatcurb3RARCPARAHf148rooftop_flatcurb3PBRCPAJHf1413rooftop_flatcurb3QCRCPARAHf151rooftop_flatcurb3ISCPAJHf156rooftop_flatcurb3RASCPARAHf158rooftop_flatcurb3PBSCPAJHf1513rooftop_flatcurb3QCSCPARAHf161rooftop_flatcurb3IPDPAJHf166rooftop_flatcurb3RAPDPARAHf168rooftop_flatcurb3PBPDPAJHf1613rooftop_flatcurb3QCPDPARAHg171rooftop_flatcurb4IQDPAHHf172rooftop_flatcurb3JQDPAHHf173rooftop_flatcurb3KQDPAHHf174rooftop_flatcurb3PAQDPAHHf175rooftop_flatcurb3QAQDPAHHh176rooftop_flatcurb5RAQDPAHHg178rooftop_flatcurb4PBQDPAHHf179rooftop_flatcurb3QBQDPAHHf1710rooftop_flatcurb3RBQDPAHHf1711rooftop_flatcurb3SBQDPAHHf1712rooftop_flatcurb3PCQDPAHHh1713rooftop_flatcurb5QCQDPAH"
            },
            new RoomLayout
            {
                Name = "pub_a",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxxxxxxxx\r\nxxxxxxxxx2222222211111xxx\r\nxxxxxxxxx2222222211111xxx\r\nxxxxxxxxx2222222211111xxx\r\nxxxxxxxxx2222222211111xxx\r\nxxxxxxxxx2222222222111xxx\r\nxxxxxxxxx2222222222111xxx\r\nxxxxxxxxx2222222222000xxx\r\nxxxxxxxxx2222222222000xxx\r\nxxxxxxxxx2222222222000xxx\r\nxxxxxxxxx2222222222000xxx\r\nx333333332222222222000xxx\r\nx333333332222222222000xxx\r\nx333333332222222222000xxx\r\nx333333332222222222000xxx\r\nx333333332222222222000xxx\r\nx333332222222222222000xxx\r\nx333332222222222222000xxx\r\nx333332222222222222000xxx\r\nx333332222222222222000xxx\r\nx333333332222222222000xxx\r\nxxxxx31111112222222000xxx\r\nxxxxx31111111000000000xxx\r\nxxxxx31111111000000000xxx\r\nxxxxx31111111000000000xxx\r\nxxxxx31111111000000000xxx\r\nxxxxxxxxxxxxxxx00xxxxxxxx\r\nxxxxxxxxxxxxxxx00xxxxxxxx\r\nxxxxxxxxxxxxxxx00xxxxxxxx\r\nxxxxxxxxxxxxxxx00xxxxxxxx\r\nxxxxxxxxxxxxxxxxxxxxxxxxx",
                DoorX = 15,
                DoorY = 25,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "SWHS119pub_sofa2SDIIPAHs120pub_sofaPEIIPAHs121pub_sofaQEIIPAHq211bardesk1SBJJHHc212pub_chairPCJJRAHQ311bardesk2SBKJHHq411bardesk1SBPAJHHc412pub_chairPCPAJRAHQ511bardesk2SBQAJHHf518pub_fenceRDQAJIHq611bardesk1SBRAJHHc612pub_chairPCRAJRAHf618pub_fenceRDRAJHHQ711bardesk2SBSAJHHf718pub_fenceRDSAJHHq811bardesk1SBPBJHHc812pub_chairPCPBJRAHf818pub_fenceRDPBJHHw910bardesk4RBQBJHHW911bardesk3SBQBJHHf918pub_fenceRDQBJHHf1018pub_fenceRDRBJHHC112pub_chair2JSBKPAHC113pub_chair2KSBKPAHC115pub_chair2QASBKPAHC116pub_chair2RASBKPAHf118pub_fencePBSBKIHf1118pub_fenceRDSBJHHf128pub_fencePBPCKHHf1218pub_fenceRDPCJHHf138pub_fencePBQCKHHC139pub_chair2QBQCJJHk1314pub_chair3RCQCJJHT1315pub_table2SCQCJIHk1316pub_chair3PDQCJRAHf1318pub_fenceRDQCJHHf148pub_fencePBRCKJHC149pub_chair2QBRCJJHk1414pub_chair3RCRCJJHT1415pub_table2SCRCJJHk1416pub_chair3PDRCJRAHf1418pub_fenceRDRCJHHt151pub_tableISCKHHf155pub_fenceQASCKIHf1518pub_fenceRDSCJHHS161pub_sofa2IPDKJHf165pub_fenceQAPDKHHf1618pub_fenceRDPDJHHs171pub_sofaIQDKJHf175pub_fenceQAQDKHHk1713pub_chair3QCQDJPAHk1714pub_chair3RCQDJPAHk1715pub_chair3SCQDJPAHk1716pub_chair3PDQDJPAHf1718pub_fenceRDQDJHHs181pub_sofaIRDKJHf185pub_fenceQARDKHHT1813pub_table2QCRDJQAHT1814pub_table2RCRDJRAHT1815pub_table2SCRDJRAHT1816pub_table2PDRDJPAHf1818pub_fenceRDRDJHHs192pub_sofaJSDKHHS193pub_sofa2KSDKHHf195pub_fenceQASDKHHk1913pub_chair3QCSDJHHk1914pub_chair3RCSDJHHk1915pub_chair3SCSDJHHk1916pub_chair3PDSDJHHf1918pub_fenceRDSDJHHf201pub_fenceIPEKQAHf202pub_fenceJPEKRAHf203pub_fenceKPEKRAHf204pub_fencePAPEKRAHf205pub_fenceQAPEKKHf2018pub_fenceRDPEJHHS217pub_sofa2SAQEIPAHs218pub_sofaPBQEIPAHf2112pub_fencePCQEJQAHf2113pub_fenceQCQEJRAHf2114pub_fenceRCQEJRAHf2115pub_fenceSCQEJRAHf2116pub_fencePDQEJRAHf2117pub_fenceQDQEJRAHf2118pub_fenceRDQEJKHS226pub_sofa2RAREIJHt2215pub_tableSCREHHHC2216pub_chair2PDREHPAHC2217pub_chair2QDREHPAHs236pub_sofaRASEIJHT238pub_table2PBSEIIHs246pub_sofaRAPFIJHT248pub_table2PBPFIHHs256pub_sofaRAQFIJHT258pub_table2PBQFIJ"
            },
            new RoomLayout
            {
                Name = "newbie_lobby",
                Heightmap =
                    "xxxxxxxxxxxxxxxx000000\r\nxxxxx0xxxxxxxxxx000000\r\nxxxxx00000000xxx000000\r\nxxxxx000000000xx000000\r\n0000000000000000000000\r\n0000000000000000000000\r\n0000000000000000000000\r\n0000000000000000000000\r\n0000000000000000000000\r\nxxxxx000000000000000xx\r\nxxxxx000000000000000xx\r\nx0000000000000000000xx\r\nx0000000000000000xxxxx\r\nxxxxxx00000000000xxxxx\r\nxxxxxxx0000000000xxxxx\r\nxxxxxxxx000000000xxxxx\r\nxxxxxxxx000000000xxxxx\r\nxxxxxxxx000000000xxxxx\r\nxxxxxxxx000000000xxxxx\r\nxxxxxxxx000000000xxxxx\r\nxxxxxxxx000000000xxxxx\r\nxxxxxx00000000000xxxxx\r\nxxxxxx00000000000xxxxx\r\nxxxxxx00000000000xxxxx\r\nxxxxxx00000000000xxxxx\r\nxxxxxx00000000000xxxxx\r\nxxxxx000000000000xxxxx\r\nxxxxx000000000000xxxxx",
                DoorX = 2,
                DoorY = 11,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "SOHa016crl_lampPDHHHHy017crl_sofa2cQDHHPAHw018crl_sofa2bRDHHPAHv019crl_sofa2aSDHHPAHa020crl_lampPEHHHHb116crl_chairPDIHJHa27crl_lampSAJHHHa211crl_lampSBJHHHb216crl_chairPDJHJHc35crl_pillarQAKHHHb37crl_chairSAKHJHu39crl_table1bQBKHHHs311crl_sofa1cSBKHRAHb316crl_chairPDKHJHA319crl_table2bSDKHHHz320crl_table2aPEKHHHa40crl_lampHPAHHHy41crl_sofa2cIPAHPAHw42crl_sofa2bJPAHPAHv43crl_sofa2aKPAHPAHa44crl_lampPAPAHHHt49crl_table1aQBPAHHHr411crl_sofa1bSBPAHRAHh415crl_wall2aSCPAHHHa416crl_lampPDPAHHHb50crl_chairHQAHJHb57crl_chairSAQAHJHq511crl_sofa1aSBQAHRAHA62crl_table2bJRAHHHz63crl_table2aKRAHHHa611crl_lampSBRAHHHb70crl_chairHSAHJHa80crl_lampHPBHHHD81crl_sofa3cIPBHHHC82crl_sofa3bJPBHHHB83crl_sofa3aKPBHHHa84crl_lampPAPBHHHo819crl_barchair2SDPBHHHp820crl_tablebarPEPBHHHo821crl_barchair2QEPBHHHE95crl_pillar2QAQBHHHc99crl_pillarQBQBHHHP158crl_desk1aPBSCHHHO159crl_deskiQBSCHHHN1510crl_deskhRBSCHHHM1610crl_deskgRBPDHHHL1710crl_deskfRBQDHHHK1810crl_deskeRBRDHHHK1910crl_deskeRBSDHHHK2010crl_deskeRBPEHHHK2110crl_deskeRBQEHHHK2210crl_deskeRBREHHHK2310crl_deskeRBSEHHHG247crl_wallbSAPFHHHK2410crl_deskeRBPFHHHF257crl_wallaSAQFHHHH258crl_desk1bPBQFHHHI259crl_desk1cQBQFHHHJ2510crl_desk1dRBQFHHHd2712crl_lamp2PCSFHHHf2713crl_cabinet2QCSFHHHe2714crl_cabinet1RCSFHHHd2715crl_lamp2SCSFHH"
            },
            new RoomLayout
            {
                Name = "pizza",
                Heightmap =
                    "xxxxxxxxx0000000\r\nx11111x1xx000000\r\n11xxxxx111x00000\r\n11x1111111xx0000\r\n11x1111111100000\r\nxxx1111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n1111111111100000\r\n11111111111xxxxx\r\n1111111111xxxxxx\r\n1111111111111111\r\n1111111111111111\r\n1111111111111111\r\n1111111111111111\r\n1111111111111111\r\n1111111111111111\r\n11xx11xx11111111\r\nxxxx11xxxxxxxxxx\r\nxxxx11xxxxxxxxxx",
                DoorX = 5,
                DoorY = 27,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "QGHa015pizza_plant1SCHHJHe314pizza_sofa1RCKHPAHE315pizza_sofa2SCKHPAHc515pizza_tableSCQAHJHb60pizza_plant2HRAIJHf614pizza_sofa3RCRAHHHF615pizza_sofa4SCRAHHHd81pizza_chairIPBIPAHd82pizza_chairJPBIPAHc102pizza_tableJRBIJHe1014pizza_sofa1RCRBHPAHE1015pizza_sofa2SCRBHPAHd111pizza_chairISBIHHd112pizza_chairJSBIHHc1215pizza_tableSCPCHJHf1314pizza_sofa3RCQCHHHF1315pizza_sofa4SCQCHHHd161pizza_chairIPDIPAHd162pizza_chairJPDIPAHc182pizza_tableJRDIJHd191pizza_chairISDIHHd192pizza_chairJSDIHHd2111pizza_chairSBQEIJHd2114pizza_chairRCQEIRAHd2211pizza_chairSBREIJHc2213pizza_tableQCREIHHd2214pizza_chairRCREIRAHa250pizza_plant1HQFIJHa2515pizza_plant1SCQFIJ"
            },
            new RoomLayout
            {
                Name = "old_skool",
                Heightmap =
                    "xx0xxxxxxxxxxxxxx\r\n0000000xxx00000xx\r\n0000000x0000000xx\r\n0000000xxxxxxxxxx\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n00000000000000000\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x\r\n0000000000000000x",
                DoorX = 2,
                DoorY = 1,
                DoorDirection = 2,
                RequiresClubMembership = false,
                ExtraData =
                    "SLHk49mobiles_chair3QBPAHHHk410mobiles_chair3RBPAHHHk411mobiles_chair3SBPAHHHk412mobiles_chair3PCPAHHHe101mobiles_chair1IRBHPAHe1010mobiles_chair1RBRBHPAHe110mobiles_chair1HSBHJHb111mobiles_table2ISBHHHc112mobiles_table3JSBHHHe113mobiles_chair1KSBHRAHb1110mobiles_table2RBSBHHHc1111mobiles_table3SBSBHHHa121mobiles_table1IPCHHHd122mobiles_table4JPCHHHe129mobiles_chair1QBPCHJHa1210mobiles_table1RBPCHHHd1211mobiles_table4SBPCHHHe1212mobiles_chair1PCPCHRAHe131mobiles_chair1IQCHHHe1311mobiles_chair1SBQCHHHe150mobiles_chair1HSCHPAHe170mobiles_chair1HQDHJHb171mobiles_table2IQDHHHc172mobiles_table3JQDHHHe173mobiles_chair1KQDHRAHa181mobiles_table1IRDHHHd182mobiles_table4JRDHHHe192mobiles_chair1JSDHHHe211mobiles_chair1IQEHPAHb216mobiles_table2RAQEHHHc217mobiles_table3SAQEHHHe2112mobiles_chair1PCQEHPAHe220mobiles_chair1HREHJHb221mobiles_table2IREHHHc222mobiles_table3JREHHHe223mobiles_chair1KREHRAHe225mobiles_chair1QAREHJHa226mobiles_table1RAREHHHd227mobiles_table4SAREHHHe228mobiles_chair1PBREHRAHe2211mobiles_chair1SBREHJHb2212mobiles_table2PCREHHHc2213mobiles_table3QCREHHHe2214mobiles_chair1RCREHRAHa231mobiles_table1ISEHHHd232mobiles_table4JSEHHHa2312mobiles_table1PCSEHHHd2313mobiles_table4QCSEHHHe241mobiles_chair1IPFHHHe247mobiles_chair1SAPFHPAHe2413mobiles_chair1QCPFHH"
            },
            new RoomLayout
            {
                Name = "model_h",
                Heightmap =
                    "xxxxxxxxxxxx\r\nxxxxxxxxxxxx\r\nxxxxx111111x\r\nxxxxx111111x\r\nxxxx1111111x\r\nxxxxx111111x\r\nxxxxx111111x\r\nxxxxx000000x\r\nxxxxx000000x\r\nxxx00000000x\r\nxxx00000000x\r\nxxx00000000x\r\nxxx00000000x\r\nxxxxxxxxxxxx\r\nxxxxxxxxxxxx\r\nxxxxxxxxxxxx",
                DoorX = 4,
                DoorY = 4,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            },
            new RoomLayout
            {
                Name = "model_p",
                Heightmap =
                    "xxxxxxxxxxxxxxxxxxx\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx222222222222\r\nxxxxxxx22222222xxxx\r\nxxxxxxx11111111xxxx\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx222221111111111111\r\nx2222xx11111111xxxx\r\nx2222xx00000000xxxx\r\nx2222xx000000000000\r\nx2222xx000000000000\r\nx2222xx000000000000\r\nx2222xx000000000000\r\n22222xx000000000000\r\nx2222xx000000000000\r\nxxxxxxxxxxxxxxxxxxx",
                DoorX = 0,
                DoorY = 23,
                DoorDirection = 2,
                RequiresClubMembership = true,
                ExtraData = ""
            }
        );
    }

    public static void SeedHandItems(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HandItem>().HasData(
            new HandItem { Id = 1, Name = "Tea" },
            new HandItem { Id = 2, Name = "Juice" },
            new HandItem { Id = 3, Name = "Carrot" },
            new HandItem { Id = 4, Name = "Ice Cream" },
            new HandItem { Id = 5, Name = "Milk" },
            new HandItem { Id = 6, Name = "Black Currant" },
            new HandItem { Id = 7, Name = "Water" },
            new HandItem { Id = 8, Name = "Coffee" },
            new HandItem { Id = 9, Name = "Decaff" },
            new HandItem { Id = 10, Name = "Tea" },
            new HandItem { Id = 11, Name = "Mocha" },
            new HandItem { Id = 12, Name = "Macchiato" },
            new HandItem { Id = 13, Name = "Espresso" },
            new HandItem { Id = 14, Name = "Black Coffee" },
            new HandItem { Id = 15, Name = "Hot Chocolate" },
            new HandItem { Id = 16, Name = "Cappuccino" },
            new HandItem { Id = 17, Name = "Java" },
            new HandItem { Id = 18, Name = "Tap Water" },
            new HandItem { Id = 19, Name = "Habbo Cola" },
            new HandItem { Id = 20, Name = "Camera Unused" },
            new HandItem { Id = 21, Name = "Hamburger No Sprite" },
            new HandItem { Id = 22, Name = "Lime Habbo Soda No Sprite" },
            new HandItem { Id = 23, Name = "Beetroot Habbo Soda No Sprite" },
            new HandItem { Id = 24, Name = "Bubble juice from 1978" },
            new HandItem { Id = 25, Name = "Love potion" },
            new HandItem { Id = 26, Name = "Calippo Unused" },
            new HandItem { Id = 27, Name = "Tea" },
            new HandItem { Id = 28, Name = "Sake" },
            new HandItem { Id = 29, Name = "Tomato juice" },
            new HandItem { Id = 30, Name = "Radioactive liquid" },
            new HandItem { Id = 31, Name = "Pink Champagne" },
            new HandItem { Id = 32, Name = "Coconut Delight" },
            new HandItem { Id = 33, Name = "Unnamed Unused" },
            new HandItem { Id = 34, Name = "Fish" },
            new HandItem { Id = 35, Name = "Pink Champagne" },
            new HandItem { Id = 36, Name = "Pear" },
            new HandItem { Id = 37, Name = "Yummy peach" },
            new HandItem { Id = 38, Name = "Orange" },
            new HandItem { Id = 39, Name = "Cheese slice" },
            new HandItem { Id = 40, Name = "Fizzy Orange" },
            new HandItem { Id = 41, Name = "Sumppi-kuppi" },
            new HandItem { Id = 42, Name = "Orange juice" },
            new HandItem { Id = 43, Name = "Chilled Soda" },
            new HandItem { Id = 44, Name = "Unnamed" },
            new HandItem { Id = 45, Name = "Unnamed" },
            new HandItem { Id = 46, Name = "Unnamed" },
            new HandItem { Id = 47, Name = "Moodi" },
            new HandItem { Id = 48, Name = "Lolly Pop" },
            new HandItem { Id = 49, Name = "Unnamed" },
            new HandItem { Id = 50, Name = "Bubble Juice Bottle" },
            new HandItem { Id = 51, Name = "Unnamed" },
            new HandItem { Id = 52, Name = "Unnamed" },
            new HandItem { Id = 53, Name = "Espresso" },
            new HandItem { Id = 54, Name = "Cereal Bowl" },
            new HandItem { Id = 55, Name = "Unnamed" },
            new HandItem { Id = 56, Name = "Unnamed" },
            new HandItem { Id = 57, Name = "Cherry Crush Soda" },
            new HandItem { Id = 58, Name = "Cup of blood" },
            new HandItem { Id = 59, Name = "Unnamed" },
            new HandItem { Id = 60, Name = "Chestnuts" },
            new HandItem { Id = 61, Name = "Unnamed" },
            new HandItem { Id = 62, Name = "Skull Cup of Water" },
            new HandItem { Id = 63, Name = "Pop Corn" },
            new HandItem { Id = 64, Name = "Unnamed" },
            new HandItem { Id = 65, Name = "Unnamed Unused" },
            new HandItem { Id = 66, Name = "Banana Smoothie" },
            new HandItem { Id = 67, Name = "Unnamed" },
            new HandItem { Id = 68, Name = "Unnamed" },
            new HandItem { Id = 69, Name = "Unnamed" },
            new HandItem { Id = 70, Name = "Chicken leg" },
            new HandItem { Id = 71, Name = "Toast" },
            new HandItem { Id = 72, Name = "Unnamed" },
            new HandItem { Id = 73, Name = "Egg Nog" },
            new HandItem { Id = 74, Name = "Toasting Goblet" },
            new HandItem { Id = 75, Name = "Strawberry Ice Cream" },
            new HandItem { Id = 76, Name = "Mint Ice cream" },
            new HandItem { Id = 77, Name = "Chocolate Ice Cream" },
            new HandItem { Id = 78, Name = "Unnamed Unused" },
            new HandItem { Id = 79, Name = "Pink Candy Floss" },
            new HandItem { Id = 80, Name = "Blue Candy Floss" },
            new HandItem { Id = 81, Name = "Hot Dog" },
            new HandItem { Id = 82, Name = "Unnamed" },
            new HandItem { Id = 83, Name = "Juicy Apple" },
            new HandItem { Id = 84, Name = "Ginger Bread Man" },
            new HandItem { Id = 85, Name = "Americano" },
            new HandItem { Id = 86, Name = "Frappuccino" },
            new HandItem { Id = 87, Name = "Unnamed" },
            new HandItem { Id = 88, Name = "Unnamed" },
            new HandItem { Id = 89, Name = "Cupcake" },
            new HandItem { Id = 90, Name = "Unnamed" },
            new HandItem { Id = 91, Name = "Unnamed" },
            new HandItem { Id = 92, Name = "blue bubblegum" },
            new HandItem { Id = 93, Name = "red bubblegum" },
            new HandItem { Id = 94, Name = "pink bubblegum" },
            new HandItem { Id = 95, Name = "Unnamed" },
            new HandItem { Id = 96, Name = "Cake Slice" },
            new HandItem { Id = 97, Name = "Croissant" },
            new HandItem { Id = 98, Name = "Tomato" },
            new HandItem { Id = 99, Name = "Aubergine" },
            new HandItem { Id = 100, Name = "Cabbage" },
            new HandItem { Id = 101, Name = "Sparklying Bubble Juice" },
            new HandItem { Id = 102, Name = "Energy Drink" },
            new HandItem { Id = 103, Name = "Banana!" },
            new HandItem { Id = 104, Name = "Avocado" },
            new HandItem { Id = 105, Name = "Grapes" },
            new HandItem { Id = 106, Name = "Smoothie" },
            new HandItem { Id = 107, Name = "Vegetables Juice" },
            new HandItem { Id = 108, Name = "Handitem108" },
            new HandItem { Id = 109, Name = "Burger" },
            new HandItem { Id = 110, Name = "Unnamed" },
            new HandItem { Id = 111, Name = "crab" },
            new HandItem { Id = 112, Name = "Red Chilli" },
            new HandItem { Id = 113, Name = "Citrus Smoothie" },
            new HandItem { Id = 114, Name = "Green Smoothie" },
            new HandItem { Id = 115, Name = "Berry Smoothie" },
            new HandItem { Id = 116, Name = "Lemon" },
            new HandItem { Id = 117, Name = "Cookie" },
            new HandItem { Id = 118, Name = "Pink Ramune" },
            new HandItem { Id = 119, Name = "Blue Ramune" },
            new HandItem { Id = 120, Name = "Blueberry Shaved Ice" },
            new HandItem { Id = 121, Name = "Strawberry Shaved Ice" },
            new HandItem { Id = 122, Name = "Takoyaki" },
            new HandItem { Id = 123, Name = "Unnamed" },
            new HandItem { Id = 124, Name = "Unnamed" },
            new HandItem { Id = 125, Name = "Unnamed" },
            new HandItem { Id = 126, Name = "Unnamed" },
            new HandItem { Id = 127, Name = "Ice Cream Cone" },
            new HandItem { Id = 128, Name = "Charcoal Ice Cream" },
            new HandItem { Id = 129, Name = "Yoghurt" },
            new HandItem { Id = 130, Name = "Cheese" },
            new HandItem { Id = 131, Name = "Bread" },
            new HandItem { Id = 132, Name = "Shrimp" },
            new HandItem { Id = 133, Name = "Broccoli" },
            new HandItem { Id = 134, Name = "Watermelon" },
            new HandItem { Id = 135, Name = "Donut" },
            new HandItem { Id = 136, Name = "Sausages" },
            new HandItem { Id = 137, Name = "Popsicle" },
            new HandItem { Id = 138, Name = "An Open Bag of Chips" },
            new HandItem { Id = 139, Name = "Unnamed Unused" },
            new HandItem { Id = 140, Name = "Unnamed Unused" },
            new HandItem { Id = 141, Name = "Luminescent Easter Egg Unused" },
            new HandItem { Id = 142, Name = "Ice Drink" },
            new HandItem { Id = 143, Name = "Chocolate-covered marshmallows on a stick" },
            new HandItem { Id = 144, Name = "Chocolate-covered strawberry on a stick" },
            new HandItem { Id = 145, Name = "Unnamed Unused" },
            new HandItem { Id = 146, Name = "Fancy Coffee" },
            new HandItem { Id = 147, Name = "Handitem147" },
            new HandItem { Id = 148, Name = "Magnifying Glass" },
            new HandItem { Id = 149, Name = "Unnamed" },
            new HandItem { Id = 1000, Name = "rose" },
            new HandItem { Id = 1001, Name = "black rose" },
            new HandItem { Id = 1002, Name = "sun flower" },
            new HandItem { Id = 1003, Name = "Little Rad Book by Kitano" },
            new HandItem { Id = 1004, Name = "Wise Words by A. Person" },
            new HandItem { Id = 1005, Name = "Flying Turtles by Perry Tratchett" },
            new HandItem { Id = 1006, Name = "gift flower" },
            new HandItem { Id = 1007, Name = "jimson weed" },
            new HandItem { Id = 1008, Name = "yellow delight" },
            new HandItem { Id = 1009, Name = "pink pandemic" },
            new HandItem { Id = 1010, Name = "Unnamed Unused" },
            new HandItem { Id = 1011, Name = "clip board" },
            new HandItem { Id = 1013, Name = "painkiller" },
            new HandItem { Id = 1014, Name = "syringe" },
            new HandItem { Id = 1015, Name = "biohazard bag" },
            new HandItem { Id = 1016, Name = "Unnamed Unused" },
            new HandItem { Id = 1017, Name = "Unnamed Unused" },
            new HandItem { Id = 1018, Name = "Unnamed Unused" },
            new HandItem { Id = 1019, Name = "bolly flower" },
            new HandItem { Id = 1020, Name = "Unnamed Unused" },
            new HandItem { Id = 1021, Name = "hyacinth1" },
            new HandItem { Id = 1022, Name = "hyacinth2" },
            new HandItem { Id = 1023, Name = "Poinsettia" },
            new HandItem { Id = 1024, Name = "pudding" },
            new HandItem { Id = 1025, Name = "candy cane" },
            new HandItem { Id = 1026, Name = "present" },
            new HandItem { Id = 1027, Name = "candle" },
            new HandItem { Id = 1028, Name = "Cereal Bowl" },
            new HandItem { Id = 1029, Name = "Balloon" },
            new HandItem { Id = 1030, Name = "HiPad" },
            new HandItem { Id = 1031, Name = "Habbo-lympix Torch" },
            new HandItem { Id = 1032, Name = "Major Tom" },
            new HandItem { Id = 1033, Name = "UFO" },
            new HandItem { Id = 1034, Name = "Alien thing" },
            new HandItem { Id = 1035, Name = "Wrench" },
            new HandItem { Id = 1036, Name = "Gummy duck" },
            new HandItem { Id = 1037, Name = "Snake" },
            new HandItem { Id = 1038, Name = "Stick" },
            new HandItem { Id = 1039, Name = "Severed hand" },
            new HandItem { Id = 1040, Name = "Heart" },
            new HandItem { Id = 1041, Name = "Squid" },
            new HandItem { Id = 1042, Name = "Bat Excrement" },
            new HandItem { Id = 1043, Name = "Magot" },
            new HandItem { Id = 1044, Name = "Dead Rat" },
            new HandItem { Id = 1045, Name = "Dentures" },
            new HandItem { Id = 1046, Name = "Clearasil Cream" },
            new HandItem { Id = 1047, Name = "Unnamed" },
            new HandItem { Id = 1048, Name = "Ditch the Label Flag" },
            new HandItem { Id = 1049, Name = "Hammer" },
            new HandItem { Id = 1050, Name = "Handitem1050" },
            new HandItem { Id = 1051, Name = "Paint Brush" },
            new HandItem { Id = 1052, Name = "Ditch the Label Flag" },
            new HandItem { Id = 1053, Name = "Duck" },
            new HandItem { Id = 1054, Name = "Orange Balloon" },
            new HandItem { Id = 1055, Name = "Green Balloon" },
            new HandItem { Id = 1056, Name = "Blue Balloon" },
            new HandItem { Id = 1057, Name = "Pink Balloon" },
            new HandItem { Id = 1058, Name = "Unnamed" },
            new HandItem { Id = 1059, Name = "Unnamed" },
            new HandItem { Id = 1060, Name = "Spray" },
            new HandItem { Id = 1061, Name = "Unnamed" },
            new HandItem { Id = 1062, Name = "Pink Candy Skull" },
            new HandItem { Id = 1063, Name = "Green Candy Skull" },
            new HandItem { Id = 1064, Name = "Blue Candy Skull" },
            new HandItem { Id = 1065, Name = "Doll Toy" },
            new HandItem { Id = 1066, Name = "Teddy Toy" },
            new HandItem { Id = 1067, Name = "Soldier Toy" },
            new HandItem { Id = 1068, Name = "Manga" },
            new HandItem { Id = 1069, Name = "Comic" },
            new HandItem { Id = 1070, Name = "Yellow Book" },
            new HandItem { Id = 1071, Name = "Unnamed" },
            new HandItem { Id = 1072, Name = "Compass" },
            new HandItem { Id = 1073, Name = "Dino Egg" },
            new HandItem { Id = 1074, Name = "Green Allosaurus" },
            new HandItem { Id = 1075, Name = "Yellow Triceratops" },
            new HandItem { Id = 1076, Name = "Purple Saurolophus" },
            new HandItem { Id = 1077, Name = "Unnamed Unused" },
            new HandItem { Id = 1078, Name = "Unnamed" },
            new HandItem { Id = 1079, Name = "Stag Beetle" },
            new HandItem { Id = 1080, Name = "Rhino Beetle" },
            new HandItem { Id = 1081, Name = "Watering Can" },
            new HandItem { Id = 1082, Name = "Pride Flag" },
            new HandItem { Id = 1083, Name = "Spooky Pumpkin" },
            new HandItem { Id = 1084, Name = "Grocery Bag" },
            new HandItem { Id = 1085, Name = "Action DVD" },
            new HandItem { Id = 1086, Name = "Thriller DVD" },
            new HandItem { Id = 1087, Name = "Note Book" },
            new HandItem { Id = 1088, Name = "Pencil" },
            new HandItem { Id = 1089, Name = "A Closed Bag of Chips" },
            new HandItem { Id = 1090, Name = "Fishing Pole - Caught Fish" },
            new HandItem { Id = 1091, Name = "Fishing Pole - Caught boot" },
            new HandItem { Id = 1092, Name = "Fishing Pole - Caught message in a bottle" },
            new HandItem { Id = 1093, Name = "Ditch the Label Flag" },
            new HandItem { Id = 1094, Name = "Sword" },
            new HandItem { Id = 1095, Name = "Heart" },
            new HandItem { Id = 1096, Name = "Mobile phone" },
            new HandItem { Id = 1097, Name = "Unnamed" }
        );
    }

    public static void SeedCatalogClubOffers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatalogClubOffer>().HasData(
            new CatalogClubOffer
            {
                Id = 1,
                Name = "1 Month HC",
                DurationDays = 31,
                CostCredits = 250,
                CostPoints = 0,
                CostPointsType = 0,
                IsVip = true
            },
            new CatalogClubOffer
            {
                Id = 2,
                Name = "3 Month HC",
                DurationDays = 93,
                CostCredits = 600,
                CostPoints = 0,
                CostPointsType = 0,
                IsVip = true
            }
        );
    }

    public static void SeedSubscriptions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Subscription>().HasData(
            new Subscription
            {
                Id = 1,
                Name = "HABBO_CLUB"
            }
        );
    }

    public static void SeedServerSettings(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServerSettings>().HasData(
            new ServerSettings
            {
                PlayerWelcomeMessage = "Welcome (back) to Sadie [username], we're running version [version]!",
                FairCurrencyRewards = true
            }
        );
    }

    public static void SeedServerPlayerConstants(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServerPlayerConstants>().HasData(
            new ServerPlayerConstants
            {
                MaxMottoLength = 35,
                MinSsoLength = 8,
                MaxFriendships = 20000
            }
        );
    }

    public static void SeedServerRoomConstants(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServerRoomConstants>().HasData(
            new ServerRoomConstants
            {
                MaxChatMessageLength = 500,
                SecondsTillUserIdle = 300,
                MaxNameLength = 60,
                MaxDescriptionLength = 250,
                MaxTagLength = 30,
                WiredMaxFurnitureSelection = 5,
                CreatedAt = new DateTime(2025, 1, 1) // or whatever you prefer
            }
        );
    }

    public static void SeedNavigatorTabs(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NavigatorTab>().HasData(
            new NavigatorTab { Id = 1, Name = "query" },
            new NavigatorTab { Id = 2, Name = "official_view" },
            new NavigatorTab { Id = 3, Name = "hotel_view" },
            new NavigatorTab { Id = 4, Name = "myworld_view" },
            new NavigatorTab { Id = 5, Name = "roomads_view" }
        );
    }

    public static void SeedNavigatorCategories(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NavigatorCategory>().HasData(
            new NavigatorCategory
            {
                Id = 1,
                Name = "Most Popular Rooms",
                CodeName = "popular",
                TabId = 3,
                OrderId = 0
            },
            new NavigatorCategory
            {
                Id = 2,
                Name = "My Rooms",
                CodeName = "my_rooms",
                TabId = 4,
                OrderId = 0
            }
        );
    }

    public static void SeedPlayerRelationshipTypes(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlayerRelationshipType>().HasData(
            new PlayerRelationshipType { Id = 1, Name = "Lover" },
            new PlayerRelationshipType { Id = 2, Name = "Friend" },
            new PlayerRelationshipType { Id = 3, Name = "Enemey" }
        );
    }

    public static void SeedRolePermissions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RolePermission>().HasData(
            new RolePermission { RoleId = 6, PermissionId = 1 },
            new RolePermission { RoleId = 6, PermissionId = 2 },
            new RolePermission { RoleId = 6, PermissionId = 3 },
            new RolePermission { RoleId = 6, PermissionId = 4 },
            new RolePermission { RoleId = 6, PermissionId = 5 },
            new RolePermission { RoleId = 6, PermissionId = 6 },
            new RolePermission { RoleId = 6, PermissionId = 7 },
            new RolePermission { RoleId = 6, PermissionId = 8 },
            new RolePermission { RoleId = 6, PermissionId = 9 },
            new RolePermission { RoleId = 5, PermissionId = 1 },
            new RolePermission { RoleId = 5, PermissionId = 3 },
            new RolePermission { RoleId = 5, PermissionId = 4 },
            new RolePermission { RoleId = 5, PermissionId = 5 },
            new RolePermission { RoleId = 5, PermissionId = 6 },
            new RolePermission { RoleId = 5, PermissionId = 7 },
            new RolePermission { RoleId = 5, PermissionId = 8 },
            new RolePermission { RoleId = 5, PermissionId = 9 }
        );
    }

    public static void SeedCatalogFrontPageItems(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatalogFrontPageItem>().HasData(
            new CatalogFrontPageItem
            {
                Id = 1,
                Title = "The Habbo Pet Shop",
                Image = "catalogue/feature_cata/feature_cata_hort_pets.png",
                TypeId = 0,
                ProductName = null,
                CatalogPageId = 277
            },
            new CatalogFrontPageItem
            {
                Id = 2,
                Title = "Trimmed Rose Gold Balloon",
                Image = "catalogue/feature_cata/feature_cata_vert_habbo20_roselinedball.png",
                TypeId = 0,
                ProductName = null,
                CatalogPageId = 757
            },
            new CatalogFrontPageItem
            {
                Id = 3,
                Title = "Chill Modern Bundle",
                Image = "catalogue/feature_cata/feature_cata_hort_habbo20_bun2.png",
                TypeId = 0,
                ProductName = null,
                CatalogPageId = 1001
            },
            new CatalogFrontPageItem
            {
                Id = 4,
                Title = "Clothes Shop",
                Image = "catalogue/feature_cata/feature_cata_hort_clothes.png",
                TypeId = 0,
                ProductName = null,
                CatalogPageId = 588
            }
        );
    }

    public static void SeedCatalogPages(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatalogPage>().HasData(
            new CatalogPage
            {
                Id = true,
                Name = "front_page",
                Caption = "Front Page",
                Layout = "frontpage4",
                RoleId = true,
                CatalogPageId = null,
                OrderId = true,
                IconId = 213,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\"]",
                TextsJson = "[\"Redeem a voucher code here:\"]"
            },
            new CatalogPage
            {
                Id = 2,
                Name = "furni",
                Caption = "Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = null,
                OrderId = 2,
                IconId = 263,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombuilder\", \"cr_infopic3\"]",
                TextsJson = "[\"Furni Shop\"]"
            },
            new CatalogPage
            {
                Id = 3,
                Name = "clothing",
                Caption = "Clothing",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = null,
                OrderId = 3,
                IconId = 37,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\"]"
            },
            new CatalogPage
            {
                Id = 4,
                Name = "pets",
                Caption = "Pets",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = null,
                OrderId = 4,
                IconId = 8,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\"]"
            },
            new CatalogPage
            {
                Id = 5,
                Name = "building",
                Caption = "Building",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = null,
                OrderId = 5,
                IconId = 263,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombuilder\"]"
            },
            new CatalogPage
            {
                Id = 6,
                Name = "furnimatic",
                Caption = "Furnimatic",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = 3,
                IconId = 65,
                Enabled = false,
                Visible = false
            },
            new CatalogPage
            {
                Id = 7,
                Name = "staff",
                Caption = "Staff",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = null,
                OrderId = 7,
                IconId = 65,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 8,
                Name = "habbo_club",
                Caption = "Habbo Club",
                Layout = "vip_buy",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 11,
                IconId = 172,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_club_headline1_en\", \"club\"]"
            },
            new CatalogPage
            {
                Id = 9,
                Name = "bots",
                Caption = "Bots",
                Layout = "bots",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 13,
                IconId = 65,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_bots_headline1_en\", \"catalog_bots_headline1_en\"]",
                TextsJson = "[\"They walk, they talk, and they make the perfect addition to any room!\"]"
            },
            new CatalogPage
            {
                Id = 10,
                Name = "my_sales",
                Caption = "My Sales",
                Layout = "marketplace_own_items",
                RoleId = true,
                CatalogPageId = 220,
                OrderId = true,
                IconId = 70,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 11,
                Name = "offers",
                Caption = "Offers",
                Layout = "marketplace",
                RoleId = true,
                CatalogPageId = 220,
                OrderId = 2,
                IconId = 71,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 12,
                Name = "credit_furni",
                Caption = "Credit Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = true,
                IconId = 146,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_bank_headline1\", \"catalog_bank_teaser\"]",
                TextsJson =
                    "[\"Habbo Exchange is where you can convert your Credits into a tradable currency. You can then use this currency to trade for Furni or just show off your riches in your room.\"]"
            },
            new CatalogPage
            {
                Id = 13,
                Name = "spaces",
                Caption = "Spaces",
                Layout = "spaces_new",
                RoleId = true,
                CatalogPageId = 603,
                OrderId = 8,
                IconId = 225,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"look_feel_text\"]",
                TextsJson =
                    "[\"Floors, wallpapers, landscapes - get a groovy combination for your room. Use our virtual room preview below to test out the combinations before you buy. Select the design and colour you like and click buy.\"]"
            },
            new CatalogPage
            {
                Id = 14,
                Name = "limited_rares",
                Caption = "Limited Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 6,
                IconId = 145,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"limited_header\", \"catalog_limited_teaser_en\"]",
                TextsJson = "[\"These are only available for a limited time!\"]"
            },
            new CatalogPage
            {
                Id = 15,
                Name = "club_gifts",
                Caption = "Club Gifts",
                Layout = "club_gifts",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = true,
                IconId = 172,
                Enabled = false,
                Visible = false,
                TextsJson = "[\"This is currently not coded in Morningstar.\"]"
            },
            new CatalogPage
            {
                Id = 16,
                Name = "lighting",
                Caption = "Lighting",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 6,
                IconId = 115,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_dimmers_header1_en\", \"catalog_dimmer_teaser_en\"]",
                TextsJson =
                    "[\"Check out the Mood Lights. Use these items to dim the light in your rooms. Try out different light settings with different wallpapers to see what you get. Talk about lighting with style!\", null, \"Click on an item for details.\"]"
            },
            new CatalogPage
            {
                Id = 17,
                Name = "mode",
                Caption = "Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 7,
                IconId = 39,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 18,
                Name = "lodge",
                Caption = "Lodge",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 6,
                IconId = 37,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_lodge_headline1\", \"catalog_lodge_teaser1\"]",
                TextsJson =
                    "[\"For that splendid ski-lodge effect with an open fire and whisky on the sidebar. This range is for those who appreicate the true beauty of solid wood.\"]"
            },
            new CatalogPage
            {
                Id = 19,
                Name = "colourable_plasto",
                Caption = "Colourable Plasto",
                Layout = "default_3x3_color_grouping",
                RoleId = true,
                CatalogPageId = 511,
                OrderId = true,
                IconId = 46,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"plastic\", \"plastic_pasic_promo_1\"]",
                TextsJson =
                    "[\"Throw on an afro and grab a disco ball! Feel that retro, 1970s vibe? You soon will with this colourful, plastic range! Choose a colour to suit your mood and off you go!\"]"
            },
            new CatalogPage
            {
                Id = 20,
                Name = "vegetation",
                Caption = "Vegetation",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 602,
                OrderId = 2,
                IconId = 220,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_plants_headline1\", \"catalog_plants_teaser1\"]",
                TextsJson =
                    "[\"Every room needs a plant! Not only do they bring a bit of the outside inside, they also enhance the air quality! And what better gift for a friend than a beautiful rose or elegant fruit tree...\"]"
            },
            new CatalogPage
            {
                Id = 21,
                Name = "walls",
                Caption = "Walls",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 603,
                OrderId = 3,
                IconId = 122,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_walls_header_dyn\", \"catalog_walls_teaser2_001\"]",
                TextsJson =
                    "[\"Bring the outdoors in with windows and posters. Transform your surroundings - your walls will never look bare again!\"]"
            },
            new CatalogPage
            {
                Id = 22,
                Name = "accessories",
                Caption = "Accessories",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 2,
                IconId = 11,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_extra_headline1\", \"catalog_extra_teaser1\"]",
                TextsJson = "[\"However you place your essential Furniture, it's the finishing touches that count!\"]"
            },
            new CatalogPage
            {
                Id = 23,
                Name = "pixel_rentals",
                Caption = "Pixel Rentals",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 526,
                OrderId = 7,
                IconId = 5,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 24,
                Name = "base",
                Caption = "Base",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 11,
                IconId = 179,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_base\", \"base_rentable_teaser\"]",
                TextsJson =
                    "[\"This colourful range of furni has everything you need to style out your room and build great spaces.\"]"
            },
            new CatalogPage
            {
                Id = 25,
                Name = "badge_display",
                Caption = "Badge Display",
                Layout = "badge_display",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 10,
                IconId = 224,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_badgedisplay\", \"badgedisplay_promo2\"]",
                TextsJson =
                    "[\"You worked hard to get your badges, right? Now's the time to show it off, grab a display case and choose your favorite badge to show off!\"]"
            },
            new CatalogPage
            {
                Id = 26,
                Name = "room_event",
                Caption = "Room Event",
                Layout = "roomads",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 3,
                IconId = 55,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"events_header\"]"
            },
            new CatalogPage
            {
                Id = 27,
                Name = "iced",
                Caption = "Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 4,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_iced_headline1\", \"catalog_iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 28,
                Name = "alhambra",
                Caption = "Alhambra",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 4,
                IconId = 12,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"alhambra_header\", \"alhambra_teaser\"]",
                TextsJson =
                    "[\"For the cold Arabian nights and hot Arabian days, you'll need a palace.. And we have just what you need! Green blossom print should cover it just fine!\"]"
            },
            new CatalogPage
            {
                Id = 29,
                Name = "glass",
                Caption = "Glass",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 29,
                IconId = 29,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_glass_headline1\", \"catalog_glass_teaser1\"]",
                TextsJson =
                    "[\"You can really open up a space with this stylish glass furniture, just don't walk into it!\"]"
            },
            new CatalogPage
            {
                Id = 30,
                Name = "gothic",
                Caption = "Gothic",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 30,
                IconId = 30,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_gothic_headline1\", \"catalog_gothic_teaser1\"]",
                TextsJson =
                    "[\"As the church bells ring out midnight, you walk through your cobbled hall lit by candles, throw yourself into your medieval throne and paint your nails black. This is what we imagined when we ordered this range!\"]"
            },
            new CatalogPage
            {
                Id = 31,
                Name = "japan",
                Caption = "Japan",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 38,
                IconId = 36,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_jap_headline1\", \"catalog_jap_teaser3_en\"]",
                TextsJson =
                    "[\"We have sushi, tatami and katana's! I have no idea what the difference is, but I sure know its Japanese! Fulfil your fantasies and buy some today!\"]"
            },
            new CatalogPage
            {
                Id = 32,
                Name = "lost_tribe",
                Caption = "Lost Tribe",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 44,
                IconId = 38,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"losttribe\", \"LT_teaser_en\"]",
                TextsJson =
                    "[\"Start your own tribal village with our ancient furniture, all carved from hard wearing stone. NOTE: Lava is hot, get an adult to help you.\"]"
            },
            new CatalogPage
            {
                Id = 33,
                Name = "neon",
                Caption = "Neon",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 50,
                IconId = 41,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_neon_header1_en\", \"catalog_neon_teaser1_en\"]",
                TextsJson =
                    "[\"Party animals rejoice! Feel the base and reach for the lasers with the Neon Furni range - everything you need to get the party started!\"]"
            },
            new CatalogPage
            {
                Id = 34,
                Name = "relax",
                Caption = "Relax",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 60,
                IconId = 49,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rela_header_en\", \"rela_teaser_en\"]",
                TextsJson =
                    "[\"Relax after a busy day in the Welcome Lounge. Light a few candles, and chill out with a good read in a wicker chair. We understand the needs of a Wulles with a hectic lifestyle!\"]"
            },
            new CatalogPage
            {
                Id = 35,
                Name = "romantique",
                Caption = "Romantique",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 61,
                IconId = 50,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_romantique_headline1\", \"catalog_rom_teaser_en\"]",
                TextsJson =
                    "[\"Found in a French barn, this sweet but sexily romantic range caters to every ladies needs. Just going to powder my nose!\"]"
            },
            new CatalogPage
            {
                Id = 36,
                Name = "scifi",
                Caption = "Scifi",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 65,
                IconId = 53,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"sf_header_en\", \"sf_teaser_en\"]",
                TextsJson =
                    "[\"Sci Fi convention, outer space, the Moon, we have everything you need to make your own mystical, un-earthly room right here!\"]"
            },
            new CatalogPage
            {
                Id = 37,
                Name = "2009_shalimar",
                Caption = "2009 - Shalimar",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 3,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_shal_header1_en\", \"catalog_shal_teaser_en\"]",
                TextsJson = "[\"Based on Bollywood!\"]"
            },
            new CatalogPage
            {
                Id = 38,
                Name = "freeze!",
                Caption = "Freeze!",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 5,
                IconId = 87,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_freeze_en\", \"ctlg_teaser_es\"]"
            },
            new CatalogPage
            {
                Id = 39,
                Name = "pixel_collectibles",
                Caption = "Pixel Collectibles",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 526,
                OrderId = 5,
                IconId = 5,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 40,
                Name = "ads_room_backgrounds",
                Caption = "Ads Room Backgrounds",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = true,
                IconId = 47,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"Use these to place images in your room. The mpu's go to a link when clicked; the AD one does not.\"]"
            },
            new CatalogPage
            {
                Id = 41,
                Name = "theatredome",
                Caption = "Theatredome",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 25,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"article_habboreport2\"]",
                TextsJson =
                    "[\"The Theatredrome is a very old and popular Public Room. It's hosted many campaigns from paying sponsors.\"]"
            },
            new CatalogPage
            {
                Id = 42,
                Name = "rollers",
                Caption = "Rollers",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 9,
                IconId = 222,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_roller_headline1\", \"catalog_teaser_rollers_en\"]",
                TextsJson =
                    "[\"Move your imagination. This cool stuff is more than suitable for business and pleasure... Habbo rollers for games and queues. Now available in multipacks.\"]"
            },
            new CatalogPage
            {
                Id = 43,
                Name = "diner",
                Caption = "Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 23,
                IconId = 204,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\"]"
            },
            new CatalogPage
            {
                Id = 44,
                Name = "twilight",
                Caption = "Twilight",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 66,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_twilight_header_en\", \"ctlg_pic_ads_twi_mist\"]",
                TextsJson =
                    "[\"I've never read the book, all I know is it has vampires playing basket ball and some heart throb called Edward Cullen, but the furni looks good!\"]"
            },
            new CatalogPage
            {
                Id = 45,
                Name = "battle_banzai",
                Caption = "Battle Banzai",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 3,
                IconId = 78,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_battleBanzai_header_en\", \"catalog_battleBanzai_teaser\"]",
                TextsJson =
                    "[\"Bigger, Better, Bouncier - it's Battle Banzai! Now YOU set the rules for your own game, in your own room. You got the Banzai Power!\"]"
            },
            new CatalogPage
            {
                Id = 46,
                Name = "trax",
                Caption = "Trax",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 74,
                IconId = 4,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"hotelhits_catalog_header\", \"hotelhits_teaser\"]",
                TextsJson =
                    "[\"Trax are the Habbo music disks which have many multiple tunes installed onto them which can be played on a Trax Machine in the room. After the Habbo transistion from Shockwave to Flash clients, the trax system was not recovered until April 2011, where only Juke Boxes, old CDs, and Habbo sold CDs were re-released.\"]"
            },
            new CatalogPage
            {
                Id = 47,
                Name = "hello",
                Caption = "Hello",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 526,
                OrderId = 3,
                IconId = 5,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 48,
                Name = "automobile",
                Caption = "Automobile",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 526,
                OrderId = true,
                IconId = 5,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 49,
                Name = "goodbye_big_hand",
                Caption = "Goodbye Big Hand",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 26,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 50,
                Name = "2010_bling",
                Caption = "2010 - Bling",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 5,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_bling_en\", \"catalog_teaser_bling11\"]",
                TextsJson =
                    "[\"Did someone speak in glamour? Chic? Lux? So you're speaking the language of Bonnie Blonde, my friend!\"]"
            },
            new CatalogPage
            {
                Id = 51,
                Name = "organo",
                Caption = "Organo",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 51,
                IconId = 235,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"organo_cata_header\", \"organo_teaser\"]",
                TextsJson =
                    "[\"The latest range from Ann Summers, the Orgie line. Made of soft, wipe clean plastic, its perfect for any three, four or fivesome!\"]"
            },
            new CatalogPage
            {
                Id = 52,
                Name = "pet_food",
                Caption = "Pet Food",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = 2,
                IconId = 201,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_petfood\", \"ctlg_pet_teaser1\"]",
                TextsJson = "[\"Keep your Pet happy and healthy. Feed it and don't forget about exercise!\"]"
            },
            new CatalogPage
            {
                Id = 53,
                Name = "runway",
                Caption = "Runway",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 62,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"runway_header_en\", \"runway_teaser_en\"]",
                TextsJson =
                    "[\"Spice up your salon, hair parlour or boutique with our stylish yet practical range! From sewing machines to comfy seating, we've got the perfect option for you.\"]"
            },
            new CatalogPage
            {
                Id = 54,
                Name = "prison",
                Caption = "Prison",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 57,
                IconId = 240,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"prisonheader\", \"prisonteaser\"]",
                TextsJson = "[\"Hey, he's escaping! Just kidding, no one's getting out of these high security cells!\"]"
            },
            new CatalogPage
            {
                Id = 55,
                Name = "tv_studio",
                Caption = "TV Studio",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 76,
                IconId = 136,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"header_studio\", \"teaser_studio\"]",
                TextsJson = "[\"The Studio range lets YOU be your own music producer!\"]"
            },
            new CatalogPage
            {
                Id = 56,
                Name = "cubie",
                Caption = "Cubie",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 20,
                IconId = 100,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_cubie_header_en\", \"catalog_cubie_teaser\"]",
                TextsJson =
                    "[\"It's sleek, it's modern, it's so darn cool it can barely stand itself... Introducing the Cubie Furni range! Give your Bachelor or Bachelorette pad a homely feel with a sophisticated twist.\"]"
            },
            new CatalogPage
            {
                Id = 57,
                Name = "waasa",
                Caption = "Waasa",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 80,
                IconId = 103,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"waasa_catalogue_header\", \"waasa_teaser\"]",
                TextsJson =
                    "[\"Waasa is the perfect furniture for a chilled, laidback room. Especially good for students on a budget!\"]"
            },
            new CatalogPage
            {
                Id = 58,
                Name = "american_idol",
                Caption = "American Idol",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 3,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_AI1_en\", \"catalog_teaser_idol\"]",
                TextsJson =
                    "[\"Host your own American Idol show with this replica furniture! All that's missing is a Randy Jackson lookalike!\"]"
            },
            new CatalogPage
            {
                Id = 59,
                Name = "kitchen",
                Caption = "Kitchen",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 41,
                IconId = 217,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_kitchen2015\", \"teaser_kitchen2015\"]",
                TextsJson =
                    "[\"Fancy owning a Habbo restaurant? Or just love catering for Habbos in style? With this furni line you can REALLY get cooking!\"]"
            },
            new CatalogPage
            {
                Id = 60,
                Name = "usva",
                Caption = "USVA",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 78,
                IconId = 129,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"catalog_header_USVA\", \"Catalog_teaser_USVA\"]",
                TextsJson =
                    "[\"With a great range of colours and new stacking possibilities, you'll love building and creating structures with the new USVA Furni line!\"]"
            },
            new CatalogPage
            {
                Id = 61,
                Name = "santorini_crackables",
                Caption = "Santorini Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 11,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 62,
                Name = "mystics",
                Caption = "Mystics",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 48,
                IconId = 185,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"header_mystics\", \"teaser_mystics\"]",
                TextsJson =
                    "[\"A mystic crystal has crashed outside the hotel bounds and is transforming the hotel into an infected wilderness. Will you fight for the side for good? Or will you fight for the side of evil and help the infection spread?\"]"
            },
            new CatalogPage
            {
                Id = 63,
                Name = "triggers",
                Caption = "Triggers",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 3,
                IconId = 81,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_wired_header2_en\", \"ctlg_pic_wired_triggers\"]",
                TextsJson =
                    "[\"Triggers let you define what needs to happen for an Effect to take place. To program a Trigger, place it in a room, double click on it and set it up! You need to stack an Effect with the Trigger to make it work.\", null, \"Click to see how each Trigger works.\"]"
            },
            new CatalogPage
            {
                Id = 64,
                Name = "effects",
                Caption = "Effects",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 4,
                IconId = 82,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_wired_header3_en\", \"ctlg_pic_wired_effects\"]",
                TextsJson =
                    "[\"Effects are what happens after you activate a Trigger. To program an Effect, place it in a room, double click on it and set it up! You will always need to stack a Trigger with the Effect to make it work.\", null, \"Click on an item to see what the Effect does!\"]"
            },
            new CatalogPage
            {
                Id = 65,
                Name = "conditions",
                Caption = "Conditions",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 5,
                IconId = 83,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_wired_header4_en\", \"ctlg_pic_wired_conditions\"]",
                TextsJson =
                    "[\"Conditions are specific things that need to be done before a Trigger will work. If you want to use a Condition, you will need to stack it with a Trigger and Effect.\", null, \"Click on an item to see what the Condition does!\"]"
            },
            new CatalogPage
            {
                Id = 66,
                Name = "stray_pixels",
                Caption = "Stray Pixels",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 61,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"StrayPixelsLogo\", \"catalog_pxl_teaser2_nl\"]"
            },
            new CatalogPage
            {
                Id = 67,
                Name = "mayan",
                Caption = "Mayan",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 45,
                IconId = 171,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"mayanheader2\", \"mayanteaser\"]",
                TextsJson = "[\"Just what you need to prove you survived the apocolypse!\"]"
            },
            new CatalogPage
            {
                Id = 68,
                Name = "african",
                Caption = "African",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 3,
                IconId = 233,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"african_header\", \"african_catateaser\"]",
                TextsJson = "[\"The new African furniture range is here!\"]"
            },
            new CatalogPage
            {
                Id = 69,
                Name = "anna",
                Caption = "Anna",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 6,
                IconId = 104,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_anna_header\", \"catalog_anna_teaser\"]",
                TextsJson = "[\"Make the new Anna range yours!\"]"
            },
            new CatalogPage
            {
                Id = 70,
                Name = "steampunk",
                Caption = "Steampunk",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 67,
                IconId = 180,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_steampunk\", \"catalog_teaser_steampunk\"]",
                TextsJson =
                    "[\"Infuse your room design with the power of steam! This Steampunk line is a full set of building material to create amazing room designs that resemble an alternate retro-futuristic universe.\"]"
            },
            new CatalogPage
            {
                Id = 71,
                Name = "tents",
                Caption = "Tents",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 602,
                OrderId = 6,
                IconId = 223,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_tents\", \"catalog_teaser_tents\"]",
                TextsJson =
                    "[\"Want some privacy? Go inside a tent to have private conversations in public places. Habbos outside will not see your chat nor will they see what's happening on the inside.\"]"
            },
            new CatalogPage
            {
                Id = 72,
                Name = "pirates",
                Caption = "Pirates",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 708,
                OrderId = 53,
                IconId = 190,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_pirate\", \"pirate_bundle\"]",
                TextsJson = "[\"Yarrr! Harrrrr! Fiddle dee dee, being a pirate is alright with me!\"]"
            },
            new CatalogPage
            {
                Id = 73,
                Name = "calippo",
                Caption = "Calippo",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 8,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"calippo_header_es\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 74,
                Name = "habbo_stars",
                Caption = "Habbo Stars",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 32,
                IconId = 196,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"habbostars1\", \"habbostars2\"]",
                TextsJson =
                    "[\"Have you always wanted to be famous? Is singing, dancing, or acting your thing? Well we have the next best thing, Wulles Stars! Get your dancing feet on and make your name shine!\"]"
            },
            new CatalogPage
            {
                Id = 75,
                Name = "dogs",
                Caption = "Dogs",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 13,
                IconId = 24,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Wet noses, paws and woofs! You're about to enter the world of Habbo Dogs. An adorable and cuddly ball of fur awaits you with a waggling tail.\", \"Name your Dog:\", \"Pick a colour:\", \"Pick a breed:\"]"
            },
            new CatalogPage
            {
                Id = 76,
                Name = "cats",
                Caption = "Cats",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 14,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Fluff, whiskers, meows and purrs! These cute little critters make great playmates and will keep you entertained.\", \"Name your Cat:\", \"Pick a colour:\", \"Pick a breed:\"]"
            },
            new CatalogPage
            {
                Id = 77,
                Name = "crocs",
                Caption = "Crocs",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 10,
                IconId = 22,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Scaly skin, growls and snaps! Security for your room or used to scare your friends - this surprisingly loving Croc can be yours.\", \"Name your Croc:\", \"Pick a colour:\", \"Pick a breed:\"]"
            },
            new CatalogPage
            {
                Id = 78,
                Name = "terriers",
                Caption = "Terriers",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 7,
                IconId = 66,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"The Cairn Terrier is one of the oldest terrier breeds. From the Scottish Highlands, it was used for hunting prey among the cairns! Different breeds have different colours!\", \"Name your Terrier:\", \"Pick a colour:\", \"Pick a breed:\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 79,
                Name = "bears",
                Caption = "Bears",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 5,
                IconId = 68,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"A large mammal that walks on the soles of its feet, with thick fur and a short tail. Did you know that bears are related to dogs and that most species are omnivorous?\", \"Name your Bear:\", null, \"Pick a breed:\"]"
            },
            new CatalogPage
            {
                Id = 80,
                Name = "pig",
                Caption = "Pigs",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 15,
                IconId = 67,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Finally an excuse to leave your room looking like a pigsty! Mischevious and cute, these little guys are out of the ordinary. Sweet and funny, a pet like no other!\", \"Name your Pet Pig:\", \"Pick a colour:\", \"Pick a breed:\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 81,
                Name = "lion",
                Caption = "Lion",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 8,
                IconId = 76,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"A boisterous predator in nature, the lion has been tamed to be your fierce friend in Habbo Hotel.\", \"Name your pet:\", \"Choose a colour:\", \"Choose a breed:\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 82,
                Name = "rhino",
                Caption = "Rhino",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 11,
                IconId = 77,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"The Rhinoceros is an African herbivore that can weigh over a ton. It is proud and slightly aloof, but loyal and never let anything get in the way of a good time!\", \"Name your pet:\", \"Choose a colour:\", \"Choose a breed:\"]"
            },
            new CatalogPage
            {
                Id = 83,
                Name = "spider",
                Caption = "Spider",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 12,
                IconId = 95,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"One of the most feared creatures in nature, and perhaps the most misunderstood. The majority of Spiders have sharp fangs that inject venom into their prey- but don't worry, these spiders won't bite! Maybe...\", \"Name your pet:\"]"
            },
            new CatalogPage
            {
                Id = 84,
                Name = "turtle",
                Caption = "Turtles",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 9,
                IconId = 126,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Anything but slow, these guys are ready to ride the waves and swim laps at your beaches!\", \"Name your Turtle:\", null]"
            },
            new CatalogPage
            {
                Id = 85,
                Name = "chick",
                Caption = "Chick",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 107,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson = "[null, \"Name your Dragon:\", \"Select your colour\\\\/breed:\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 86,
                Name = "frog",
                Caption = "Frog",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 16,
                IconId = 97,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Cute, green and slimy! Frogs come in a variety of colours and can be found all over the world. They are great jumpers and make great pets, but are harder to hold onto than a supermodel in a tornado.\", \"Name your Frog:\", null]"
            },
            new CatalogPage
            {
                Id = 87,
                Name = "dragon",
                Caption = "Dragons",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 6,
                IconId = 109,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Keepers of the Dragon, beware...their history is legendary... With their fiery breath and scaly skin, these mythical creatures are nothing but fierce!\", \"Name your Dragon:\", null]"
            },
            new CatalogPage
            {
                Id = 88,
                Name = "monkey",
                Caption = "Pet Monkey",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 2,
                IconId = 166,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"This mischevious monkey has made his way into the hotel and into our hearts. From the tilted beret to his love of bunches of bananas- this Monkey is sure to liven up your Habbo life!\", \"Name your Monkey:\", null]"
            },
            new CatalogPage
            {
                Id = 89,
                Name = "horse",
                Caption = "Pet Horse",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = true,
                IconId = 132,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_horse_header2_en\"]",
                TextsJson =
                    "[\"You can ride your horse around the Hotel and customize its body and hair colour.\", \"Name your Horse:\", null]"
            },
            new CatalogPage
            {
                Id = 90,
                Name = "bunny",
                Caption = "Bunny",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 148,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"babypets_cata_header\"]",
                TextsJson =
                    "[\"OINK! Partial to a good roll in the mud, these playful piggies have trotted into the hotel and are ready for fun!\", \"Name your Piglet:\", \"Select your colour\\\\/breed:\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 91,
                Name = "bunny_bad",
                Caption = "Bunny - Bad",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 151,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_horse_header2_en\"]",
                TextsJson =
                    "[\"You can ride your horse around the Hotel and also customize its body and hair colour.\", \"Name Your Horse:\"]"
            },
            new CatalogPage
            {
                Id = 92,
                Name = "bunny_bored",
                Caption = "Bunny - Bored",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 150,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"These mischievous little pets have travelled all the way from the deep jungles of WobbahLand! Adorable as they are naughty, these little guys love a good sing-a-long.\", \"Name your Obbah Wobbah:\", \"Select a colour:\"]"
            },
            new CatalogPage
            {
                Id = 93,
                Name = "bunny_manic",
                Caption = "Bunny - Manic",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 149,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"One of the most feared creatures in nature, and perhaps the most misunderstood. The majority of Spiders have sharp fangs that inject venom into their prey- but don't worry, these spiders won't bite ! Maybe...\", \"Name your pet:\"]"
            },
            new CatalogPage
            {
                Id = 94,
                Name = "pigeon_wise",
                Caption = "Pigeon - Wise",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 2,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 95,
                Name = "pigeon_cunning",
                Caption = "Pigeon - Cunning",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 2,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 96,
                Name = "monkey_evil",
                Caption = "Monkey - Evil",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 167,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 97,
                Name = "bear_cubs",
                Caption = "Bear Cubs",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = true,
                IconId = 228,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]"
            },
            new CatalogPage
            {
                Id = 98,
                Name = "terrier_puppies",
                Caption = "Terrier Puppies",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 5,
                IconId = 228,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]"
            },
            new CatalogPage
            {
                Id = 99,
                Name = "kittens",
                Caption = "Kittens",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 221,
                OrderId = 2,
                IconId = 228,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"Leaping their way around the Hotel, these fluffy furballs are here to steal your heart...and your yarn!\", \"Name your pet:\"]"
            },
            new CatalogPage
            {
                Id = 100,
                Name = "puppies",
                Caption = "Puppies",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 221,
                OrderId = true,
                IconId = 228,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"So soft and cuddly, these playful pups are certain to melt your heart. From Labradors to Dalmatians, there's a breed for everyone!\", \"Name your pet:\"]"
            },
            new CatalogPage
            {
                Id = 101,
                Name = "piglets",
                Caption = "Piglets",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 221,
                OrderId = 3,
                IconId = 228,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\"]",
                TextsJson =
                    "[\"OINK! Partial to a good roll in the mud, these playful piggies have trotted into the hotel and are ready for fun!\", \"Name your pet:\"]"
            },
            new CatalogPage
            {
                Id = 102,
                Name = "velociraptor",
                Caption = "Velociraptor Pet",
                Layout = "single_bundle",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 3,
                IconId = 260,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"jurassic15_catalog_header\", \"dino_pets\"]",
                TextsJson =
                    "[\"Swift and sneaky, these reptiles have a reputation for being somewhat high-maintenance, incredibly intellectual and endlessly troublesome! You'll often find them pondering over deeply philosophical questions, or enjoying the finer things in life, like pedicures and meat straight off the bone.\"]"
            },
            new CatalogPage
            {
                Id = 103,
                Name = "coral_kingdom_crackables",
                Caption = "Coral Kingdom Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 104,
                Name = "drago",
                Caption = "Drago",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 24,
                IconId = 110,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"drago_catalog_header2\", \"drago_catalog_teaser2\"]",
                TextsJson = "[\"Dungeon furniture, the perfect range to create your torturous cellars!\"]"
            },
            new CatalogPage
            {
                Id = 105,
                Name = "dark_pura",
                Caption = "Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 10,
                IconId = 48,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"The cleanest, freshest range. You can almost hear it breathe cool and tranquility within your room.\"]"
            },
            new CatalogPage
            {
                Id = 106,
                Name = "boutique",
                Caption = "Boutique",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 15,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"boutique_catalog_01\", \"boutique_catalog_teaser_01\"]",
                TextsJson =
                    "[\"The boutique range is just the thing if you want to own a high end fashion store in Milan, but are on a budget.\"]"
            },
            new CatalogPage
            {
                Id = 107,
                Name = "habbo_groups",
                Caption = "Habbo Groups",
                Layout = "guilds",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 15,
                IconId = 203,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_groups_en\", \"catalog_groupsteaser_en\"]",
                TextsJson =
                    "[\"Habbo Groups are a great way to stay in touch with your friends and share your interests with others. Each Group has a homeroom that can be decorated by other Group members, members can also purchase exclusive Group Furni that can be customised with your Group colours!\", \"* Get together with people you get together with!\\\\r\\\\n* Co-op room decorating for group members\\\\r\\\\n* Show off your group badge!\\\\r\\\\n* Get some neat Furni in your group's colours!\", \"What's So Great About Habbo Groups?\"]"
            },
            new CatalogPage
            {
                Id = 108,
                Name = "group_furni",
                Caption = "Group Furni",
                Layout = "guild_custom_furni",
                RoleId = true,
                CatalogPageId = 107,
                OrderId = true,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_groups_en\"]",
                TextsJson =
                    "[\"Show off your Group spirit with the new customisable Furni. Select your Group and then get your furni in your Groups colours.\"]"
            },
            new CatalogPage
            {
                Id = 109,
                Name = "youtube",
                Caption = "Youtube",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 83,
                IconId = 188,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_tv\", \"yttv\"]",
                TextsJson =
                    "[\"Remember when Habbo had YouTube TVs? Well it can again, with KrewsTube! Check it out at krews.org\"]"
            },
            new CatalogPage
            {
                Id = 110,
                Name = "vikings",
                Caption = "Vikings",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 79,
                IconId = 208,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"vikings_catalog_header\", \"catalog_teaser_vikings\"]",
                TextsJson =
                    "[\"From weapon racks and heads on spikes, to ornate hand-carved wooden chairs and benches. This furni has everything you need and more to create the Viking village of your dreams. With furni available in clan colours, you can display your true loyalty with pride!\"]"
            },
            new CatalogPage
            {
                Id = 111,
                Name = "palooza_2013",
                Caption = "Palooza - 2013",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 269,
                OrderId = true,
                IconId = 227,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_teaser_palooza\", \"catalog_teaser_palooza\"]",
                TextsJson =
                    "[\"Create your own stage and outdoor festival area. We've got stages, fencing and even vending machines!\"]"
            },
            new CatalogPage
            {
                Id = 112,
                Name = "wild_wild_west",
                Caption = "Wild Wild West",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 82,
                IconId = 229,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_wwest\", \"catalog_teaser_wildwest\"]",
                TextsJson =
                    "[\"From the Shoot'em Up Saloon to the Sheriff's Office, and all the floor tiles, cacti and tumbleweeds in between...Wild West furni has made it's way to town.\"]"
            },
            new CatalogPage
            {
                Id = 113,
                Name = "club_nx",
                Caption = "Club NX",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 4,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson = "[\"On Habbo, there is a door at the top next to the bar that leads to Hallway 2.\"]"
            },
            new CatalogPage
            {
                Id = 114,
                Name = "habbo_university",
                Caption = "Habbo University",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 33,
                IconId = 230,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"university_new_furni_catalog_header\", \"university_catalog_teaser\"]",
                TextsJson = "[\"From pink and flowery, to hipster chic - Every Habbo has a style.\"]"
            },
            new CatalogPage
            {
                Id = 115,
                Name = "toys_and_accessories",
                Caption = "Toys and Accessories",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = 3,
                IconId = 199,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline2\", \"catalog_teaser_pettoys\"]",
                TextsJson =
                    "[\"The baby pets are here! Take good care of them and keep them happy with our exciting range of food and toys!\", \"Get some nice accessories for your pet.\"]"
            },
            new CatalogPage
            {
                Id = 116,
                Name = "attic",
                Caption = "Attic",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 10,
                IconId = 242,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"attic15_catalog_header\", \"attic15_catalog_teaser\"]",
                TextsJson =
                    "[\"From squeaky floor boards to ancient furniture, the Attic 2015 furniture is now here!\"]"
            },
            new CatalogPage
            {
                Id = 117,
                Name = "alphabet_blocks",
                Caption = "Alphabet Blocks",
                Layout = "default_3x3_color_grouping",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = true,
                IconId = 101,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_alpha1\", \"catalog_teaser_alpha1\"]",
                TextsJson = "[\"A... B... C... and Z, bitch...\"]"
            },
            new CatalogPage
            {
                Id = 118,
                Name = "neo-habbo",
                Caption = "Neo-Habbo",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 49,
                IconId = 254,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_cpunk15\", \"old_cypunk\"]",
                TextsJson =
                    "[\"Light-filled cityscapes and brightly lit skycrapers looming ovehead... This is the dark, dark furni line of the future. The future is called CyberPunk.\"]"
            },
            new CatalogPage
            {
                Id = 119,
                Name = "habbo_mall",
                Caption = "Habbo Mall",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 29,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 120,
                Name = "ancients",
                Caption = "Ancients",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 5,
                IconId = 170,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_ancients\", \"africa\"]",
                TextsJson = "[\"Follow in the footsteps of the Ancients with these wonderous Ancient artifacts.\"]"
            },
            new CatalogPage
            {
                Id = 121,
                Name = "mad_scientist",
                Caption = "Mad Scientist",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 37,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 122,
                Name = "2013_loyalty",
                Caption = "2013 - Loyalty",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 270,
                OrderId = 6,
                IconId = 184,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 123,
                Name = "spiderwick",
                Caption = "Spiderwick",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 60,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"spiderwick\", \"catalog_spw_teaser1_en\"]"
            },
            new CatalogPage
            {
                Id = 124,
                Name = "around_the_world_2008",
                Caption = "Around the World - 2008",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = true,
                IconId = 56,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 125,
                Name = "extras",
                Caption = "Extras",
                Layout = "pets",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 10,
                IconId = 215,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 126,
                Name = "cone",
                Caption = "Cone",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 3,
                IconId = 244,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 127,
                Name = "cylinder",
                Caption = "Cylinder",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 4,
                IconId = 245,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 128,
                Name = "half_cylinder",
                Caption = "Half Cylinder",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 5,
                IconId = 251,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 129,
                Name = "hemisphere",
                Caption = "Hemisphere",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 6,
                IconId = 247,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 130,
                Name = "pyramid",
                Caption = "Pyramid",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 7,
                IconId = 248,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 131,
                Name = "quarter_ring",
                Caption = "Quarter Ring",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 8,
                IconId = 249,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 132,
                Name = "sphere",
                Caption = "Sphere",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 9,
                IconId = 250,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 133,
                Name = "standing_half_cylinder",
                Caption = "Standing Half Cylinder",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 10,
                IconId = 246,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 134,
                Name = "standing_triangular_prism",
                Caption = "Standing Triangular Prism",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 11,
                IconId = 252,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 135,
                Name = "wedge",
                Caption = "Wedge",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 12,
                IconId = 253,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 136,
                Name = "triangular_prism",
                Caption = "Triangular Prism",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 13,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 137,
                Name = "glass_panel",
                Caption = "Glass Panel",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 15,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 138,
                Name = "round",
                Caption = "Round",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 30,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 139,
                Name = "small",
                Caption = "Small",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 31,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 140,
                Name = "large",
                Caption = "Large",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 20,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 141,
                Name = "tile",
                Caption = "Tile",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 14,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 142,
                Name = "flower_hedge",
                Caption = "Flower Hedge",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 16,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 143,
                Name = "water",
                Caption = "Water",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 17,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 144,
                Name = "simple_wood",
                Caption = "Simple Wood",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 18,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 145,
                Name = "terra",
                Caption = "Terra",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 19,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 146,
                Name = "brick",
                Caption = "Brick",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 21,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 147,
                Name = "glass",
                Caption = "Glass",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 22,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 148,
                Name = "lava",
                Caption = "Lava",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 23,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 149,
                Name = "marble",
                Caption = "Marble",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 24,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 150,
                Name = "art_deco",
                Caption = "Art Deco",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 25,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 151,
                Name = "industrial",
                Caption = "Industrial",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 26,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 152,
                Name = "sand",
                Caption = "Sand",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 27,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 153,
                Name = "metal",
                Caption = "Metal",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 28,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 154,
                Name = "metal_crate",
                Caption = "Metal Crate",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 29,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 155,
                Name = "stone",
                Caption = "Stone",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 32,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 156,
                Name = "wool",
                Caption = "Wool",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 33,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 157,
                Name = "grass",
                Caption = "Grass",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 222,
                OrderId = 34,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"teaser_blocks\"]",
                TextsJson = "[\"1 Block... 2 Block... Red Block... Blue Block\", null]"
            },
            new CatalogPage
            {
                Id = 158,
                Name = "army_bootcamp",
                Caption = "Army Bootcamp",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 7,
                IconId = 259,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_army15\", \"army_newfurni\"]",
                TextsJson =
                    "[\"Purchase the new in stock army\\\\/military based furni - from gun racks to choppers, no matter what item you're after; this section will have it!\"]"
            },
            new CatalogPage
            {
                Id = 159,
                Name = "infobus",
                Caption = "Infobus",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 15,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"The famous Infobus was only ever opened when staff were hosting events or discussions, whereas the park was always open.\"]"
            },
            new CatalogPage
            {
                Id = 160,
                Name = "game_hub",
                Caption = "Game Hub",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 7,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"This room was the main collaboration shown of games and events between users and official Habbo staff.\"]"
            },
            new CatalogPage
            {
                Id = 161,
                Name = "paris",
                Caption = "Paris",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 53,
                IconId = 261,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"paris_header\", \"paris_teaser\"]",
                TextsJson =
                    "[\"Always wanted to build a Paris designed room? Now is your chance with this brand new set of Paris furniture.\"]"
            },
            new CatalogPage
            {
                Id = 162,
                Name = "hall_of_habbo",
                Caption = "Hall of Habbo",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 9,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"It is the least used Public Room, and features users who have won various competitions.\"]"
            },
            new CatalogPage
            {
                Id = 163,
                Name = "groups_forums",
                Caption = "Groups Forums",
                Layout = "guild_forum",
                RoleId = true,
                CatalogPageId = 107,
                OrderId = 2,
                IconId = 207,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_groups_en\"]"
            },
            new CatalogPage
            {
                Id = 164,
                Name = "usva_yellow",
                Caption = "USVA - Yellow",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 60,
                OrderId = 5,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_USVA\", \"Catalog_teaser_USVA\"]",
                TextsJson =
                    "[\"With a great range of colours and new stacking possibilities, you'll love building and creating structures with the new USVA Furni line!\"]"
            },
            new CatalogPage
            {
                Id = 165,
                Name = "usva_green",
                Caption = "USVA - Green",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 60,
                OrderId = 4,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_USVA\", \"Catalog_teaser_USVA\"]",
                TextsJson =
                    "[\"With a great range of colours and new stacking possibilities, you'll love building and creating structures with the new USVA Furni line!\"]"
            },
            new CatalogPage
            {
                Id = 166,
                Name = "usva__red",
                Caption = "USVA -  Red",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 60,
                OrderId = 3,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_USVA\", \"Catalog_teaser_USVA\"]",
                TextsJson =
                    "[\"With a great range of colours and new stacking possibilities, you'll love building and creating structures with the new USVA Furni line!\"]"
            },
            new CatalogPage
            {
                Id = 167,
                Name = "usva__blue",
                Caption = "USVA -  Blue",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 60,
                OrderId = true,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_USVA\", \"Catalog_teaser_USVA\"]",
                TextsJson =
                    "[\"With a great range of colours and new stacking possibilities, you'll love building and creating structures with the new USVA Furni line!\"]"
            },
            new CatalogPage
            {
                Id = 168,
                Name = "usva__pink",
                Caption = "USVA -  Pink",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 60,
                OrderId = 2,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_USVA\", \"Catalog_teaser_USVA\"]",
                TextsJson =
                    "[\"With a great range of colours and new stacking possibilities, you'll love building and creating structures with the new USVA Furni line!\"]"
            },
            new CatalogPage
            {
                Id = 169,
                Name = "hygge_crackables",
                Caption = "Hygge Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 170,
                Name = "pink_pura",
                Caption = "Pink Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 6,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 171,
                Name = "black_pura",
                Caption = "Black Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 3,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 172,
                Name = "white_pura",
                Caption = "White Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 10,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 173,
                Name = "beige_pura",
                Caption = "Beige Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 2,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 174,
                Name = "blue_pura",
                Caption = "Blue Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 4,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 175,
                Name = "green_pura",
                Caption = "Green Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 5,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 176,
                Name = "yellow_pura",
                Caption = "Yellow Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 10,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 177,
                Name = "red_pura",
                Caption = "Red Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 9,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 178,
                Name = "purple_pura",
                Caption = "Purple Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 8,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 179,
                Name = "aqua_pura",
                Caption = "Aqua Pura",
                Layout = "default_3x3_color_grouping",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = true,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 180,
                Name = "pura",
                Caption = "Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 9,
                IconId = 48,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 181,
                Name = "pura_extensions",
                Caption = "Pura Extensions",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 180,
                OrderId = 11,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes fresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 182,
                Name = "bathroom",
                Caption = "Bathroom",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 2,
                IconId = 17,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"bathroom_catahead\", \"bcbath_catateaser\"]",
                TextsJson =
                    "[\"Give yourself and your guests somewhere to freshen up - vital if you want to avoid nasty smells. Might be an idea to put your loo in a corner though.\"]"
            },
            new CatalogPage
            {
                Id = 183,
                Name = "bohemian_crackables",
                Caption = "Bohemian Festival Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 184,
                Name = "art_crackables",
                Caption = "Art Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 185,
                Name = "kung_fu_panda_2",
                Caption = "Kung Fu Panda 2",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 35,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"ctlg_pic_ads_twi_mist\"]",
                TextsJson =
                    "[\"I've never read the book, all I know is it has vampires playing basket ball and some heart throb called Edward Cullen, but the furni looks good!\"]"
            },
            new CatalogPage
            {
                Id = 186,
                Name = "spa_crackables",
                Caption = "Spa Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 12,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 187,
                Name = "trax_machines",
                Caption = "Trax Machines",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 75,
                IconId = 4,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"music_header\", \"catalog_djshop_teaser1\"]",
                TextsJson =
                    "[\"Let's get loud! Trax is an old, well-known feature of Habbo where you could mix your own tracks and get pumpin'. It's not the same without it, but at least the machines are still available!\"]"
            },
            new CatalogPage
            {
                Id = 188,
                Name = "farewell_pixels",
                Caption = "Farewell Pixels",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 526,
                OrderId = 2,
                IconId = 5,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 189,
                Name = "india_crackables",
                Caption = "India Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 9,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 190,
                Name = "campaigns",
                Caption = "Campaigns",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = true,
                IconId = 42,
                Enabled = false,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 191,
                Name = "non-crack_versions",
                Caption = "Non-Crack Versions",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = 14,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"Habbo sometimes releases non-crackable versions of crackables; find them here.\", null, null]"
            },
            new CatalogPage
            {
                Id = 192,
                Name = "habbo15_crackables",
                Caption = "Habbo15 Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 7,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 193,
                Name = "tokyo_crackables",
                Caption = "Tokyo Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 13,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 194,
                Name = "pixel_pet_accessories",
                Caption = "Pixel Pet Accessories",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 526,
                OrderId = 6,
                IconId = 5,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 195,
                Name = "white_diner",
                Caption = "White Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 5,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 196,
                Name = "picnic",
                Caption = "Picnic - Modern",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 22,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"The remodel was debuted in February 2015, and was renamed from Picnic Area to Picnic.\"]"
            },
            new CatalogPage
            {
                Id = 197,
                Name = null,
                Caption = "Null",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 125,
                OrderId = 10,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 198,
                Name = "bubblejuice",
                Caption = "BubbleJuice",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 6,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 199,
                Name = "jurassic_habbo",
                Caption = "Jurassic Habbo",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 40,
                IconId = 260,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"dino_header\", \"dino_teaser\"]",
                TextsJson =
                    "[\"The creatures of the Primeval times are back! With this furni line you can let pure space in a prehistorican shine!\"]"
            },
            new CatalogPage
            {
                Id = 200,
                Name = "outfits",
                Caption = "Outfits",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 3,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Different occasions require different outfits. To wear yours, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 201,
                Name = "hairdos",
                Caption = "Hairdos",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 4,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Make sure you have a hairstyle for every occasion! To wear, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 202,
                Name = "hats",
                Caption = "Hats",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 5,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Stay up to date with ALL of the latest headgear! To wear yours, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 203,
                Name = "dresses",
                Caption = "Dresses",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 7,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Dress to impress with these gorgeous, expertly crafted dresses! To wear, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 204,
                Name = "shirts",
                Caption = "Shirts",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 8,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"As the slightly smarter option, our shirts will dazzle your friends! To wear, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 205,
                Name = "jackets",
                Caption = "Jackets",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 9,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Wrap up warm, but keep it super-stylish with our selection of jackets. To wear, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 206,
                Name = "trousers",
                Caption = "Trousers",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 10,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Bottom-half clothing for those slightly colder days. To wear, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 207,
                Name = "skirts",
                Caption = "Skirts",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 11,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Show off your pixel-legs with our lovely selection of skirts! To wear, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 208,
                Name = "shoes",
                Caption = "Shoes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 12,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"You can NEVER have too many pairs of shoes. To wear yours, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 209,
                Name = "furni_by_line",
                Caption = "Furni By Line",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 10,
                IconId = 197,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"furni_for_colection\"]"
            },
            new CatalogPage
            {
                Id = 210,
                Name = "university_rares",
                Caption = "University Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 19,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 211,
                Name = "add-ons",
                Caption = "Add-Ons",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 6,
                IconId = 85,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_wired_header5_en\", \"ctlg_pic_wired_support_furniture\"]",
                TextsJson =
                    "[\"Use these simple Furni to bring extra spice to your Wired room. These are basic Furni, so you will still need Triggers, Effects and Conditions to make them work!\"]"
            },
            new CatalogPage
            {
                Id = 212,
                Name = "gardening",
                Caption = "Gardening",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 28,
                IconId = 157,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"garden_catalog_header\", \"garden_catalog_teaser\"]",
                TextsJson = "[\"Be at one with nature!\"]"
            },
            new CatalogPage
            {
                Id = 213,
                Name = "greek_crackables",
                Caption = "Greek Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 6,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 214,
                Name = "stranded_jungle",
                Caption = "Stranded Jungle",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 68,
                IconId = 59,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_2016jungle\", \"junglenewfurni\"]",
                TextsJson =
                    "[\"Step into a virtual world of survival, treacherous terrain and life-threatening tropical conditions... because the Stranded Jungle line is here!\"]"
            },
            new CatalogPage
            {
                Id = 215,
                Name = "custom_rooms",
                Caption = "Custom Rooms",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 10,
                IconId = 125,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_blackhole_header_en\", \"catalog_blackhole_teaser\"]",
                TextsJson =
                    "[\"Design your own custom room layouts with Stack Magic Tiles and Black holes. Stack your items to the ceiling or use them as dividers...the possibilities are endless!\"]"
            },
            new CatalogPage
            {
                Id = 216,
                Name = "greek",
                Caption = "Greek",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 31,
                IconId = 31,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"greek_header\", \"greek_catateaser\"]",
                TextsJson =
                    "[\"Be transported back to ancient Greece with a couple of thousand pounds and British Airways. Until then, build your own pantheon with our realistic Greek range!\"]"
            },
            new CatalogPage
            {
                Id = 217,
                Name = "sports",
                Caption = "Sports",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 66,
                IconId = 56,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_sports_headline1_br\", \"catalog_sports_teaser1\"]",
                TextsJson =
                    "[\"The whistle blows, but there's no track to practice on! Make your own before your trainer notices!\"]"
            },
            new CatalogPage
            {
                Id = 218,
                Name = "wired",
                Caption = "Wired",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 12,
                IconId = 80,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"catalog_wired_header1\", \"ctlg_pic_teaser_wired\"]"
            },
            new CatalogPage
            {
                Id = 219,
                Name = "game_shop",
                Caption = "Game Shop",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 14,
                IconId = 202,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"game_shop_header\", \"game_shop_teaser\"]",
                TextsJson = "[\"Get your gamer gear on!\"]"
            },
            new CatalogPage
            {
                Id = 220,
                Name = "marketplace",
                Caption = "Marketplace",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 17,
                IconId = 69,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_marketplace_header_en\", \"catalog_note_marketplace\"]",
                TextsJson =
                    "[\"Habbo Marketplace is a convenient and safe way to buy and sell items in Habbo.\", \"How does the Habbo Marketplace work?\", \"Buying items: Browse for the item you want to buy on the Marketplace Offers page and click Buy. We guarantee you'll get the item at the cheapest price available at the moment of purchase. No requirements needed.\\\\r\\\\n\\\\r\\\\nSelling items: You can sell any item which is tradable by selecting the item in your inventory and clicking on 'Sell in Marketplace'. You also can use items currently in the Shop.\\\\r\\\\n\\\\r\\\\nNOTE: you can only sell 250 furni at a time.\\\\r\\\\n\\\\r\\\\nRequirements: To sell your Furni in the Marketplace you'll need a Trading Pass, which you can get completing the first steps of the Talent Track.\"]"
            },
            new CatalogPage
            {
                Id = 221,
                Name = "baby_pet_animals",
                Caption = "Baby Pet Animals",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 4,
                OrderId = 2,
                IconId = 228,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"babypets_cata_header\", \"ctlg_babypet_note\"]"
            },
            new CatalogPage
            {
                Id = 222,
                Name = "builders_club",
                Caption = "Builders Club",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 5,
                OrderId = true,
                IconId = 28,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"block_header\", \"ctlg_bclub_note\"]",
                TextsJson =
                    "[\"1 Block... 2 Block... Red Block... Blue Block!\", \"1 Block... 2 Block... Red\\\\r\\\\nBlock... Blue Block!\", \"\\\\r\\\\n\\\\r\\\\nWith dozens of all the colours and patterns to choose from, you can really let your creativity run wild!\\\\r\\\\nExclusive to Builders Club.\"]"
            },
            new CatalogPage
            {
                Id = 223,
                Name = "backgrounds",
                Caption = "Backgrounds",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 602,
                OrderId = 5,
                IconId = 206,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_easter14_001\", \"catalog_shal_teaser_da\"]",
                TextsJson = "[\"Set the scene in your room properly with one of these backgrounds.\"]"
            },
            new CatalogPage
            {
                Id = 224,
                Name = "teleports",
                Caption = "Teleports",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 8,
                IconId = 120,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_doors_headline1\", \"catalog_door_a\"]",
                TextsJson =
                    "[\"Beam yourself from one room to another with our space-age teleports. Buy a pair, put one in each room and you've got your own suite! IMPORTANT: teleports are always sold in pairs except for the Random Banzai Teleport.\", \"Click on an item for details.\"]"
            },
            new CatalogPage
            {
                Id = 225,
                Name = "trophies",
                Caption = "Trophies",
                Layout = "trophies",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 11,
                IconId = 221,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"trophies\"]",
                TextsJson =
                    "[\"Everyone's a winner, baby! And now you can reward them all with our fabulous glittering array of bronze, silver and gold trophies.\\\\n\\\\nFirst choose the trophy model by click the arrows. Then select the metal. Type your inscription below and we'll engrave it on the trophy along with your name and today's date.\\\\nRemember - it's permanent!\"]"
            },
            new CatalogPage
            {
                Id = 226,
                Name = "2020_alpine_heights",
                Caption = "2020 - Alpine Heights",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 13,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"easternew\"]",
                TextsJson =
                    "[\"Setting up a campsite along the river, nothing better than nature. Make your perfect campsite today!\", null, null]"
            },
            new CatalogPage
            {
                Id = 227,
                Name = "how_to_play_banzai",
                Caption = "How to Play Banzai",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_battleBanzai_header_en\", \"catalog_battleBanzai_teaser\"]"
            },
            new CatalogPage
            {
                Id = 228,
                Name = "how_to_play_freeze",
                Caption = "How to Play Freeze!",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_freeze_en\", \"ctlg_pet_note\"]",
                TextsJson =
                    "[\"Find out how you can make and host your own Freeze! game by reading the instructions below!\", \"How to play Freeze!\", \"1. Place Tiles and Blocks in your room. Always place blocks on top of tiles! Add Team Gates, a Counter, an Exit Tile and Scoreboards.\\\\n\\\\n2. Ready? Let your friends choose a team. Each team can have up to five players. Then click the Counter\\\\nto start!\\\\n \\\\n3. To place a Snowball, double click on the tile that you are standing on, or double click on a tile next to you. Blow up Blocks for power-ups!\\\\n\\\\n4. Last team standing wins!\\\\n\\\\n\\\\n\\\\n\\\\nRemember: You will be warped to an Exit Tile when you lose all your lives.\"]"
            },
            new CatalogPage
            {
                Id = 229,
                Name = "club_shop",
                Caption = "Club Shop",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 3,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\"]"
            },
            new CatalogPage
            {
                Id = 230,
                Name = "epic_pet",
                Caption = "Epic Pet",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 680,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Once purchased and placed, clicking it will give you a special pet.\"]"
            },
            new CatalogPage
            {
                Id = 231,
                Name = "wall_decorations",
                Caption = "Wall decorations",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 7,
                IconId = 219,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_gallery_headline1\", \"catalog_posters_teaser1\"]",
                TextsJson =
                    "[\"Adorn your walls with wondrous works of art, posters, plaques and wall hangings. The Gallery is bursting with items to suit all tastes, from kitsch to cool, traditional to modern.\"]"
            },
            new CatalogPage
            {
                Id = 232,
                Name = "pterodactyl",
                Caption = "Pterodactyl",
                Layout = "single_bundle",
                RoleId = true,
                CatalogPageId = 277,
                OrderId = 4,
                IconId = 260,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"jurassic15_catalog_header\", \"dino_pets\"]",
                TextsJson =
                    "[\"These pterrific pets have a fierce appearance with long talons and sharp teeth, but their sweet nature always shines through! Ultra laid-back, these 'flying lizards' love nothing more than spending time with their owner, soaring through the Hotel skies and eating their favourite food...the humble kale leaf.\"]"
            },
            new CatalogPage
            {
                Id = 233,
                Name = "room_bundles",
                Caption = "Room Bundles",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 2,
                IconId = 206,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"bundlerooms\"]"
            },
            new CatalogPage
            {
                Id = 234,
                Name = "pet_equipment",
                Caption = "Pet Equipment",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 4,
                OrderId = 3,
                IconId = 226,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 235,
                Name = "monkey_furni",
                Caption = "Monkey Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = 8,
                IconId = 128,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1_en\", \"monkey_catalogue_teaser\"]",
                TextsJson = "[\"Get exclusive Habbo Furni for your very own Pet Monkey!\"]"
            },
            new CatalogPage
            {
                Id = 236,
                Name = "virus_2016_fish_tanks",
                Caption = "Virus - 2016 - Fish Tanks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = 5,
                IconId = 56,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_rares_headline1_br\", \"catalog_limited_teaser_fi\"]"
            },
            new CatalogPage
            {
                Id = 237,
                Name = "2018_rares",
                Caption = "2018 Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 720,
                OrderId = 6,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 238,
                Name = "gnome",
                Caption = "Gnome",
                Layout = "single_bundle",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 200,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_gnomes\", \"catalog_teaser_gnome\"]",
                TextsJson =
                    "[\"Give a Gnome a home. If you do, it will reward you with loads of fun. Watch it sit. Stand. Walk. It can even change states on your furni. Amazing creatures!\"]"
            },
            new CatalogPage
            {
                Id = 239,
                Name = "club_tradable_boxes",
                Caption = "Club Tradable Boxes",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 262,
                OrderId = 4,
                IconId = 99,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"hc2_clubtitle\", \"hcbcboxes\"]",
                TextsJson =
                    "[\"Say hello to tradable HC Boxes! Containing either 14 or 31-day chunks of Habbo Club membership, this type of furni is just perfect for trading\"]"
            },
            new CatalogPage
            {
                Id = 240,
                Name = "2013_love_locks",
                Caption = "2013 - Love Locks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 13,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"valentines_catalog_header\", \"val14_lovelock3\"]",
                TextsJson =
                    "[\"Friendship Padlocks are Furni that show how special your friends are. You and your friend need to be in your room. Put the Padlock in the Room, click 2x on it, and confirm the action. Once closed, your friendship will be saved forever, even if you trade it!\"]"
            },
            new CatalogPage
            {
                Id = 241,
                Name = "2014_l0-v3_machines",
                Caption = "2014 - L0-V3 Machines",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 15,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"valentines_catalog_header\", \"lovelock_s_promo\"]",
                TextsJson = "[\"Put your love to the test! Lock in your Valentine for life with these Machines.\"]"
            },
            new CatalogPage
            {
                Id = 242,
                Name = "saddles",
                Caption = "Saddles",
                Layout = "petcustomization",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = 4,
                IconId = 135,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_saddles_header2_en\", \"sadddles\"]",
                TextsJson =
                    "[\"To use a saddle, place it in a room where you have at least one Horse. Double click the saddle and select what horse you want to ride After placing the saddle you can ride your Horse by clicking on it and selecting 'Ride'.\"]"
            },
            new CatalogPage
            {
                Id = 243,
                Name = "dyes",
                Caption = "Dyes",
                Layout = "petcustomization",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = 5,
                IconId = 133,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_horsedyes_header2_en\", \"dyes\"]",
                TextsJson =
                    "[\"Customize your horse with this selection of hair colours and body types. Each dye can also be added to your room as a piece of furniture. To use a dye place it to your room, double click on it and then select the horse you want to customise.\"]"
            },
            new CatalogPage
            {
                Id = 244,
                Name = "hair_styles",
                Caption = "Hair Styles",
                Layout = "petcustomization",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = 6,
                IconId = 134,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_horsehairstyles2_header_en\", \"hairs\"]",
                TextsJson =
                    "[\"Customize your horse and make him unique with this selection of hair styles.  Each style can also be added to your room as a piece of furniture. To use a hair style place it to your room, double click on it and then select the horse you want to customise.\"]"
            },
            new CatalogPage
            {
                Id = 245,
                Name = "horse_jump",
                Caption = "Horse Jump",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = 7,
                IconId = 226,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_jumping_en\", \"catalog_teaser_horsejump\"]",
                TextsJson =
                    "[\"Take your horse jumping with these new Furni! Build a formidable race course to test your steed and your riding skills and challenge your friends!\"]"
            },
            new CatalogPage
            {
                Id = 246,
                Name = "monster_plants",
                Caption = "Monster Plants",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 4,
                OrderId = 5,
                IconId = 153,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_mopla_01\", \"ctlg_monster_note\"]",
                TextsJson =
                    "[\"Monster Plants can sure be a handful, this page gives you some extra advice on raising and looking after your monsterous brood.\", \"Taking Care Of Your Plant\", \"Your plants need to be tended regularly, or else they die. To ensure a healthy plant tend it every 30 hours\\\\nor so. If it dies, you can use the Revival potion to\\\\nbring it back to life.\\\\nBreeding\\\\nTo breed your plant you have to wait until it's fully\\\\ngrown. Clicking Breed on the menu will show you\\\\nwhat other plants in the room are available to breed\\\\nwith.\"]"
            },
            new CatalogPage
            {
                Id = 247,
                Name = "monster_plant_seeds",
                Caption = "Monster Plant Seeds",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 246,
                OrderId = true,
                IconId = 156,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_mnstrSeeds\", \"quest_teaser_monsterplants\"]",
                TextsJson =
                    "[\"Plant your seeds in your room and tend to keep them alive and healthy. After your plants have matured you can breed your plants to try and get leveled up offspring. Plants can only breed once without using the Rebreeding Potion.\"]"
            },
            new CatalogPage
            {
                Id = 248,
                Name = "monster_plant_potions",
                Caption = "Monster Plant Potions",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 246,
                OrderId = 2,
                IconId = 155,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"monsterplantsprays_header\", \"monsterplantspray_teaser\"]",
                TextsJson =
                    "[\"On this page you'll find everything you need to take care of your plants: Plant Revival for when your plants die. Place potion to room, double click and select the plant you want to revive.\"]"
            },
            new CatalogPage
            {
                Id = 249,
                Name = "wedding",
                Caption = "Wedding",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 81,
                IconId = 238,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_wedding\", \"catalog_teaser_wedding\"]",
                TextsJson =
                    "[\"Now you can celebrate your great day with our wonderful selection of perfect furni for a wedding!\"]"
            },
            new CatalogPage
            {
                Id = 250,
                Name = "exotic_pets_2017",
                Caption = "Exotic Pets - 2017",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = 2,
                IconId = 56,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"habboclub\", \"catalog_hc_teaser\"]"
            },
            new CatalogPage
            {
                Id = 251,
                Name = "cow_box",
                Caption = "Cow Box",
                Layout = "single_bundle",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 270,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\", \"cow_pet2\"]",
                TextsJson =
                    "[\"We're extremely pleased and proud to preent the new cow pet! Get one of 16 different breeds from the Cow Pet box\"]"
            },
            new CatalogPage
            {
                Id = 252,
                Name = "temporary_effects",
                Caption = "Temporary Effects",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 14,
                IconId = 263,
                Enabled = true,
                Visible = false,
                ImagesJson = "[\"avatar_fx_header\", \"catalog_teaser_vikings\"]",
                TextsJson =
                    "[\"Do you need a specific temporary effect for a specific purpose? Well, look no further! Here you can find a limited selection of special temporary effects!\"]"
            },
            new CatalogPage
            {
                Id = 253,
                Name = "music_shop",
                Caption = "Music Shop",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 16,
                IconId = 4,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"music_header\", \"catalog_djshop_teaser1\"]",
                TextsJson =
                    "[\"Let's get loud! Place a Jukebox in your room, add some disks from the 'Habbo Hotel Hits' list below and you're ready to have a dance party!\"]"
            },
            new CatalogPage
            {
                Id = 254,
                Name = "habbo_hotel_hits",
                Caption = "Habbo Hotel Hits",
                Layout = "soundmachine",
                RoleId = true,
                CatalogPageId = 253,
                OrderId = 2,
                IconId = 257,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"hotelhits_catalog_header\", \"hotelhits_teaser\"]"
            },
            new CatalogPage
            {
                Id = 255,
                Name = "staff_wired",
                Caption = "Staff Wired",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 13,
                IconId = 10,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 256,
                Name = "leaderboards",
                Caption = "Leaderboards",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 8,
                IconId = 256,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"wiredleaderboards_catalog_header\", \"wiredleaderboards_teaser\"]",
                TextsJson =
                    "[\"The High Score furni to keep track of scores given in your games and displays them in your room.\", \"Click an item for details\"]"
            },
            new CatalogPage
            {
                Id = 257,
                Name = "palooza_2014",
                Caption = "Palooza - 2014",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 269,
                OrderId = 2,
                IconId = 227,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_teaser_palooza\", \"catalog_teaser_palooza\"]",
                TextsJson =
                    "[\"Create your own stage and outdoor festival area. We've got stages, fencing and even vending machines!\"]"
            },
            new CatalogPage
            {
                Id = 258,
                Name = "azure_rares",
                Caption = "Azure Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 311,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Azure\"]"
            },
            new CatalogPage
            {
                Id = 259,
                Name = "emerald_rares",
                Caption = "Emerald Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 311,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Emerald\"]"
            },
            new CatalogPage
            {
                Id = 260,
                Name = "gift_box_i",
                Caption = "Gift Box I",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 262,
                OrderId = true,
                IconId = 236,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 261,
                Name = "gift_box_ii",
                Caption = "Gift Box II",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 262,
                OrderId = 2,
                IconId = 236,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 262,
                Name = "redeemable_cases",
                Caption = "Redeemable Cases",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = 5,
                IconId = 99,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 263,
                Name = "miss_mix",
                Caption = "Miss Mix",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 39,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 264,
                Name = "boost",
                Caption = "Boost",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 5,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 265,
                Name = "central_music",
                Caption = "Central Music",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 10,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 266,
                Name = "palooza_guitars",
                Caption = "Palooza Guitars",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 13,
                IconId = 227,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_teaser_palooza\", \"catalog_teaser_palooza\"]"
            },
            new CatalogPage
            {
                Id = 267,
                Name = "palooza_spacerent",
                Caption = "Palooza - Spacerent",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 269,
                OrderId = 6,
                IconId = 227,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_teaser_palooza\", \"catalog_teaser_palooza\"]",
                TextsJson =
                    "[\"Create your own stage and outdoor festival area. We've got stages, fencing and even vending machines!\"]"
            },
            new CatalogPage
            {
                Id = 268,
                Name = "2016_rares",
                Caption = "2016 Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 720,
                OrderId = 4,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 269,
                Name = "palooza",
                Caption = "Palooza",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 52,
                IconId = 227,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 270,
                Name = "seasonal_gifts",
                Caption = "Seasonal Gifts",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 11,
                IconId = 90,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 271,
                Name = "2012_clouds",
                Caption = "2012 - Clouds",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 270,
                OrderId = 5,
                IconId = 164,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 272,
                Name = "urban",
                Caption = "Urban",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 77,
                IconId = 32,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"urban_header_en\", \"urban_teaser_en\"]",
                TextsJson =
                    "[\"New York City styled furni range, Urban is perfect for any street, alleyway or road. Rubbish bins, street lights and benches, all the Urban furniture you need!\"]"
            },
            new CatalogPage
            {
                Id = 273,
                Name = "habbo_camera",
                Caption = "Habbo Camera",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"camara2\", \"camara1\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 274,
                Name = "camera_wall_photo",
                Caption = "Camera Wall Photo",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 8,
                IconId = 10,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 275,
                Name = "countdown",
                Caption = "Countdown",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 377,
                OrderId = true,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"newyears\", \"catal_fp_pic5\"]",
                TextsJson = "[\"All these years have gone by, relive them with this furni.\"]"
            },
            new CatalogPage
            {
                Id = 276,
                Name = "palooza_rares",
                Caption = "Palooza Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 9,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 277,
                Name = "pet_animals",
                Caption = "Pet Animals",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 4,
                OrderId = true,
                IconId = 8,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1_en\", \"ctlg_pet_note\"]"
            },
            new CatalogPage
            {
                Id = 278,
                Name = "breeding_boxes",
                Caption = "Breeding Boxes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 4,
                OrderId = 4,
                IconId = 99,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"babypets_cata_header\", \"babypets_teaser\"]",
                TextsJson =
                    "[\"To breed a baby pet, you need to purchase a breeding nest and have two adult pets of the same type.  At least one of the adult pets need to be owned by you. Breeding nest vanishes after breeding is done. Over 20 breeds of each baby pet available, including rare and super rare!\"]"
            },
            new CatalogPage
            {
                Id = 279,
                Name = "jet_set",
                Caption = "Jet Set",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 503,
                OrderId = true,
                IconId = 237,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"jetset_header\", \"jetset_cashcomp2\"]",
                TextsJson =
                    "[\"Are you ready for the launch of the new Jet Set series? We are! Get ready to ride the waves on your yacht or jet ski and just relax in a tropical paradise.\"]"
            },
            new CatalogPage
            {
                Id = 280,
                Name = "habbowood",
                Caption = "Habbowood",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 35,
                IconId = 33,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"habbowood\", \"habbowood_logo\"]",
                TextsJson =
                    "[\"Whether it's a boulevard of stars, a cinema, a theatre, a dressing room or an entire film studio - the Habbowood furni ticks all the stage exit right boxes!\"]"
            },
            new CatalogPage
            {
                Id = 281,
                Name = "area",
                Caption = "Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = true,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"A chunky and sofisticated line for the down-to-earth, It's simplicty is beautful and will add a welcoming charm to every room.\"]"
            },
            new CatalogPage
            {
                Id = 282,
                Name = "country",
                Caption = "Country",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 19,
                IconId = 21,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"country_header1_en_001\", \"country_teaser1\"]"
            },
            new CatalogPage
            {
                Id = 283,
                Name = "black_mode",
                Caption = "Black Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 17,
                OrderId = 2,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 284,
                Name = "beige_mode",
                Caption = "Beige Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 17,
                OrderId = true,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 285,
                Name = "red_mode",
                Caption = "Red Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 17,
                OrderId = 5,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 286,
                Name = "yellow_mode",
                Caption = "Yellow Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 17,
                OrderId = 7,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 287,
                Name = "green_mode",
                Caption = "Green Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 17,
                OrderId = 4,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 288,
                Name = "blue_mode",
                Caption = "Blue Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 17,
                OrderId = 3,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 289,
                Name = "white_mode",
                Caption = "White Mode",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 17,
                OrderId = 6,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_mode_headline1\", \"catalog_mode_teaser1\"]",
                TextsJson =
                    "[\"Steely functionality combined with a sleek designer upholstery. The Habbo who chooses this furniture is a cool urban cat - streetwise, sassy and so slightly untouchable.\"]"
            },
            new CatalogPage
            {
                Id = 290,
                Name = "black_iced",
                Caption = "Black Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 2,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 291,
                Name = "white_iced",
                Caption = "White Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 8,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 292,
                Name = "aquamarine_iced",
                Caption = "Aquamarine Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = true,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 293,
                Name = "pink_iced",
                Caption = "Pink Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 5,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 294,
                Name = "blue_iced",
                Caption = "Blue Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 3,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 295,
                Name = "green_iced",
                Caption = "Green Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 4,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 296,
                Name = "yellow_iced",
                Caption = "Yellow Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 9,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 297,
                Name = "red_iced",
                Caption = "Red Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 7,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 298,
                Name = "purple_iced",
                Caption = "Purple Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 27,
                OrderId = 6,
                IconId = 20,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 299,
                Name = "2014_health_spa",
                Caption = "2014 - Health Spa",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 14,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_spa\", \"catalog_teaser_spa\"]",
                TextsJson =
                    "[\"Sometimes, all you want is a nice relaxing spa day. With this furni line, you can enjoy one with your Valentine!\"]"
            },
            new CatalogPage
            {
                Id = 300,
                Name = "limited_edition_rares",
                Caption = "Limited Edition Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 10,
                IconId = 145,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 301,
                Name = "alvin",
                Caption = "Alvin",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 2,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 302,
                Name = "asian",
                Caption = "Asian",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 9,
                IconId = 15,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_asian_headline1\", \"catalog_asian_teaser1\"]",
                TextsJson =
                    "[\"Ting tong! Ching chong? Ting chong ting, ping ping! I mean uh.. with our authentic Chinese furniture, you can make a beautiful oriental room!\"]"
            },
            new CatalogPage
            {
                Id = 303,
                Name = "bensalem",
                Caption = "Bensalem",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 13,
                IconId = 18,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_lc_headline2_en\", \"catalog_lc_teaser1_en_001\"]",
                TextsJson = "[\"Glub... glub... glub...\"]"
            },
            new CatalogPage
            {
                Id = 304,
                Name = "executive",
                Caption = "Executive",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 700,
                OrderId = 26,
                IconId = 27,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_exe_headline1_en\", \"catalog_exe_teaser_en\"]",
                TextsJson =
                    "[\"For the ultimate business man, the Executive range with its leather seats and Italian coffee is a dream! How about you try the easy lifestyle?\"]"
            },
            new CatalogPage
            {
                Id = 305,
                Name = "chupa_chups",
                Caption = "Chupa Chups",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 13,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 306,
                Name = "windows",
                Caption = "Windows",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 603,
                OrderId = 7,
                IconId = 218,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"ctlg_windows_headline1_en\", \"ctlg_windows_teaser1_en\"]",
                TextsJson =
                    "[\"Let some sunshine in! Our windows come in many styles to give a unique look to your room. Who said your room can't have a view?\"]"
            },
            new CatalogPage
            {
                Id = 307,
                Name = "credit_furni",
                Caption = "Credit Furni",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 125,
                OrderId = 2,
                IconId = 146,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_bank_headline1\", \"credit_exchange\"]",
                TextsJson =
                    "[\"Habbo Exchange is where you can convert your Credits into a tradable currency. You can then use this currency to trade for Furni or just show off your riches in your room.\"]"
            },
            new CatalogPage
            {
                Id = 308,
                Name = "purchase_history",
                Caption = "Purchase History",
                Layout = "recent_purchases",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 50,
                IconId = 258,
                Enabled = false,
                Visible = false,
                ImagesJson = "[\"maquinas\", \"historys\"]"
            },
            new CatalogPage
            {
                Id = 309,
                Name = "dave",
                Caption = "Dave",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 16,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 310,
                Name = "accessories",
                Caption = "Accessories",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 6,
                IconId = 74,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tradeableclothing_teaser\"]",
                TextsJson =
                    "[\"Stay snazzy with this comprehensive collection of shiny accessories. To wear, simply place the new item in your room and double click to bind the oufit clothing to your avatar\"]"
            },
            new CatalogPage
            {
                Id = 311,
                Name = "colourable_rares",
                Caption = "Colourable Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 6,
                IconId = 42,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 312,
                Name = "books_of_knowledge",
                Caption = "Books of Knowledge",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 313,
                Name = "night_at_the_museum_2",
                Caption = "Night At The Museum 2",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 43,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 314,
                Name = "black_area",
                Caption = "Black Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 2,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 315,
                Name = "white_area",
                Caption = "White Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 8,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 316,
                Name = "beige_area",
                Caption = "Beige Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = true,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 317,
                Name = "pink_area",
                Caption = "Pink Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 5,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 318,
                Name = "blue_area",
                Caption = "Blue Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 3,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 319,
                Name = "green_area",
                Caption = "Green Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 4,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 320,
                Name = "yellow_area",
                Caption = "Yellow Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 9,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 321,
                Name = "red_area",
                Caption = "Red Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 7,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 322,
                Name = "purple_area",
                Caption = "Purple Area",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 281,
                OrderId = 6,
                IconId = 14,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_area_headline1\", \"catalog_area_teaser1\"]",
                TextsJson =
                    "[\"Once known as Silo, as of V11 it had two makeovers to make it beautiful. A classic furni line mostly used for offices and throwbacks.\"]"
            },
            new CatalogPage
            {
                Id = 323,
                Name = "football",
                Caption = "Football",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 24,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 324,
                Name = "elisa",
                Caption = "Elisa",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 22,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 325,
                Name = "2019_winter_palace",
                Caption = "2019 - Winter Palace",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 18,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"spromo_xmas19_gen\"]",
                TextsJson =
                    "[\"Time to <i>chill<\\\\/i> out and relax in an icy palace. Just <i>let it go<\\\\/i>, man.\"]"
            },
            new CatalogPage
            {
                Id = 326,
                Name = "2019_log_cabin",
                Caption = "2019 - Log Cabin",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 17,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"spromo_Log_Cabin\"]",
                TextsJson =
                    "[\"Mixing this line with the Winter Cabin Furni, you could make a multi-roomed cozy cabin for you and your friends.\"]"
            },
            new CatalogPage
            {
                Id = 327,
                Name = "v7_rares",
                Caption = "V7 Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 4,
                IconId = 42,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 328,
                Name = "dragon_lamps",
                Caption = "Dragon Lamps",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Dragons\"]"
            },
            new CatalogPage
            {
                Id = 329,
                Name = "fans",
                Caption = "Fans",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Fanss\"]"
            },
            new CatalogPage
            {
                Id = 330,
                Name = "ice_cream_machines",
                Caption = "Ice Cream Machines",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 6,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"IceCream\"]"
            },
            new CatalogPage
            {
                Id = 331,
                Name = "laser_gates",
                Caption = "Laser Gates",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 7,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Lazer\"]"
            },
            new CatalogPage
            {
                Id = 332,
                Name = "marquees",
                Caption = "Marquees",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Marquee\"]"
            },
            new CatalogPage
            {
                Id = 333,
                Name = "monoliths",
                Caption = "Monoliths",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 9,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Mono\"]"
            },
            new CatalogPage
            {
                Id = 334,
                Name = "oriental_screens",
                Caption = "Oriental Screens",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 10,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Oriental\"]"
            },
            new CatalogPage
            {
                Id = 335,
                Name = "pillars",
                Caption = "Pillars",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 10,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Pillars\"]"
            },
            new CatalogPage
            {
                Id = 336,
                Name = "smoke_machines",
                Caption = "Smoke Machines",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 12,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Smokes\"]"
            },
            new CatalogPage
            {
                Id = 337,
                Name = "maroon_rares",
                Caption = "Maroon Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 311,
                OrderId = 3,
                IconId = 77,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"5af5b5_prizepack_3d\"]"
            },
            new CatalogPage
            {
                Id = 338,
                Name = "niko",
                Caption = "Niko",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 44,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_niko_en\", \"catalog_niko_en\"]"
            },
            new CatalogPage
            {
                Id = 339,
                Name = "habbo_mobile_app",
                Caption = "Habbo Mobile App",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 30,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 340,
                Name = "sleeping_bags",
                Caption = "Sleeping Bags",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 348,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\"]"
            },
            new CatalogPage
            {
                Id = 341,
                Name = "one_way_gates",
                Caption = "One Way Gates",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 348,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\"]"
            },
            new CatalogPage
            {
                Id = 342,
                Name = "inflatable_chairs",
                Caption = "Inflatable Chairs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 348,
                OrderId = true,
                IconId = 234,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"inflatable_chairs_cata_header\", \"inflateable_chairs_teaser\"]",
                TextsJson =
                    "[\"They say that these chairs are Suuuuuper soft because of the air that keeps them full, how about buying one and experiencing yourself? Enjoy!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 343,
                Name = "traffic_lights_barriers",
                Caption = "Traffic Lights & Road Barriers",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 348,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"catalog_teaser_traffic_signs\"]"
            },
            new CatalogPage
            {
                Id = 344,
                Name = "miscellaneous",
                Caption = "Miscellaneous",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 348,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\"]"
            },
            new CatalogPage
            {
                Id = 345,
                Name = "collectibles",
                Caption = "Collectibles",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 7,
                IconId = 42,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 346,
                Name = "others",
                Caption = "Others",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 72,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 347,
                Name = "pillows",
                Caption = "Pillows",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 327,
                OrderId = 11,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"rares\", \"Pillows\"]"
            },
            new CatalogPage
            {
                Id = 348,
                Name = "v11_rares",
                Caption = "V11 Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 5,
                IconId = 42,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 349,
                Name = "classics",
                Caption = "Classics",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = true,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", \"For Club Members only!\"]"
            },
            new CatalogPage
            {
                Id = 350,
                Name = "honey",
                Caption = "Honey",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 31,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 351,
                Name = "pepsi",
                Caption = "Pepsi",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 52,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 352,
                Name = "vip",
                Caption = "VIP",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 2,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", \"For Club members only!\"]"
            },
            new CatalogPage
            {
                Id = 353,
                Name = "reebok",
                Caption = "Reebok",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 57,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 354,
                Name = "executive",
                Caption = "Executive",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 4,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", \"For Club members only!\"]"
            },
            new CatalogPage
            {
                Id = 355,
                Name = "alhambra",
                Caption = "Alhambra",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 5,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", \"For Club members only!\"]"
            },
            new CatalogPage
            {
                Id = 356,
                Name = "emojis",
                Caption = "Emojis",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 6,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", \"For Club members only!\"]"
            },
            new CatalogPage
            {
                Id = 357,
                Name = "bling",
                Caption = "Bling",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 7,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", \"For Club members only!\"]"
            },
            new CatalogPage
            {
                Id = 358,
                Name = "zodiac_statues",
                Caption = "Zodiac Statues",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 8,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", \"For Club members only!\"]"
            },
            new CatalogPage
            {
                Id = 359,
                Name = "classic_lounge",
                Caption = "Classic Lounge",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 2,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"classiclounge\"]",
                TextsJson =
                    "[\"The Welcome Lounge is home not only to newer players, but old Habbo originals who come to guide the newer players or just chill with their friends.\"]"
            },
            new CatalogPage
            {
                Id = 360,
                Name = "habburgers",
                Caption = "Habburgers",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 8,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"aug16_classic2_internal\"]"
            },
            new CatalogPage
            {
                Id = 361,
                Name = "battleball",
                Caption = "Battleball",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = true,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"spromo_Blue_BB\"]",
                TextsJson =
                    "[\"The Battleball game was removed from Habbo along with Snowstorm as Sulake decided to concentrate more on improving other parts of the hotel. \"]"
            },
            new CatalogPage
            {
                Id = 362,
                Name = "ice_cafe",
                Caption = "Ice Cafe",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 14,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"classic5_furnis\"]",
                TextsJson =
                    "[\"The Ice Cafe was used a a meeting place in Habbo Experience for Chaplin and his friends.\"]"
            },
            new CatalogPage
            {
                Id = 363,
                Name = "oriental",
                Caption = "Oriental",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 20,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"spromo_Classic_Tea_Room\"]"
            },
            new CatalogPage
            {
                Id = 364,
                Name = "star_lounge",
                Caption = "Star Lounge",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 23,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"spromo_Star_Lounge\"]",
                TextsJson = "[\"While also popular, this room was also used for many Celebrity Visits.\"]"
            },
            new CatalogPage
            {
                Id = 365,
                Name = "club_mammoth",
                Caption = "Club Mammoth",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 3,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"jan18_classic11_internal\"]"
            },
            new CatalogPage
            {
                Id = 366,
                Name = "library",
                Caption = "Library",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 16,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"Library\"]"
            },
            new CatalogPage
            {
                Id = 367,
                Name = "hotel_view",
                Caption = "Hotel View",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 13,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"HotelView\"]",
                TextsJson = "[\"You can now make the Hotel in your own shape with this furni line.\"]"
            },
            new CatalogPage
            {
                Id = 368,
                Name = "icy_rares",
                Caption = "Icy Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 369,
                Name = "lido",
                Caption = "Lido",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 17,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"article_habboreport2\"]"
            },
            new CatalogPage
            {
                Id = 370,
                Name = "picnic",
                Caption = "Picnic",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 21,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"article_habboreport2\"]",
                TextsJson = "[\"Picnic is one of the oldest, still-standing Public Rooms on Habbo.\"]"
            },
            new CatalogPage
            {
                Id = 371,
                Name = "welcome_lounge",
                Caption = "Welcome Lounge",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 26,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"article_habboreport2\"]",
                TextsJson =
                    "[\"This furni is from the second version of the Welcome Lounge; the first after moving from Shockwave to Flash.\"]"
            },
            new CatalogPage
            {
                Id = 372,
                Name = "seasonal_furni_lines",
                Caption = "Seasonal Furni Lines",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 5,
                OrderId = 4,
                IconId = 195,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 373,
                Name = "christmas",
                Caption = "Christmas",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 372,
                OrderId = true,
                IconId = 168,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"catalog_xmas_teaser\"]"
            },
            new CatalogPage
            {
                Id = 374,
                Name = "easter",
                Caption = "Easter",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 372,
                OrderId = 2,
                IconId = 181,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"catalog_easter_teaser1\"]"
            },
            new CatalogPage
            {
                Id = 375,
                Name = "halloween",
                Caption = "Halloween",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 372,
                OrderId = 4,
                IconId = 34,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"catalog_header_hw15\"]"
            },
            new CatalogPage
            {
                Id = 376,
                Name = "valentines_day",
                Caption = "Valentines Day",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 372,
                OrderId = 3,
                IconId = 62,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 377,
                Name = "new_years",
                Caption = "New Years",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 372,
                OrderId = 5,
                IconId = 91,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 378,
                Name = "classics",
                Caption = "Classics",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = true,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"catalog_easter_teaser1\"]",
                TextsJson =
                    "[\"Little birdies hatching from their eggs, pretty, dainty flowers blooming and cute rabbits bouncing in Spring meadows.. it's Easter!\"]"
            },
            new CatalogPage
            {
                Id = 379,
                Name = "2011_fungi",
                Caption = "2011 - Fungi",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 4,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"easternew\"]",
                TextsJson =
                    "[\"Alongside flowers, sometimes fungi sprouts. While fungi is delicious, it can also be beautiful.\"]"
            },
            new CatalogPage
            {
                Id = 380,
                Name = "2013",
                Caption = "2013",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 5,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"easter13_header\", \"easter13_teaser\"]",
                TextsJson =
                    "[\"This line brings flowers, teleports and a couple of eggs with it. Check out the floral-inspired line below!\"]"
            },
            new CatalogPage
            {
                Id = 381,
                Name = "2014_lagomorph_",
                Caption = "2014 - Lagomorph ",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 6,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_easter14_001\", \"easternew\"]",
                TextsJson =
                    "[\"From shape shifting wall pieces to cryptic teleports, this years Easter furni line is sure to keep you guessing! Nothing is as it seems on this mind-bending island...\"]"
            },
            new CatalogPage
            {
                Id = 382,
                Name = "suunvuoru",
                Caption = "Suunvuoru",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 64,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 383,
                Name = "2017_farm",
                Caption = "2017 - Farm",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 10,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"easternew\"]",
                TextsJson = "[\"With this furni line, you can make your quaint farm full of chickens and snacks!\"]"
            },
            new CatalogPage
            {
                Id = 384,
                Name = "2018_garden",
                Caption = "2018 - Garden",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 11,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"Easter_Garden_promo\"]",
                TextsJson =
                    "[\"Your own little hideaway in the woods, perfected with some curtains and cosy chairs in this furni line!\"]"
            },
            new CatalogPage
            {
                Id = 385,
                Name = "2019_fairytale",
                Caption = "2019 - Fairytale",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 12,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"easter19_new\"]",
                TextsJson = "[\"We're all about fairytales this year! Maybe we should go find Alice?\"]"
            },
            new CatalogPage
            {
                Id = 386,
                Name = "2009_bunny_run",
                Caption = "2009 - Bunny Run",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 2,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"bunny_run\", \"bunnyrun\"]",
                TextsJson = "[\"Make your own game of Bunny Run with the furni here!\"]"
            },
            new CatalogPage
            {
                Id = 387,
                Name = "public_room_furni",
                Caption = "Public Room Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 5,
                OrderId = 2,
                IconId = 264,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 388,
                Name = "classics",
                Caption = "Classics",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = true,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"halloween\", \"catalog_halloween_teaser\"]",
                TextsJson = "[\"Boy, that grave is spooky... Is anybody in that Crypt? Spooky!\"]"
            },
            new CatalogPage
            {
                Id = 389,
                Name = "2008_virus",
                Caption = "2008 - Virus",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 2,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"virus\", \"virus1\"]",
                TextsJson =
                    "[\"A virus is spreading through Habbo Hotel. Many casualties reported and it could get much worse! Whether you are hoping to help infected Habbos or look after number one, get your hands on our terrifying Infection furni.\"]"
            },
            new CatalogPage
            {
                Id = 390,
                Name = "2009_house",
                Caption = "2009 - House",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 3,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_halloween_headline1_en\", \"Ghostly_organ\"]",
                TextsJson = "[\"Who doesn't love a good Haunted House? Creep out your friends with this furni line!\"]"
            },
            new CatalogPage
            {
                Id = 391,
                Name = "2010_voodoo",
                Caption = "2010 - Voodoo",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 4,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_halloween_headline1_en\", \"spromo_hw15_b2\"]",
                TextsJson =
                    "[\"WooOOOOooOOoo! Spooky! Don't wanna be left alone with this range at night.. who knows what could happen!\"]"
            },
            new CatalogPage
            {
                Id = 392,
                Name = "2011_party",
                Caption = "2011 - Party",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 5,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"halloween\", \"spromo_pumpkinpack\"]",
                TextsJson =
                    "[\"Looking for a frightastical room? Well, this is the place to be! We have everything you need to spook your friends this Halloween!\"]"
            },
            new CatalogPage
            {
                Id = 393,
                Name = "2012_carnival",
                Caption = "2012 - Carnival",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 6,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"halloween\", \"hween_12_furni\"]",
                TextsJson =
                    "[\"Carnivals are already creepy, but our Halloween Carnivale furni will really max out the creep factor!\"]"
            },
            new CatalogPage
            {
                Id = 394,
                Name = "2013_frightful",
                Caption = "2013 - Frightful",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 7,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"halloween\", \"hween13_roombundle\"]",
                TextsJson =
                    "[\"Now you can spook up your castle for Halloween! Make sure to add some Demonic Sheep for the full effect.\"]"
            },
            new CatalogPage
            {
                Id = 395,
                Name = "2014_day_of_the_dead",
                Caption = "2014 - Day of the Dead",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 8,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"hween14_catalog_header\", \"hween14_catalog_teaser\"]",
                TextsJson =
                    "[\"Spooky skulls, bright flowers and traditional altars fill this furni line! Gather your friends and family and come together to celebrate the Habbos of the past.\"]"
            },
            new CatalogPage
            {
                Id = 396,
                Name = "2015_habbocalypse",
                Caption = "2015 - Habbocalypse",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 9,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_halloween_headline1_en\", \"habbocalypse\"]",
                TextsJson =
                    "[\"Darkness and evil is spreading through the hotel and you're one of the ONLY Habbos that can fight the bad energy! Dodge Evil Frank, avoid dark shadowy places and make it your mission to save Habbo Hotel from complete and TOTAL annihilation!\"]"
            },
            new CatalogPage
            {
                Id = 397,
                Name = "2016_ghost_hunter",
                Caption = "2016 - Ghost Hunter",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 10,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"halloween\", \"spromo_hween16_new_furni\"]",
                TextsJson =
                    "[\"Spooky lobbies, hotel rooms and libraries. Or, not spooky! Use the Purification Device and use powder to purify the furni.\"]"
            },
            new CatalogPage
            {
                Id = 398,
                Name = "2017_cursed_caves",
                Caption = "2017 - Cursed Caves",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 11,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"halloween\", \"spromo_hween17_gen1\"]",
                TextsJson = "[\"Build your own dungeon, you filthy little Habbo.\"]"
            },
            new CatalogPage
            {
                Id = 399,
                Name = "2018_laboratory",
                Caption = "2018 - Laboratory",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 12,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_halloween_headline1_en\", \"Infected_Laboratory\"]",
                TextsJson =
                    "[\"If you're not a mad scientist, then what kind of scientist are you? Create your perfect laboratory here!\"]"
            },
            new CatalogPage
            {
                Id = 400,
                Name = "2015_candyland",
                Caption = "2015 - Candyland",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 7,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"easternew\"]",
                TextsJson =
                    "[\"Have you ever wanted a room filled with edible furniture? Of course you have! And now you can build it!\"]"
            },
            new CatalogPage
            {
                Id = 401,
                Name = "2010_flower_power",
                Caption = "2010 - Flower Power",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 3,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"easter10_teaser\"]",
                TextsJson =
                    "[\"Flowers look and smell great, and can brighten any room. Use this furni to decorate all kinds of rooms!\"]"
            },
            new CatalogPage
            {
                Id = 402,
                Name = "summer",
                Caption = "Summer",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 372,
                OrderId = 6,
                IconId = 274,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 403,
                Name = "2010_big_wave",
                Caption = "2010 - Big Wave",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 402,
                OrderId = 5,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"summer\", \"summer_teaser\"]",
                TextsJson = "[\"Even more floats! Make your pool party perfect with some inflatables.\"]"
            },
            new CatalogPage
            {
                Id = 404,
                Name = "coco",
                Caption = "Coco",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 17,
                IconId = 127,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_teaser_coco\", \"coconew\"]",
                TextsJson =
                    "[\"Wooden yet comfortable furniture that wouldn't look out of place in a treetop house!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 405,
                Name = "2007",
                Caption = "2007",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 402,
                OrderId = true,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"summer\", \"summer_teaser\"]",
                TextsJson = "[\"Relax by the beach with these chairs and BBQs!\"]"
            },
            new CatalogPage
            {
                Id = 406,
                Name = "2009",
                Caption = "2009",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 402,
                OrderId = 4,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"summer\", \"summer_teaser\"]",
                TextsJson = "[\"Add to your beach party with an ice box and some floats.\"]"
            },
            new CatalogPage
            {
                Id = 407,
                Name = "2011",
                Caption = "2011",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 402,
                OrderId = 6,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"summer\", \"summer_teaser\"]",
                TextsJson = "[\"A bonfire on the beach with some Habbo tunes, nothing beats it.\"]"
            },
            new CatalogPage
            {
                Id = 408,
                Name = "2008_tiki",
                Caption = "2008 - Tiki",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 402,
                OrderId = 3,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_tiki_header1_en\", \"tiki_teaser\"]",
                TextsJson =
                    "[\"Imagine the scene.. lost on a desert island when you stumble across a small local tribe.. now you can with our Tiki range!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 409,
                Name = "2017",
                Caption = "2017",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 402,
                OrderId = 8,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"summer\", \"summer_teaser\"]",
                TextsJson = "[\"A burger and some shades are all you need to explore a beach town!\"]"
            },
            new CatalogPage
            {
                Id = 410,
                Name = "new_year_accessories",
                Caption = "New Year Accessories",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 7,
                IconId = 42,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"494f9e19e78d \"]"
            },
            new CatalogPage
            {
                Id = 411,
                Name = "monster_plant_furni",
                Caption = "Monster Plant Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 47,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_mopla_01\", \"quest_teaser_monsterplants\"]",
                TextsJson =
                    "[\"On this page you'll find everything you need to take care of your plants: Plant Revival for when your plants die. Place potion to room, double click and select the plant you want to revive.\"]"
            },
            new CatalogPage
            {
                Id = 412,
                Name = "snowboarding",
                Caption = "Snowboarding",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 7,
                IconId = 140,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"snowboarding_catalog_02\", \"catalog_snowboarding_teaser1\"]",
                TextsJson =
                    "[\"Step on the patch an you'll be automatically strapped to a Snowboard - like magic! The Snowboard Patch can be adjust to 9 different heights for you to build your own amazing slopes!\"]"
            },
            new CatalogPage
            {
                Id = 413,
                Name = "ice_hockey",
                Caption = "Ice Hockey",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 8,
                IconId = 88,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_tag_general_1\", \"catalog_teaser_xm10_skate\"]",
                TextsJson =
                    "[\"WHAT THE PUCK?! How Habbos play ice hocket? you can use your imagination and play and win the World Championship. Go for it!\"]"
            },
            new CatalogPage
            {
                Id = 414,
                Name = "snow_war",
                Caption = "Snow War",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 125,
                OrderId = 12,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_rollerskates_header\", \"catalog_teaser_rollerblades\"]",
                TextsJson =
                    "[\"Furni from the good ol' classic, Snowstorm. It might not be functional, but it can make some nice decoration!\"]"
            },
            new CatalogPage
            {
                Id = 415,
                Name = "ice_tag",
                Caption = "Ice Tag",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 10,
                IconId = 86,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_tag_general_2\", \"catalog_teaser_xm10_skate\"]",
                TextsJson =
                    "[\"The fun is ON with our new game! Skate on ice and play Tag with your friends using the new Tag Pole and Ice Skating Patch! Not sure how to put on your skates? Step on an Ice Patch and you're good to go.\"]"
            },
            new CatalogPage
            {
                Id = 416,
                Name = "santorini",
                Caption = "Santorini",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 63,
                IconId = 273,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"teaser_santorini\"]",
                TextsJson = "[\"Straight from the country of Greece.. Right here at Habbo.\"]"
            },
            new CatalogPage
            {
                Id = 417,
                Name = "summer_bazaar",
                Caption = "Summer Bazaar",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 69,
                IconId = 275,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"bazaar_new\"]",
                TextsJson =
                    "[\"New, colourful and inspired by Arabian luxury, shop around and find some things for your own market!\"]"
            },
            new CatalogPage
            {
                Id = 418,
                Name = "pastel",
                Caption = "Pastel",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 54,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Cute and funny, just like you!\"]"
            },
            new CatalogPage
            {
                Id = 419,
                Name = "modern_studio",
                Caption = "Modern Studio",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 46,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"feature_cata_hort_modernapt17\", \"extra1\"]",
                TextsJson =
                    "[\"Modern Studio Furni! You asked for it... We added it! Have fun in your new Studio Apartments!\"]"
            },
            new CatalogPage
            {
                Id = 420,
                Name = "crackables",
                Caption = "Crackables",
                Layout = "pets",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 5,
                IconId = 10,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[null, \"<b>Crackables<\\\\/b>\", \"Contains all bonus bags, campaign crackables and all the prizes. Use the items_crackable table to match the crackables to the exact prizes.\", \"WARNING: Pages could be slow loading due to number of items. All rewards can be found in the `prizes` column in the `items_crackable` table.\"]"
            },
            new CatalogPage
            {
                Id = 421,
                Name = "sound_fx",
                Caption = "Sound FX",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 7,
                IconId = 4,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_wired_header1\", \"wiredsound_teaser\"]",
                TextsJson =
                    "[\"Create your own beats and tracks by combinign these sound FX in your room. Throw a concert for your friends or even start a band in Habbo!\"]"
            },
            new CatalogPage
            {
                Id = 422,
                Name = "pro_gamer",
                Caption = "Pro Gamer",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 58,
                IconId = 202,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Many people have heard of Legend of Selda, but what about Hario and Wuigi?\"]"
            },
            new CatalogPage
            {
                Id = 423,
                Name = "effects",
                Caption = "Effects",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 13,
                IconId = 61,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"avatar_fx_header\", \"permeffects_teaser\"]",
                TextsJson =
                    "[\"ALL NEW Permanent effects are here! Sick of purchasing effects multiple times? Want to keep effects forever? Want to trade your way to the top of the effects kingdom? Well then, Permanent effects are for you!\"]"
            },
            new CatalogPage
            {
                Id = 424,
                Name = "coral_kingdom",
                Caption = "Coral Kingdom",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 18,
                IconId = 280,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_shells_header\", \"coralking18_gen\"]",
                TextsJson =
                    "[\"It's here! The all new Coral Kingdom furni line is in the Catalogue. Build your own version of Atlantis in Habbo TODAY!\"]"
            },
            new CatalogPage
            {
                Id = 425,
                Name = "basement_band_kit",
                Caption = "Basement Band Kit",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 12,
                IconId = 257,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"music_header\", \"march19_new\"]",
                TextsJson =
                    "[\"Everything you need to start your own basement band is right here. Three collectible 'Basement Band' instruments are availabe in the Catalogue NOW!\"]"
            },
            new CatalogPage
            {
                Id = 426,
                Name = "leprechaun",
                Caption = "Leprechaun",
                Layout = "single_bundle",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 212,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_pet_headline1\", \"catalog_teaser_lepr\"]",
                TextsJson =
                    "[\"For a limited time...the St Patrick's Day Leprechaun is here! This Irish mischeif-maker is sure to brighten your day. From his quirky sayings to his habit of breaking things... You are going to love him! Includes an AWESOME Badge.\"]"
            },
            new CatalogPage
            {
                Id = 427,
                Name = "danish_hygge_furni",
                Caption = "Danish Hygge Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 21,
                IconId = 283,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"nov18_hyggeline\"]",
                TextsJson =
                    "[\"Walk through the door and sink into a warm pool of comfort and well-being with this Hygge furnis.\", \"Choose a furni.\"]"
            },
            new CatalogPage
            {
                Id = 428,
                Name = "tokyo",
                Caption = "Tokyo",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 72,
                IconId = 281,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"japan_header_br\", \"tokyo18_gen\"]",
                TextsJson = "[\"Enjoy the awesome new Tokyo-inspired furni line we've released. Subarashii!\"]"
            },
            new CatalogPage
            {
                Id = 429,
                Name = "testing",
                Caption = "Testing",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 12,
                IconId = 10,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 430,
                Name = "pride_furni",
                Caption = "Pride Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 56,
                IconId = 286,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"rbow19_gen\"]",
                TextsJson =
                    "[\"To celebrate Pride in Habbo, we're releasing a set of rainbow-coloured bedroom furni for you all!\"]"
            },
            new CatalogPage
            {
                Id = 431,
                Name = "sea_shell_gifts",
                Caption = "Sea Shell Gifts",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 270,
                OrderId = true,
                IconId = 280,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_shells_header\", \"shellgifts\"]",
                TextsJson = "[\"Use your Shells to buy these limited Gifts!\"]"
            },
            new CatalogPage
            {
                Id = 432,
                Name = "greek_2019",
                Caption = "Greek - 2019",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 216,
                OrderId = 34,
                IconId = 31,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"greek_header\", \"greek_catateaser\"]",
                TextsJson =
                    "[\"Be transported back to ancient Greece with a couple of thousand pounds and British Airways. Until then, build your own pantheon with our realistic Greek range!\"]"
            },
            new CatalogPage
            {
                Id = 433,
                Name = "celestial",
                Caption = "Celestial",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 16,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Fly among the stars with this universally loved Furni Line.\"]"
            },
            new CatalogPage
            {
                Id = 434,
                Name = "zen_garden",
                Caption = "Zen Garden",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 84,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"sep18_classic14_internal\"]",
                TextsJson = "[\"It's time to dive into a metaphorical pool of psychological solitude.\"]"
            },
            new CatalogPage
            {
                Id = 435,
                Name = "sunlight_city",
                Caption = "Sunlight City",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 70,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"suncity19_newfurni\"]",
                TextsJson = "[\"Build the utopian paradise of your dreams with our new furni line: Sunlight City!\"]"
            },
            new CatalogPage
            {
                Id = 436,
                Name = "coffee_house",
                Caption = "Coffee House",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 5,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]"
            },
            new CatalogPage
            {
                Id = 437,
                Name = "hallway",
                Caption = "Hallway",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 10,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Hallways have been featured in Habbo since very early versions.\"]"
            },
            new CatalogPage
            {
                Id = 438,
                Name = "theatre",
                Caption = "Theatre",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 24,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Another old and well-known room, this is the 4th revision of the Theatre.\"]"
            },
            new CatalogPage
            {
                Id = 439,
                Name = "welcome_lounge_modern",
                Caption = "Welcome Lounge - Modern",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 27,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"At points on some hotels, another one or two Welcome Lounges had to be added to cope with high traffic.\"]"
            },
            new CatalogPage
            {
                Id = 440,
                Name = "hc_lounge",
                Caption = "HC Lounge",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 11,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson = "[\"The bartender bot was called HankCupp, and the DJ bot called djDucketz.\"]"
            },
            new CatalogPage
            {
                Id = 441,
                Name = "franks_room",
                Caption = "Franks Room",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 6,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Frank has been the mascot of Habbo for many, many years.\"]"
            },
            new CatalogPage
            {
                Id = 442,
                Name = "ad_sales",
                Caption = "Ad Sales",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 9,
                IconId = 10,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 443,
                Name = "2016_vikings_v_pirates",
                Caption = "2016 - Vikings v Pirates",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 374,
                OrderId = 9,
                IconId = 181,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_easter_headline1\", \"easternew\"]",
                TextsJson =
                    "[\"Complete your Viking village with the Blacksmith Hut, or hoist the sails with your Smuggler's Lookout!\"]"
            },
            new CatalogPage
            {
                Id = 444,
                Name = "hospital",
                Caption = "Hospital",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 36,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hospital\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"Everybody gets sick, it might be time to open a Hospital in Habbo. Get started with some Hospital beds!\"]"
            },
            new CatalogPage
            {
                Id = 445,
                Name = "classics",
                Caption = "Classics",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = true,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12_2_en\", \"catalog_love_teaser1\"]",
                TextsJson =
                    "[\"Love is in the air! Buy your sweetheart a rose or whisper sweet nothings in their ear on a lova sofa. Can you feel it?\"]"
            },
            new CatalogPage
            {
                Id = 446,
                Name = "2012_prom",
                Caption = "2012 - Prom",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 10,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"valentin2012-1\", \"catalog_love_teaser1\"]",
                TextsJson =
                    "[\"Prom is full of crying teens and bad dance moves, but it's always a fond memory for many. Create your perfect prom with this furni!\"]"
            },
            new CatalogPage
            {
                Id = 447,
                Name = "2012_getaway",
                Caption = "2012 - Getaway",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 9,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Valentines_header\", \"catalog_love_teaser1\"]",
                TextsJson =
                    "[\"Even plants can find love, and share alongside Habbos. Put your love to the test with the Love Thermometer and Kissing Booth!\"]"
            },
            new CatalogPage
            {
                Id = 448,
                Name = "2019_restaurant",
                Caption = "2019 - Restaurant",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 21,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12_2_en\", \"val19_newfurni\"]",
                TextsJson = "[\"Perfect for a romantic evening with your loved one.\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 449,
                Name = "2017_wedding",
                Caption = "2017 - Wedding",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 19,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12\", \"catalog_love_teaser1\"]",
                TextsJson = "[\"Do I hear wedding bells? The perfect outdoor setting awaits!\"]"
            },
            new CatalogPage
            {
                Id = 450,
                Name = "2013_masquerade_ball",
                Caption = "2013 - Masquerade Ball",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 12,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12_2_en\", \"valentines_catalog_teaser\"]",
                TextsJson = "[\"With a smell of flowers and love, use this furni to make your perfect garden party.\"]"
            },
            new CatalogPage
            {
                Id = 451,
                Name = "kelloggs",
                Caption = "Kelloggs",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 34,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 452,
                Name = "2010_heartbreak_hotel",
                Caption = "2010 - Heartbreak Hotel",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 6,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12_2_en\", \"catalog_love_teaser1\"]",
                TextsJson =
                    "[\"A gift basket and a cuddly teddy for your Valentine, and some cozy seats for your date.\"]"
            },
            new CatalogPage
            {
                Id = 453,
                Name = "2008_habborella",
                Caption = "2008 - Habborella",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 2,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_val_headline1_en\", \"valentine_furni_001\"]",
                TextsJson =
                    "[\"Find your true love with the Love Randomiser, and how better to celebrate than with a box of chocolates?\"]"
            },
            new CatalogPage
            {
                Id = 454,
                Name = "2013_gondolas",
                Caption = "2013 - Gondolas",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 11,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12\", \"catalog_love_teaser1\"]",
                TextsJson = "[\"Gondola rides in Venice, it doesn't get much more romantic than that!\"]"
            },
            new CatalogPage
            {
                Id = 455,
                Name = "2014_white_bling",
                Caption = "2014 - White Bling",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 16,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12\", \"catalog_love_teaser1\"]",
                TextsJson =
                    "[\"Did someone speak in glamour? Chic? Lux? So you're speaking the language of Bonnie Blonde, my friend! Now in white!\"]"
            },
            new CatalogPage
            {
                Id = 456,
                Name = "2015_ancient_japan",
                Caption = "2015 - Ancient Japan",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 17,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"val15_cata_header\", \"val15_teaser\"]",
                TextsJson = "[\"Have a beautiful Picnic under a Sakura tree in Japan, with this Valentines line!\"]"
            },
            new CatalogPage
            {
                Id = 457,
                Name = "2016_carnivale",
                Caption = "2016 - Carnivale",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 18,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12\", \"catalog_love_teaser1\"]",
                TextsJson = "[\"Cute kitties and some beautiful furni ornaments to perfect your romantic room.\"]"
            },
            new CatalogPage
            {
                Id = 458,
                Name = "2018_bedroom",
                Caption = "2018 - Bedroom",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 20,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12\", \"catalog_love_teaser1\"]",
                TextsJson =
                    "[\"If you want to stay in bed for Valentines, I don't blame you! This is the furni line for you!\"]"
            },
            new CatalogPage
            {
                Id = 459,
                Name = "2011_hearts",
                Caption = "2011 - Hearts",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 270,
                OrderId = 3,
                IconId = 53,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 460,
                Name = "2011_rollerskating",
                Caption = "2011 - Rollerskating",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 8,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12_2_en\", \"catalog_love_teaser1\"]",
                TextsJson = "[\"What better way to spend Valentines, than clinging to your Valentine as you skate?\"]"
            },
            new CatalogPage
            {
                Id = 461,
                Name = "jaapuisto",
                Caption = "Jaapuisto",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 33,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 462,
                Name = "volkswagen",
                Caption = "Volkswagen",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 69,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 463,
                Name = "super_saver_subscription",
                Caption = "2011 - Super Saver Subscription",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 270,
                OrderId = 4,
                IconId = 124,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 464,
                Name = "2008",
                Caption = "2008",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 402,
                OrderId = 2,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"summer\", \"catalog_teaser_beach_furni\"]",
                TextsJson = "[\"Who hasn't dreamt of making a sandcastle they fit in? Now you can!\"]"
            },
            new CatalogPage
            {
                Id = 465,
                Name = "sports_rares",
                Caption = "Sports Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 15,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 466,
                Name = "sticky_notes",
                Caption = "Sticky Notes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 506,
                OrderId = false,
                IconId = 210,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"ctlg_pic_a2_slp\"]"
            },
            new CatalogPage
            {
                Id = 467,
                Name = "school",
                Caption = "School",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 64,
                IconId = 130,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"ruletheschool_header\", \"catalog_school_teaser\"]",
                TextsJson =
                    "[\"Sick of being told what to do? Want to be the boss of someone else for a change? Well now you can with our very own school range!\"]"
            },
            new CatalogPage
            {
                Id = 468,
                Name = "2012_china_town",
                Caption = "2012 - China Town",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 377,
                OrderId = 4,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"cny_header\", \"cny_teaser\"]",
                TextsJson = "[\"Celebrating all cultures is important for Habbos to get along!\"]"
            },
            new CatalogPage
            {
                Id = 469,
                Name = "2010",
                Caption = "2010",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 377,
                OrderId = 2,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"newyears\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Explosions and wavers, what a way to celebrate the first year without Bush.\"]"
            },
            new CatalogPage
            {
                Id = 470,
                Name = "2011",
                Caption = "2011",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 377,
                OrderId = 3,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_year2011_en\", \"catalog_teaser_year2011\"]",
                TextsJson =
                    "[\"A great way to celebrate the repeal of the Don't Ask, Don't Tell policy. Oh, and the New Year!\"]"
            },
            new CatalogPage
            {
                Id = 471,
                Name = "2013",
                Caption = "2013",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 377,
                OrderId = 5,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"newyears\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Make your New Years Resolution under the sparkling lights of this furni line.\"]"
            },
            new CatalogPage
            {
                Id = 472,
                Name = "2015",
                Caption = "2015",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 377,
                OrderId = 6,
                IconId = 274,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"newyears\", \"ny_comeback\"]",
                TextsJson = "[\"A classic party with bubbly and cupcakes, fun for the whole family.\"]"
            },
            new CatalogPage
            {
                Id = 473,
                Name = "classics",
                Caption = "Classics",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = false,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"catalog_xmas_teaser\"]",
                TextsJson =
                    "[\"Christmas trees, poinsettas, and decorations. Back to the good old classic Christmas furni!\"]"
            },
            new CatalogPage
            {
                Id = 474,
                Name = "on_tour",
                Caption = "On Tour",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 48,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 475,
                Name = "2008_arctic",
                Caption = "2008 - Arctic",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 2,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_arc_header1_en\", \"catalog_arc_teaser1_en\"]",
                TextsJson = "[\"It's a very cold winter this year, don't slip while building your own icy fortress!\"]"
            },
            new CatalogPage
            {
                Id = 476,
                Name = "2009",
                Caption = "2009",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 4,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"xmas2009_catalogue\"]",
                TextsJson =
                    "[\"Get yourself into the Christmas spirit with our selection of festive furni! From baubles to snow-Habbos, we've got it all!\"]"
            },
            new CatalogPage
            {
                Id = 477,
                Name = "2010_city",
                Caption = "2010 - City",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 5,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\"]",
                TextsJson = "[\"The city is shining with the snow covering everything. Build your own high-street!\"]"
            },
            new CatalogPage
            {
                Id = 478,
                Name = "2010_snowflakes",
                Caption = "2010 - Snowflakes",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 270,
                OrderId = 2,
                IconId = 86,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\"]"
            },
            new CatalogPage
            {
                Id = 479,
                Name = "2011_winter_cabin",
                Caption = "2011 - Winter Cabin",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 7,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"xmas11_catalog_teaser_01\"]",
                TextsJson = "[\"Keep yourself nice and toasty in a perfect cabin of your design.\"]"
            },
            new CatalogPage
            {
                Id = 480,
                Name = "2011_gift_items",
                Caption = "2011 - Gift Items",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 6,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"xmas11_catalog_teaser_01\"]",
                TextsJson = "[\"Get your closest friend some gifts with these shiny new toys and accessories.\"]"
            },
            new CatalogPage
            {
                Id = 481,
                Name = "2012_castles",
                Caption = "2012 - Castles",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 8,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"xmas_furni4\"]",
                TextsJson =
                    "[\"Santa may be a slave to all the children of the world, but he still deserves a castle.\"]"
            },
            new CatalogPage
            {
                Id = 482,
                Name = "2013_snowflakes",
                Caption = "2013 - Snowflakes",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 270,
                OrderId = 7,
                IconId = 86,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"catalog_teaser_xmas2013\"]"
            },
            new CatalogPage
            {
                Id = 483,
                Name = "2013_santa's_workshop",
                Caption = "2013 - Santa's Workshop",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 9,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"catalog_teaser_xmas2013\"]",
                TextsJson =
                    "[\"Santa needs time to come up with all the gift ideas, and his little helpers copy his blueprints. Here you can create his workshop!\"]"
            },
            new CatalogPage
            {
                Id = 484,
                Name = "2014_tropical",
                Caption = "2014 - Tropical",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 10,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"xmas14_newfurni_spromo_teaser\"]",
                TextsJson = "[\"Wacky, wavy, inflatable, arm flailing tubemen! Party on for this hot Christmas.\"]"
            },
            new CatalogPage
            {
                Id = 485,
                Name = "2015_bavarian",
                Caption = "2015 - Bavarian",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 11,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"xmas15_tease\"]",
                TextsJson =
                    "[\"Christmas markets are always buzzing, in tiny little villages and large cities. Would you plan it differently?\"]"
            },
            new CatalogPage
            {
                Id = 486,
                Name = "2016_citadel",
                Caption = "2016 - Citadel",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 14,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"xmas16_gen1\"]",
                TextsJson =
                    "[\"Even Santa's elves need to relax every now and then, and we found the furni they use for their relaxation!\"]"
            },
            new CatalogPage
            {
                Id = 487,
                Name = "2017_victorian",
                Caption = "2017 - Victorian",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 15,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"spromo_adventxmas17\"]",
                TextsJson =
                    "[\"More shopping, less markets. Big corporations ruined the Christmas markets; but at least they sell less of the same product for a higher price!\"]"
            },
            new CatalogPage
            {
                Id = 488,
                Name = "2018_city_festival",
                Caption = "2018 - City Festival",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 373,
                OrderId = 16,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\", \"Winter_City_Festival\"]",
                TextsJson = "[\"Make a beautiful Twinkly Stage and show off your Matryoshka Dolls!\"]"
            },
            new CatalogPage
            {
                Id = 489,
                Name = "wwe",
                Caption = "WWE",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 70,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 490,
                Name = "hippo_statues",
                Caption = "Hippo Statues",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Spromo_Bonus_Bags\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 491,
                Name = "diamond_paintings",
                Caption = "Diamond Paintings",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 125,
                OrderId = 5,
                IconId = 92,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 492,
                Name = "merge_compensation",
                Caption = "Merge Compensation",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = 3,
                IconId = 56,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 493,
                Name = "habbo_stories_winners",
                Caption = "HABBO STORIES HERO POEM WINNERS",
                Layout = "trophies",
                RoleId = true,
                CatalogPageId = 506,
                OrderId = 3,
                IconId = 210,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 494,
                Name = "heroic_acts_certificate",
                Caption = "Heroic Acts Certificate",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 506,
                OrderId = 4,
                IconId = 210,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 495,
                Name = "builder's_club_birthday",
                Caption = "Builder's Club Birthday",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 7,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 496,
                Name = "pacha",
                Caption = "Pacha",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 50,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 497,
                Name = "the_lost_world",
                Caption = "The Lost World",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = 4,
                IconId = 56,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 498,
                Name = "ecotron",
                Caption = "Ecotron",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = 4,
                IconId = 163,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 499,
                Name = "ecotron_rewards_ii",
                Caption = "Ecotron Rewards II",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 498,
                OrderId = 2,
                IconId = 163,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 500,
                Name = "ecotron_rewards_i",
                Caption = "Ecotron Rewards I",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 498,
                OrderId = true,
                IconId = 163,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 501,
                Name = "laundry",
                Caption = "Laundry",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 42,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"game_shop_header\", \"may18_house2_internal\"]",
                TextsJson = "[\"Kick back and play some games while your clothes wash!\"]"
            },
            new CatalogPage
            {
                Id = 502,
                Name = "white_plasto",
                Caption = "White Plasto",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 511,
                OrderId = 6,
                IconId = 46,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"plastic\", \"plastic_pasic_promo_1\"]",
                TextsJson =
                    "[\"Throw on an afro and grab a disco ball! Feel that retro, 1970s vibe? You soon will with this colourful, plastic range! Choose a colour to suit your mood and off you go!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 503,
                Name = "jet_set",
                Caption = "Jet Set",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 39,
                IconId = 237,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"jetset_header\", \"jetset_yachtcomp\"]",
                TextsJson =
                    "[\"Live life to the fullest with our Jetset furni range. This is the Furni for those Habbos who like to throw obscenely huge parties and show off their style.\"]"
            },
            new CatalogPage
            {
                Id = 504,
                Name = "2008_penguins",
                Caption = "2008 - Penguins",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 125,
                OrderId = 2,
                IconId = 168,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_xmas2013\"]"
            },
            new CatalogPage
            {
                Id = 505,
                Name = "jet_set_2016",
                Caption = "Jet Set - 2016",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 503,
                OrderId = 2,
                IconId = 265,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"JETSET\", \"jetset_yachtcomp\"]"
            },
            new CatalogPage
            {
                Id = 506,
                Name = "habbo_stories",
                Caption = "Habbo Stories",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = 7,
                IconId = 210,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 507,
                Name = "shakespeare",
                Caption = "Shakespeare",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 506,
                OrderId = 5,
                IconId = 210,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 508,
                Name = "vintage_music",
                Caption = "Vintage Music",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 506,
                OrderId = 6,
                IconId = 210,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 509,
                Name = "boarding_school",
                Caption = "Boarding School",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 506,
                OrderId = true,
                IconId = 210,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 510,
                Name = "football",
                Caption = "Football",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 506,
                OrderId = 2,
                IconId = 210,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 511,
                Name = "plasto",
                Caption = "Plasto",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 8,
                IconId = 46,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"plastic\", \"plastic_pasic_promo_1\"]",
                TextsJson =
                    "[\"Throw on an afro and grab a disco ball! Feel that retro, 1970s vibe? You soon will with this colourful, plastic range! Choose a colour to suit your mood and off you go!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 512,
                Name = "rainbow_plasto",
                Caption = "Rainbow Plasto",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 12,
                IconId = 46,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"plastic\", \"plastic_pasic_promo_1\"]",
                TextsJson =
                    "[\"Throw on an afro and grab a disco ball! Feel that retro, 1970s vibe? You soon will with this colourful, plastic range! Choose a colour to suit your mood and off you go!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 513,
                Name = "black_plasto",
                Caption = "Black Plasto",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 511,
                OrderId = 2,
                IconId = 46,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"plastic\", \"plastic_pasic_promo_1\"]",
                TextsJson =
                    "[\"Throw on an afro and grab a disco ball! Feel that retro, 1970s vibe? You soon will with this colourful, plastic range! Choose a colour to suit your mood and off you go!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 514,
                Name = "pink_plasto",
                Caption = "Pink Plasto",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 511,
                OrderId = 4,
                IconId = 158,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"plastic\", \"plastic_pasic_promo_1\"]",
                TextsJson =
                    "[\"Throw on an afro and grab a disco ball! Feel that retro, 1970s vibe? You soon will with this colourful, plastic range! Choose a colour to suit your mood and off you go!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 515,
                Name = "clear_plasto",
                Caption = "Clear Plasto",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 511,
                OrderId = 3,
                IconId = 154,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"plastic\", \"plastic_pasic_promo_1\"]",
                TextsJson =
                    "[\"Throw on an afro and grab a disco ball! Feel that retro, 1970s vibe? You soon will with this colourful, plastic range! Choose a colour to suit your mood and off you go!\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 516,
                Name = "idea_agency",
                Caption = "Idea Agency",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 32,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 517,
                Name = "art",
                Caption = "Art",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 8,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 518,
                Name = "rainy_day",
                Caption = "Rainy Day",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 59,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"spromo_rainy19_gen\"]",
                TextsJson = "[\"You'll never get soaked again.\"]"
            },
            new CatalogPage
            {
                Id = 519,
                Name = "supermarket",
                Caption = "Supermarket",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 71,
                IconId = 213,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Get that last minute shopping in with our supermarket furni!\"]"
            },
            new CatalogPage
            {
                Id = 520,
                Name = "r2",
                Caption = "R2",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 55,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 521,
                Name = "2019_coven",
                Caption = "2019 - Coven",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 375,
                OrderId = 13,
                IconId = 34,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"halloween\", \"catalog_halloween_teaser\"]",
                TextsJson = "[\"We're getting witchy this year! Make your own coven...\"]"
            },
            new CatalogPage
            {
                Id = 522,
                Name = "dessert_cafe",
                Caption = "Dessert Cafe",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 22,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson = "[\"Who loves desserts? If you do, make sure to pick up some of this Dessert Cafe furni!\"]"
            },
            new CatalogPage
            {
                Id = 523,
                Name = "football",
                Caption = "Football",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 6,
                IconId = 56,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_football_001\", \"flags\"]",
                TextsJson =
                    "[\"Whether you call it soccer, football or futbol... you can enjoy the game right here in Habbo! Get a ball and kick it, bounce it, pass it, control it and steal it!\"]"
            },
            new CatalogPage
            {
                Id = 524,
                Name = "spangas_on_survival",
                Caption = "Spangas on Survival",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 58,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 525,
                Name = "bohemian_festival",
                Caption = "Bohemian Festival",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 14,
                IconId = 285,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"Spromo_fest19_gen\"]",
                TextsJson = "[\"It's time for a festival!\"]"
            },
            new CatalogPage
            {
                Id = 526,
                Name = "pixels",
                Caption = "Pixels",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = 6,
                IconId = 5,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 527,
                Name = "nokia",
                Caption = "Nokia",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 45,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 528,
                Name = "nickelodeon",
                Caption = "Nickelodeon",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 42,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 529,
                Name = "ob",
                Caption = "OB",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 47,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 530,
                Name = "mtv",
                Caption = "MTV",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 40,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 531,
                Name = "malaco",
                Caption = "Malaco",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 38,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 532,
                Name = "m6",
                Caption = "M6",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 36,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 533,
                Name = "gs_arcade",
                Caption = "GS Arcade",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 28,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 534,
                Name = "grefusa",
                Caption = "Grefusa",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 27,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 535,
                Name = "clearasil",
                Caption = "Clearasil",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 14,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 536,
                Name = "7-11",
                Caption = "7-11",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = true,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 537,
                Name = "capri_sun",
                Caption = "Capri Sun",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 9,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 538,
                Name = "ditch_the_label",
                Caption = "Ditch The Label",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 18,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 539,
                Name = "tampax",
                Caption = "Tampax",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 65,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 540,
                Name = "netari",
                Caption = "Netari",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 41,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 541,
                Name = "easy_mac",
                Caption = "Easy Mac",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 21,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 542,
                Name = "persy_jackson",
                Caption = "Persy Jackson",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 53,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 543,
                Name = "sunny_delight",
                Caption = "Sunny Delight",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 62,
                IconId = 52,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"calippo_header_es\"]"
            },
            new CatalogPage
            {
                Id = 544,
                Name = "puffet",
                Caption = "Puffet",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 54,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 545,
                Name = "antena_3",
                Caption = "Antena 3",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 4,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 546,
                Name = "chocapic",
                Caption = "Chocapic",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 12,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 547,
                Name = "virtual_piggy_ink",
                Caption = "Virtual Piggy Ink",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 68,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 548,
                Name = "paula",
                Caption = "Paula",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 51,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 549,
                Name = "rango",
                Caption = "Rango",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 56,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 550,
                Name = "frank",
                Caption = "Frank",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 25,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 551,
                Name = "escape_from_madagascar",
                Caption = "Escape From Madagascar",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 23,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 552,
                Name = "coolpolitics",
                Caption = "Coolpolitics",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 15,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 553,
                Name = "cheetos",
                Caption = "Cheetos",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 11,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 554,
                Name = "durex",
                Caption = "Durex",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 20,
                IconId = 52,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 555,
                Name = "kuurna",
                Caption = "Kuurna",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 526,
                OrderId = 4,
                IconId = 5,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"tienda-pixel\", \"pixel3\"]"
            },
            new CatalogPage
            {
                Id = 556,
                Name = "candy",
                Caption = "Candy",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 3,
                IconId = 19,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_candy_headline1\", \"catalog_candy_teaser1\"]"
            },
            new CatalogPage
            {
                Id = 557,
                Name = "rare_groups",
                Caption = "Rare Groups",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 2,
                IconId = 10,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 558,
                Name = "cow_gold_box",
                Caption = "Cow - Gold Box",
                Layout = "single_bundle",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 271,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"cow_pet2\", \"cow_pet2\"]"
            },
            new CatalogPage
            {
                Id = 559,
                Name = "carpets",
                Caption = "Carpets",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 603,
                OrderId = 4,
                IconId = 116,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_rugs_headline1\", \"catalog_rugs_teaser1\"]",
                TextsJson = "[\"Rugs for all occasions, all non-slip and washable.\"]"
            },
            new CatalogPage
            {
                Id = 560,
                Name = "spiderman",
                Caption = "Spiderman",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 59,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 561,
                Name = "superpop",
                Caption = "SuperPop",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 63,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 562,
                Name = "disney",
                Caption = "Disney",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 17,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 563,
                Name = "yle",
                Caption = "YLE",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 71,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 564,
                Name = "veet",
                Caption = "Veet",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 67,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 565,
                Name = "nouvelle_star",
                Caption = "Nouvelle Star",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 46,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 566,
                Name = "dubbelfrisss",
                Caption = "Dubbelfrisss",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 442,
                OrderId = 19,
                IconId = 52,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 567,
                Name = "pinata_prizes",
                Caption = "Pinata Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 14,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 568,
                Name = "classic_furni_lines",
                Caption = "Classic Furni Lines",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 5,
                OrderId = 3,
                IconId = 196,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 569,
                Name = "hoh_winner_statues",
                Caption = "HoH Winner Statues",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 387,
                OrderId = 12,
                IconId = 264,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"catal_fp_pic5\"]",
                TextsJson = "[\"These statues are shown in the Hall of Habbo as a celebration of 15 years of Habbo.\"]"
            },
            new CatalogPage
            {
                Id = 570,
                Name = "unreleased_clothing",
                Caption = "Unreleased Clothing",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Clothing that isn't released in the main catalogue.\", null, null]"
            },
            new CatalogPage
            {
                Id = 571,
                Name = "red_diner",
                Caption = "Red Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 4,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 572,
                Name = "friendship_fusion",
                Caption = "Friendship Fusion",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 27,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"Show your best friends you care by using this duck to create some clothing to gift to them!\", null, null]"
            },
            new CatalogPage
            {
                Id = 573,
                Name = "2017_rares",
                Caption = "2017 Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 720,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 574,
                Name = "2019_rares",
                Caption = "2019 Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 720,
                OrderId = 7,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 575,
                Name = "aquamarine_diner",
                Caption = "Aquamarine Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 8,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 576,
                Name = "pink_diner",
                Caption = "Pink Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 7,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 577,
                Name = "rare_clothing_2017",
                Caption = "[R] Clothing - 2017",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"vippremium2\"]",
                TextsJson = "[\"Unreleased rare clothing.\"]"
            },
            new CatalogPage
            {
                Id = 578,
                Name = "rare_clothing_2018",
                Caption = "[R] Clothing - 2018",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"vippremium2\"]",
                TextsJson = "[\"Unreleased rare clothing.\"]"
            },
            new CatalogPage
            {
                Id = 579,
                Name = "rare_clothing_2019",
                Caption = "[R] Clothing - 2019",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"vippremium2\"]",
                TextsJson = "[\"Unreleased rare clothing.\"]"
            },
            new CatalogPage
            {
                Id = 580,
                Name = "rare_clothing_2016",
                Caption = "[R] Clothing - 2016",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"vippremium2\"]",
                TextsJson = "[\"Unreleased rare clothing.\"]"
            },
            new CatalogPage
            {
                Id = 581,
                Name = "2015-16_new_year_acc.",
                Caption = "2015-16 NY Acc.",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 410,
                OrderId = 21,
                IconId = 350,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"494f9e19e78d \"]"
            },
            new CatalogPage
            {
                Id = 582,
                Name = "2017-18_new_year_acc.",
                Caption = "2017-18 NY Acc.",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 410,
                OrderId = 21,
                IconId = 350,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"494f9e19e78d \"]"
            },
            new CatalogPage
            {
                Id = 583,
                Name = "2016-17_new_year_acc.",
                Caption = "2016-17 NY Acc.",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 410,
                OrderId = 31,
                IconId = 350,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"494f9e19e78d \"]"
            },
            new CatalogPage
            {
                Id = 584,
                Name = "2018-19_new_year_acc.",
                Caption = "2018-19 NY Acc.",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 410,
                OrderId = 10,
                IconId = 350,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"494f9e19e78d \"]"
            },
            new CatalogPage
            {
                Id = 585,
                Name = "golden_accessories",
                Caption = "Golden Accessories",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 8,
                IconId = 263,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"70b334203e82\"]"
            },
            new CatalogPage
            {
                Id = 586,
                Name = "black_diner",
                Caption = "Black Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 2,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 587,
                Name = "beige_diner",
                Caption = "Beige Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = true,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 588,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_hot_header_en\", \"catalog_teaser_new\"]",
                TextsJson = "[\"Need some inspiration? Look no further.\"]"
            },
            new CatalogPage
            {
                Id = 589,
                Name = "new_additions",
                Caption = "New Additions",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 3,
                OrderId = 2,
                IconId = 215,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"clothing_catalog_header\", \"newclothingeaster16\"]",
                TextsJson =
                    "[\"The biggest clothing update for YEARS just landed in the Catalogue. We'll say no more - just GO LOOK!\"]"
            },
            new CatalogPage
            {
                Id = 590,
                Name = "extra_rares",
                Caption = "Extra Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 11,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"limited_header\", \"catalog_limited_teaser\"]",
                TextsJson = "[\"Rares that didn't really fit in any other category.\"]"
            },
            new CatalogPage
            {
                Id = 591,
                Name = "panda_statues",
                Caption = "Panda Statues",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Spromo_Bonus_Bags\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 592,
                Name = "turtle_statues",
                Caption = "Turtle Statues",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = 7,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Spromo_Bonus_Bags\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 593,
                Name = "elegant",
                Caption = "Elegant",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 25,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_classics\", \"classiclounge\"]",
                TextsJson =
                    "[\"Who remembers the legendary Habbo Hotel Public Classics? Now you can recreate them any way you want.\"]"
            },
            new CatalogPage
            {
                Id = 594,
                Name = "blue_diner",
                Caption = "Blue Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 2,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 595,
                Name = "chess",
                Caption = "Chess",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 11,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"chessheader\", \"spromo_Chess_Bundle\"]",
                TextsJson =
                    "[\"Who remembers the legendary Habbo Hotel Public Classics? Now you can recreate them any way you want.\"]"
            },
            new CatalogPage
            {
                Id = 596,
                Name = "teal_rares",
                Caption = "Teal Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 311,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 597,
                Name = "sloth_statues",
                Caption = "Sloth Statues",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = 6,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Spromo_Bonus_Bags\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 598,
                Name = "hedgehog_statues",
                Caption = "Hedgehog Statues",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Spromo_Bonus_Bags\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 599,
                Name = "bonus_prizes",
                Caption = "Bonus Prizes",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 6,
                IconId = 99,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"Spromo_Bonus_Bags\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 600,
                Name = "pinatas_crackables",
                Caption = "Pinatas Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 10,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 601,
                Name = "punching_bags",
                Caption = "Punching Bags",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Spromo_Bonus_Bags\"]",
                TextsJson = "[null]"
            },
            new CatalogPage
            {
                Id = 602,
                Name = "outdoor_furni",
                Caption = "Outdoor Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 9,
                IconId = 220,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 603,
                Name = "room_building",
                Caption = "Room Building",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 8,
                IconId = 63,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 604,
                Name = "indoor_furni",
                Caption = "Indoor Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 7,
                IconId = 112,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 605,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_hot_header_en\", \"catalog_teaser_new\"]",
                TextsJson = "[\"Need some inspiration? Look no further.\"]"
            },
            new CatalogPage
            {
                Id = 606,
                Name = "seating",
                Caption = "Seating",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 2,
                IconId = 111,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_chairs_header_dyn\", \"catalog_chairs_teaser2_001\"]",
                TextsJson =
                    "[\"You can't just leave your friends standing there when you invite them over! Have a look at our huge selection of chairs and take your pick.\"]"
            },
            new CatalogPage
            {
                Id = 607,
                Name = "tables",
                Caption = "Tables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 3,
                IconId = 112,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_tables_header_dyn\", \"catalog_tables_teaser2_001\"]",
                TextsJson =
                    "[\"What's a room without a table? Serve drinks and snacks or simply sit around for some good old chit-chat. Which table suits your room best?\"]"
            },
            new CatalogPage
            {
                Id = 608,
                Name = "beds",
                Caption = "Beds",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 4,
                IconId = 114,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_beds_header_dyn\", \"catalog_beds_teaser2_001\"]",
                TextsJson =
                    "[\"After a busy day making new friends and exploring the Hotel you'll need a good night's sleep! Pick your fave from our range of stylish beds and get some much needed rest.\"]"
            },
            new CatalogPage
            {
                Id = 609,
                Name = "dividers",
                Caption = "Dividers",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 604,
                OrderId = 5,
                IconId = 113,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_dividers_header_dyn\", \"catalog_dividers_teaser2_001\"]",
                TextsJson =
                    "[\"Divide and conquer! A well-placed divider can really tie your room together. Take a look below to see what's on offer.\"]"
            },
            new CatalogPage
            {
                Id = 610,
                Name = "coloured_rares_crackables",
                Caption = "Coloured Rares Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 611,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 603,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_hot_header_en\", \"catalog_teaser_new\"]",
                TextsJson = "[\"Need some inspiration? Look no further.\"]"
            },
            new CatalogPage
            {
                Id = 612,
                Name = "floors",
                Caption = "Floors",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 603,
                OrderId = 2,
                IconId = 41,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_floors_header_dyn\", \"small_promo_venus_de_habbo\"]",
                TextsJson = "[\"This section has a floor furni for every situation.\"]"
            },
            new CatalogPage
            {
                Id = 613,
                Name = "water_features",
                Caption = "Water Features",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 602,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"gondola_header\", \"gondola_teaser\"]",
                TextsJson = "[\"Use this section to complete your room with some relaxing water features.\"]"
            },
            new CatalogPage
            {
                Id = 614,
                Name = "ground",
                Caption = "Ground",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 602,
                OrderId = 4,
                IconId = 21,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"xmas14_catalog_header\", \"garden_teaser_de\"]",
                TextsJson =
                    "[\"Need to build an autumn garden, or do you fancy making a beach room? We've got it covered here.\"]"
            },
            new CatalogPage
            {
                Id = 615,
                Name = "doors",
                Caption = "Doors",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 603,
                OrderId = 5,
                IconId = 55,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalogue_header_castles\", \"Catalogue_Teaser_Castles\"]",
                TextsJson = "[\"Give your room an entrance and an exit.\"]"
            },
            new CatalogPage
            {
                Id = 616,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 602,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_hot_header_en\", \"catalog_teaser_new\"]",
                TextsJson = "[\"Need some inspiration? Look no further.\"]"
            },
            new CatalogPage
            {
                Id = 617,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_hot_header_en\", \"catalog_teaser_new\"]",
                TextsJson = "[\"Need some inspiration? Look no further.\"]"
            },
            new CatalogPage
            {
                Id = 618,
                Name = "deals",
                Caption = "Deals",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 2,
                IconId = 84,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_wired_header6_en\", \"ctlg_pic_wired_deals\"]",
                TextsJson =
                    "[\"The easiest doobie way to get wired is to use the deals! These deals contain all Furni needed to make specific actions like 'Password doors' and 'Switch operated doors' possible.\"]"
            },
            new CatalogPage
            {
                Id = 619,
                Name = "how_to_use_wired",
                Caption = "How To Use Wired",
                Layout = "info_loyalty",
                RoleId = true,
                CatalogPageId = 218,
                OrderId = 9,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 620,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 621,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_hot_header_en\", \"catalog_teaser_new\"]"
            },
            new CatalogPage
            {
                Id = 622,
                Name = "dark_iced",
                Caption = "Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 568,
                OrderId = 5,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_iced_headline1\", \"catalog_iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 623,
                Name = "top_picks",
                Caption = "Top Picks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 234,
                OrderId = true,
                IconId = 195,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 624,
                Name = "clothing",
                Caption = "Clothing",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 3,
                IconId = 74,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 625,
                Name = "green_diner",
                Caption = "Green Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 3,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 626,
                Name = "yellow_diner",
                Caption = "Yellow Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 6,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 627,
                Name = "teal_diner",
                Caption = "Teal Diner",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 9,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 628,
                Name = "diner_accessories",
                Caption = "Diner Accessories",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 43,
                OrderId = 10,
                IconId = 204,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"diner\", \"catalog_diner_teaser_en\"]",
                TextsJson =
                    "[\"Originally from the 50's this furni has been refurbished and put right into the catalogue! Use this with the Kitchen range for ultimate diner experience!\", null, null]"
            },
            new CatalogPage
            {
                Id = 629,
                Name = "greek",
                Caption = "Greek",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 216,
                OrderId = true,
                IconId = 31,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"greek_header\", \"greek_catateaser\"]",
                TextsJson =
                    "[\"Be transported back to ancient Greece with a couple of thousand pounds and British Airways. Until then, build your own pantheon with our realistic Greek range!\", null, null]"
            },
            new CatalogPage
            {
                Id = 630,
                Name = "rollerskating",
                Caption = "Rollerskating",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 219,
                OrderId = 9,
                IconId = 94,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_rollerskates_header\", \"catalog_teaser_rollerblades\"]",
                TextsJson =
                    "[\"Show off your tricks on the rink, get your derby going or just invite your friends to a good ol' roller party! PS. the rink looks great when dressed up with some Neon or Diner Furni!\"]"
            },
            new CatalogPage
            {
                Id = 631,
                Name = "neo-habbo_rares",
                Caption = "Neo-Habbo Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 7,
                IconId = 254,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 632,
                Name = "newbie",
                Caption = "Newbie",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 633,
                Name = "temp_art_n_india",
                Caption = "temp art n india",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 634,
                Name = "crackable_prizes",
                Caption = "Crackable Prizes",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = 6,
                IconId = 42,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 635,
                Name = "valentines_rares",
                Caption = "Valentines Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 20,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 636,
                Name = "nt_clothing",
                Caption = "NT Clothing",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 9,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"NT stands for Non-Tradable; unsure what Habbo uses these for, but they could be used in competitions and events as prizes.\"]"
            },
            new CatalogPage
            {
                Id = 637,
                Name = "gold_crackables",
                Caption = "Gold Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 638,
                Name = "black_dark_iced",
                Caption = "Black Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 2,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 639,
                Name = "white_dark_iced",
                Caption = "White Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 8,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 640,
                Name = "aquamarine_dark_iced",
                Caption = "Aquamarine Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = true,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 641,
                Name = "pink_dark_iced",
                Caption = "Pink Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 5,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 642,
                Name = "blue_dark_iced",
                Caption = "Blue Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 3,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 643,
                Name = "green_dark_iced",
                Caption = "Green Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 4,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 644,
                Name = "yellow_dark_iced",
                Caption = "Yellow Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 9,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 645,
                Name = "red_dark_iced",
                Caption = "Red Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 7,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 646,
                Name = "purple_dark_iced",
                Caption = "Purple Dark Iced",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 622,
                OrderId = 6,
                IconId = 72,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_Iced_headline1\", \"catalog_Iced_teaser1\"]",
                TextsJson =
                    "[\"It's so chic, it says everything and nothing. It's a blank canvas, let your imagination run wild!\"]"
            },
            new CatalogPage
            {
                Id = 647,
                Name = "pink_dark_pura",
                Caption = "Pink Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 6,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 648,
                Name = "black_dark_pura",
                Caption = "Black Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 3,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 649,
                Name = "white_dark_pura",
                Caption = "White Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 10,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 650,
                Name = "beige_dark_pura",
                Caption = "Beige Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 2,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 651,
                Name = "blue_dark_pura",
                Caption = "Blue Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 4,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 652,
                Name = "green_dark_pura",
                Caption = "Green Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 5,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 653,
                Name = "yellow_dark_pura",
                Caption = "Yellow Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 9,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 654,
                Name = "red_dark_pura",
                Caption = "Red Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 8,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 655,
                Name = "purple_dark_pura",
                Caption = "Purple Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = 7,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 656,
                Name = "aqua_dark_pura",
                Caption = "Aqua Dark Pura",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 105,
                OrderId = true,
                IconId = 48,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"puraheader\", \"catalog_pura_teaser1\"]",
                TextsJson =
                    "[\"This collection breathes frresh, clean air and cool tranquility. Use it to create a haven away from the hullabaloo of the public spaces or your life outside the hotel.\"]"
            },
            new CatalogPage
            {
                Id = 657,
                Name = "exotic_birds",
                Caption = "Exotic Birds",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 658,
                Name = "northern_american_animals",
                Caption = "Northern American Animals",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 659,
                Name = "bonus_rare_17",
                Caption = "Bonus Rare 17",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 721,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 660,
                Name = "bonus_rare_18",
                Caption = "Bonus Rare 18",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 721,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 661,
                Name = "bonus_rare_19",
                Caption = "Bonus Rare 19",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 721,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 662,
                Name = "bonus_rare_16",
                Caption = "Bonus Rare 16",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 721,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 663,
                Name = "v1_rares",
                Caption = "V1 Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 664,
                Name = "bonus_bags",
                Caption = "Bonus Bags",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 665,
                Name = "seasonal_crackables",
                Caption = "Seasonal Crackables",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = 2,
                IconId = 90,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 666,
                Name = "halloween_crackables",
                Caption = "Halloween Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 665,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"These must be placed in the main catalogue somewhere for your users to be able to get the prizes, and any linked crafting recipes.\"]"
            },
            new CatalogPage
            {
                Id = 667,
                Name = "easter_crackables",
                Caption = "Easter Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 665,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"These must be placed in the main catalogue somewhere for your users to be able to get the prizes, and any linked crafting recipes.\"]"
            },
            new CatalogPage
            {
                Id = 668,
                Name = "new_year_crackables",
                Caption = "New Year Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 665,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"These must be placed in the main catalogue somewhere for your users to be able to get the prizes, and any linked crafting recipes.\"]"
            },
            new CatalogPage
            {
                Id = 669,
                Name = "christmas_crackables",
                Caption = "Christmas Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 665,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"These must be placed in the main catalogue somewhere for your users to be able to get the prizes, and any linked crafting recipes.\"]"
            },
            new CatalogPage
            {
                Id = 670,
                Name = "sci-fi",
                Caption = "Sci-Fi",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 671,
                Name = "victorian_dolls",
                Caption = "Victorian Dolls",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 672,
                Name = "festival_skulls",
                Caption = "Festival Skulls",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 673,
                Name = "inflatable_furni",
                Caption = "Inflatable Furni",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 345,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 674,
                Name = "crafting",
                Caption = "Crafting",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 4,
                IconId = 180,
                Enabled = false,
                Visible = true,
                TextsJson = "[\"Either used as prizes or ingredients.\"]"
            },
            new CatalogPage
            {
                Id = 675,
                Name = "previous_campaigns",
                Caption = "Previous Campaigns",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 7,
                IconId = 10,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 676,
                Name = "finished_craftables",
                Caption = "Finished Craftables",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 674,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"When a recipe is made, you are given an item to either craft further, or the final product. This is a page of <b>both of those<\\\\/b>, and ideally shouldn't be in the main catalogue; unless you want to skip crafting.\"]"
            },
            new CatalogPage
            {
                Id = 677,
                Name = "secondary_ingredients",
                Caption = "Secondary Ingredients",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 674,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"These <b>secondary ingredients<\\\\/b> are given from craftables, but are used for crafting so shouldn't be in the main catalogue.\"]"
            },
            new CatalogPage
            {
                Id = 678,
                Name = "crafting_tables",
                Caption = "Crafting Tables",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 674,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"For users to craft, they'll need to be able to use these tables.\"]"
            },
            new CatalogPage
            {
                Id = 679,
                Name = "what_you_can_do",
                Caption = "What You Can Do",
                Layout = "info_loyalty",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 14,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 680,
                Name = "pets",
                Caption = "Pets",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = true,
                IconId = 10,
                Enabled = false,
                Visible = true
            },
            new CatalogPage
            {
                Id = 681,
                Name = "cows",
                Caption = "Cows",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 680,
                OrderId = 99,
                IconId = 270,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 682,
                Name = "mystics_rares",
                Caption = "Mystics Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 6,
                IconId = 185,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 683,
                Name = "other",
                Caption = "Other",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 125,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 684,
                Name = "rares_by_furni_line",
                Caption = "Rares by Furni Line",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = true,
                IconId = 42,
                Enabled = false,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 685,
                Name = "'epic_pet_(alone"
            },
            new CatalogPage
            {
                Id = "alone"
            },
            new CatalogPage
            {
                Id = 686,
                Name = "london",
                Caption = "London",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 43,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"Really, you'd expect more coppers and stabbings, but here's some furni to show the safe sides of London!\", null, null]"
            },
            new CatalogPage
            {
                Id = 687,
                Name = "rare_clothing_2020",
                Caption = "[R] Clothing - 2020",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 624,
                OrderId = 6,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Unreleased rare clothing.\", null, null]"
            },
            new CatalogPage
            {
                Id = 688,
                Name = "2019-20_ny_acc.",
                Caption = "2019-20 NY Acc.",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 410,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"This furniture is used in a New Years Crackable.\", null, null]"
            },
            new CatalogPage
            {
                Id = 689,
                Name = "masks",
                Caption = "Masks",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 8,
                OrderId = 9,
                IconId = 214,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_hc\", \"teaser_habboclub\", \"catalog_special_txtbg2\"]",
                TextsJson =
                    "[\"As a member of Habbo Club or HC, you can shop from this selection of exclusive items. Every now and then we will also be adding items that are currently unavailable in the regular Furni Shop as well!\", null, \"For Club members only!\"]"
            },
            new CatalogPage
            {
                Id = 690,
                Name = "seal_statues",
                Caption = "Seal Statues",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 599,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 691,
                Name = "2020_rares",
                Caption = "2020 Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 720,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 692,
                Name = "2020_cafe",
                Caption = "2020 - Cafe",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 376,
                OrderId = 22,
                IconId = 62,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_val12_2_en\", \"catalog_love_teaser1\"]",
                TextsJson = "[\"Create your own romantic caf\\\\u00e9 with this Valentines furni line.\", null, null]"
            },
            new CatalogPage
            {
                Id = 693,
                Name = "bonus_rare_20",
                Caption = "Bonus Rare 20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 721,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 694,
                Name = "jurassic_rares",
                Caption = "Jurassic Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 695,
                Name = "olympics/london_rares",
                Caption = "Olympics/London Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 696,
                Name = "india",
                Caption = "India",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 37,
                IconId = 2,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_frontpage_headline_shop_EN\", \"catal_fp_pic5\"]",
                TextsJson =
                    "[\"Fall into a new role and take on the beautiful palace views that come with it. Will you be the next Sultan?\", null, null]"
            },
            new CatalogPage
            {
                Id = 697,
                Name = "habbo-lympix",
                Caption = "Habbo-Lympix",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 34,
                IconId = 266,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_olympic16\", \"catalog_teaser_olympic16\"]",
                TextsJson =
                    "[\"We've got everything you need to spread the Habbo-lympic spirit across the Hotel, from podiums and torches to tracks and one very special lady that will serve you tea!\", null, null]"
            },
            new CatalogPage
            {
                Id = 698,
                Name = "all_in_one_bc",
                Caption = "'All In One (LAGGY"
            },
            new CatalogPage
            {
                Id = 699,
                Name = "executive_rares",
                Caption = "Executive Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 700,
                Name = "executive",
                Caption = "Executive",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 26,
                IconId = 27,
                Enabled = false,
                Visible = true,
                ImagesJson = "[\"catalog_exe_headline1_en\", \"catalog_exe_teaser_en\"]",
                TextsJson =
                    "[\"The Executive range is ideal for creating a sophisticated working environment, whether it be an office, a mafia headquarters or study!\", null, null]"
            },
            new CatalogPage
            {
                Id = 701,
                Name = "vanilla_executive",
                Caption = "Vanilla Executive",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 700,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 702,
                Name = "drago_rares",
                Caption = "Drago Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 703,
                Name = "bohemian_festival_prizes",
                Caption = "Bohemian Festival Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 704,
                Name = "ingredients",
                Caption = "Ingredients",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 674,
                OrderId = 2,
                IconId = 42,
                Enabled = false,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 705,
                Name = "bohemian_festival_ingr",
                Caption = "Bohemian Festival Ingr.",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 704,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"These will need to be placed somewhere in the main catalogue for users to craft.\", null, null]"
            },
            new CatalogPage
            {
                Id = 706,
                Name = "paris_rares",
                Caption = "Paris Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 10,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 707,
                Name = "pirates_rares",
                Caption = "Pirates Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 11,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 708,
                Name = "pirates",
                Caption = "Pirates",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 209,
                OrderId = 55,
                IconId = 190,
                Enabled = false,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 709,
                Name = "ghost_ship",
                Caption = "Ghost Ship",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 708,
                OrderId = true,
                IconId = 190,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_pirate\", \"pirate_bundle\"]",
                TextsJson = "[\"Yarrr! Harrrrr! Fiddle dee dee, being a pirate is alright with me!\", null, null]"
            },
            new CatalogPage
            {
                Id = 710,
                Name = "bottles",
                Caption = "Bottles",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 708,
                OrderId = true,
                IconId = 190,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_pirate\", \"pirate_bundle\"]",
                TextsJson = "[\"Yarrr! Harrrrr! Fiddle dee dee, being a pirate is alright with me!\", null, null]"
            },
            new CatalogPage
            {
                Id = 711,
                Name = "santorini_rares",
                Caption = "Santorini Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 13,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 712,
                Name = "roombundle_rare",
                Caption = "Roombundle Rare",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 12,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"For some reason, Habbo has some non-LTD versions of some LTDs. Here they are.\", null, null]"
            },
            new CatalogPage
            {
                Id = 713,
                Name = "school_rares",
                Caption = "School Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 14,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 714,
                Name = "steampunk_rares",
                Caption = "Steampunk Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 16,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 715,
                Name = "bazaar_rares",
                Caption = "Bazaar Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 716,
                Name = "sunlight_city_rares",
                Caption = "Sunlight City Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 17,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 717,
                Name = "tokyo_rares",
                Caption = "Tokyo Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 18,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 718,
                Name = "wild_west_rares",
                Caption = "Wild West Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 21,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 719,
                Name = "zen_garden_rares",
                Caption = "Zen Garden Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 684,
                OrderId = 22,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 720,
                Name = "rares_by_year",
                Caption = "Rares by Year",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 557,
                OrderId = 2,
                IconId = 42,
                Enabled = false,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 721,
                Name = "bonus_rares",
                Caption = "Bonus Rares",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 420,
                OrderId = 4,
                IconId = 42,
                Enabled = false,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 722,
                Name = "halloween_prizes",
                Caption = "Halloween Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 10,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 723,
                Name = "jungle_prizes",
                Caption = "Jungle Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 11,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 724,
                Name = "easter_egg_prizes",
                Caption = "Easter Egg Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 725,
                Name = "mystics_prizes",
                Caption = "Mystics Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 12,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 726,
                Name = "habbo15_prizes",
                Caption = "Habbo15 Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 9,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 727,
                Name = "gold_rare_prizes",
                Caption = "Gold Rare Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 7,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 728,
                Name = "easter_prizes",
                Caption = "Easter Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 6,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 729,
                Name = "christmas_prizes",
                Caption = "Christmas Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 2,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 730,
                Name = "santorini_prizes",
                Caption = "Santorini Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 15,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 731,
                Name = "coral_kingdom_prizes",
                Caption = "Coral Kingdom Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 3,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 732,
                Name = "tokyo_prizes",
                Caption = "Tokyo Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 17,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 733,
                Name = "diamond_box_prizes",
                Caption = "Diamond Gift Box Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 734,
                Name = "greek_prizes",
                Caption = "Greek Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 735,
                Name = "spa_prizes",
                Caption = "Spa Prizes",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 634,
                OrderId = 16,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Any missing prizes may be in Secondary Ingredients for Crafting.\", null, null]"
            },
            new CatalogPage
            {
                Id = 736,
                Name = "special_trophies",
                Caption = "Special Trophies",
                Layout = "trophies",
                RoleId = null,
                CatalogPageId = 675,
                OrderId = 8,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 737,
                Name = "individual_trophies",
                Caption = "Individual Trophies",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 736,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 738,
                Name = "2012_ltds",
                Caption = "2012 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = true,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 739,
                Name = "2013_ltds",
                Caption = "2013 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 2,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 740,
                Name = "2014_ltds",
                Caption = "2014 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 3,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 741,
                Name = "2015_ltds",
                Caption = "2015 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 4,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 742,
                Name = "2016_ltds",
                Caption = "2016 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 5,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 743,
                Name = "2017_ltds",
                Caption = "2017 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 6,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 744,
                Name = "2018_ltds",
                Caption = "2018 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 7,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 745,
                Name = "2019_ltds",
                Caption = "2019 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 8,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 746,
                Name = "2020_ltds",
                Caption = "2020 LTDs",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 300,
                OrderId = 9,
                IconId = 145,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 747,
                Name = "india_ingredients",
                Caption = "India Ingr.",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 704,
                OrderId = true,
                IconId = 42,
                Enabled = true,
                Visible = true,
                TextsJson =
                    "[\"These will need to be placed somewhere in the main catalogue for users to craft.\", null, null]"
            },
            new CatalogPage
            {
                Id = 748,
                Name = "neonpunk_c20",
                Caption = "neonpunk_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 749,
                Name = "gothiccafe_c20",
                Caption = "gothiccafe_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 750,
                Name = "sunsetcafe_c20",
                Caption = "sunsetcafe_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 751,
                Name = "zengarden_c20",
                Caption = "zengarden_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 752,
                Name = "rainyday_c20",
                Caption = "rainyday_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 753,
                Name = "habbo20_c20",
                Caption = "habbo20_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 754,
                Name = "rare_blackrosegold",
                Caption = "Blackrosegold",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 311,
                OrderId = 5,
                IconId = true,
                Enabled = true,
                Visible = true
            },
            new CatalogPage
            {
                Id = 755,
                Name = "darkelegant_c20",
                Caption = "darkelegant_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 756,
                Name = "darkmodern_c20",
                Caption = "darkmodern_c20",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 1100,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 757,
                Name = "trimmed_rosegold20",
                Caption = "Trimmed Rose Gold Balloon",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 4,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Stars_header\", \"habbo20_roselinedball\"]",
                TextsJson =
                    "[\"These balloons contain one of 16 different rose gold coloured classic rares! Check below for the probabilities of getting each item.\", null, null]"
            },
            new CatalogPage
            {
                Id = 758,
                Name = "crackables_habbo20",
                Caption = "Crackable Rewards: Probabilities",
                Layout = "pets",
                RoleId = true,
                CatalogPageId = 2,
                OrderId = 5,
                IconId = 42,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"Stars_header\", \"catalog_teaser_atcg\"]",
                TextsJson =
                    "[\"Find out everything you need to know about Trimmed Rose Gold Balloons' rewards here!\", \"Here are the probabilities of getting each item:\", \"\\\\r\\\\n\\\\r\\\\nDragon Lamp: 1%.\\\\r\\\\nIce Cream Maker: 2%.\\\\r\\\\nElephant: 4%.\\\\r\\\\nParasol: 4%.\\\\r\\\\nFountain: 4%.\\\\r\\\\nPowered Fan: 6%.\\\\r\\\\nPillow: 6%.\\\\r\\\\nLaser Portal: 6%.\\\\r\\\\nSmoke Machine: 7%.\\\\r\\\\nSpaceship Door: 7%.\\\\r\\\\nAmber Lamp: 7%.\\\\r\\\\nDoric Pillar: 9%.\\\\r\\\\nSleeping Bag: 9%.\\\\r\\\\nOriental Screen: 9%.\\\\r\\\\nMarquee: 9%.\\\\r\\\\nRoad Barrier: 10%.\\\\r\\\\n\\\\r\\\\n\\\\r\\\\n\\\\r\\\\nSee the balloons on the above sub-page!\\\\r\\\\n\"]"
            },
            new CatalogPage
            {
                Id = 760,
                Name = "habbo20_crackables",
                Caption = "Habbo 20 Crackables",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 190,
                OrderId = true,
                IconId = true,
                Enabled = true,
                Visible = true,
                TextsJson = "[null, null, null]"
            },
            new CatalogPage
            {
                Id = 761,
                Name = "sold_limited_rares",
                Caption = "Sold Rares",
                Layout = "default_3x3",
                RoleId = true,
                CatalogPageId = 14,
                OrderId = true,
                IconId = 198,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"limited_header_sold\", \"limited_sold_promo\"]",
                TextsJson =
                    "[\"his page shows past Limited Edition Rares. They won't come back on sale in the Shop. If they're not sold out, they might be given as prizes later on, but for now the only way to get one is through trading!\"]"
            },
            new CatalogPage
            {
                Id = 1000,
                Name = "dark_elegant_20",
                Caption = "NEW: Dark Elegant Bundle",
                Layout = "room_bundle",
                RoleId = true,
                CatalogPageId = 233,
                OrderId = true,
                IconId = 268,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"dark_elegant20_bundle\"]"
            },
            new CatalogPage
            {
                Id = 1001,
                Name = "chill_modern_20",
                Caption = "NEW: Chill Modern Bundle",
                Layout = "room_bundle",
                RoleId = true,
                CatalogPageId = 233,
                OrderId = 2,
                IconId = 268,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"chill_modern20_bundle\"]"
            },
            new CatalogPage
            {
                Id = 1002,
                Name = "pigglets_habitat20",
                Caption = "Piglet's Habitat Bundle",
                Layout = "room_bundle",
                RoleId = true,
                CatalogPageId = 233,
                OrderId = 5,
                IconId = 268,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"may20_pet3_internal\"]"
            },
            new CatalogPage
            {
                Id = 1003,
                Name = "polarbear_habitat20",
                Caption = "Polar Bear's Habitat Bundle",
                Layout = "room_bundle",
                RoleId = true,
                CatalogPageId = 233,
                OrderId = 6,
                IconId = 268,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"may20_pet4_internal\"]"
            },
            new CatalogPage
            {
                Id = 1004,
                Name = "cat_habitat20",
                Caption = "Kitten's Habitat Bundle",
                Layout = "room_bundle",
                RoleId = true,
                CatalogPageId = 233,
                OrderId = 3,
                IconId = 268,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"may20_pet1_internal\"]"
            },
            new CatalogPage
            {
                Id = 1005,
                Name = "puppy_habitat20",
                Caption = "Puppy's Habitat Bundle",
                Layout = "room_bundle",
                RoleId = true,
                CatalogPageId = 233,
                OrderId = 4,
                IconId = 268,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"may20_pet2_internal\"]"
            },
            new CatalogPage
            {
                Id = 1006,
                Name = "terrier_habitat20",
                Caption = "Terrier's Habitat Bundle",
                Layout = "room_bundle",
                RoleId = true,
                CatalogPageId = 233,
                OrderId = 7,
                IconId = 268,
                Enabled = true,
                Visible = true,
                ImagesJson = "[\"catalog_header_roombundle\", \"may20_pet5_internal\"]"
            },
            new CatalogPage
            {
                Id = 1100,
                Name = "new_release",
                Caption = "New Furnitures",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 4,
                IconId = 180,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"New unrelesed Furnitures.\"]"
            },
            new CatalogPage
            {
                Id = 1110,
                Name = "targetoffer_int",
                Caption = "Targeted Offers",
                Layout = "default_3x3",
                RoleId = null,
                CatalogPageId = 7,
                OrderId = 4,
                IconId = 180,
                Enabled = true,
                Visible = true,
                TextsJson = "[\"Targeted offers Packs\"]"
            }
        );
    }
    
    public static async Task SeedRawSqlFilesAsync(SadieContext context)
    {
        var baseDir = AppContext.BaseDirectory;
        var seedersPath = Path.Combine(baseDir, "Seeders");

        var rawSqlFiles = Directory
            .EnumerateFiles(seedersPath, "*.sql")
            .OrderBy(f => f)
            .ToList();

        foreach (var file in rawSqlFiles)
        {
            Console.WriteLine(file);
            
            var sql = await File.ReadAllTextAsync(file);
            await context.Database.ExecuteSqlRawAsync(sql);
        }
    }
}