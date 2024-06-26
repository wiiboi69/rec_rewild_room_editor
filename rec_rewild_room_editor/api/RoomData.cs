using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api;
using static api.WarningMask;

namespace api
{
    internal class roomdata
    {
        public class RoomRootv2
        {
            public ulong RoomId { get; set; }
            public bool IsDorm { get; set; }
            public int MaxPlayerCalculationMode { get; set; }
            public int MaxPlayers { get; set; }
            public bool CloningAllowed { get; set; }
            public bool DisableMicAutoMute { get; set; }
            public bool DisableRoomComments { get; set; }
            public bool EncryptVoiceChat { get; set; }
            public bool ToxmodEnabled { get; set; }
            public bool LoadScreenLocked { get; set; }
            public int PersistenceVersion { get; set; }
            public bool AutoLocalizeRoom { get; set; }
            public bool IsDeveloperOwned { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageName { get; set; }
            public WarningMaskType WarningMask { get; set; }
            public string CustomWarning { get; set; }
            public ulong CreatorAccountId { get; set; }
            public int State { get; set; }
            public int Accessibility { get; set; }
            public bool SupportsLevelVoting { get; set; }
            public bool IsRRO { get; set; }
            public bool SupportsScreens { get; set; }
            public bool SupportsWalkVR { get; set; }
            public bool SupportsTeleportVR { get; set; }
            public bool SupportsVRLow { get; set; }
            public bool SupportsQuest2 { get; set; }
            public bool SupportsMobile { get; set; }
            public bool SupportsJuniors { get; set; }
            public int MinLevel { get; set; }
            public string CreatedAt { get; set; }
            public Stats Stats { get; set; }
            public string? RankedEntityId { get; set; }
            public string? RankingContext { get; set; }
            public List<SubRooms> SubRooms { get; set; }
            public List<Roles> Roles { get; set; }
            public string? DataBlob { get; set; }
            public int UgcVersion { get; set; }
            public List<Tags> Tags { get; set; }
            public List<dummy> PromoImages { get; set; }
            public List<dummy> PromoExternalContent { get; set; }
            public List<LoadScreens> LoadScreens { get; set; }

        }
        public class SubRooms
        {
            public int SubRoomId { get; set; }
            public int RoomId { get; set; }
            public string Name { get; set; }
            public string? DataBlob { get; set; }
            public bool IsSandbox { get; set; }
            public int MaxPlayers { get; set; }
            public int Accessibility { get; set; }
            public string UnitySceneId { get; set; }
            public int SavedByAccountId { get; set; }
        }
        public class Tags
        {
            public string Tag { get; set; }
            public int Type { get; set; }
        }
        public class LoadScreens
        {
            public string ImageName { get; set; }
            public string Title { get; set; }
            public string Subtitle { get; set; }
        }
        public class Stats
        {
            public int CheerCount { get; set; }
            public int FavoriteCount { get; set; }
            public int VisitorCount { get; set; }
            public int VisitCount { get; set; }
        }
        public class Roles
        {
            public int AccountId { get; set; }
            public int Role { get; set; }
            public int InvitedRole { get; set; }
        }
        public class dummy
        { 

        }
        public class SubRoomsv2
        {
            public int Accessibility { get; set; }
            public string? DataBlob { get; set; }
            public string? DataBlobName { get; set; }
            public string? DataBlobHash { get; set; }
            public bool IsSandbox { get; set; }
            public int MaxPlayers { get; set; }
            public string Name { get; set; }
            public int SubRoomId { get; set; }
            public int RoomId { get; set; }
            public string UnitySceneId { get; set; }
            public string Location { get; set; }
            public int SavedByAccountId { get; set; }
        }
        public class Statsv2
        {
            public int CheerCount { get; set; }
            public int FavoriteCount { get; set; }
            public ulong RoomId { get; set; }
            public int VisitorCount { get; set; }
            public int VisitCount { get; set; }
        }
    }
}
