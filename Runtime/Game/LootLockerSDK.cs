using System;

namespace LootLocker
{
    public class LootLockerApiBase
    {
        internal LootLockerApiBase() { }
    }

    public class LootLockerLeaderboardApi : LootLockerLeaderboardApiV1
    {}

    public class LootLockerLeaderboardApiV1 : LootLockerApiBase
    {
        public class LootLockerPlayer
        {
            public int id { get; set; }
            public string public_uid { get; set; }
            public string name { get; set; }
        }
        public class LootLockerGetMemberRankResponse : LootLockerResponse
        {
            public int rank { get; set; }
            public int score { get; set; }
            public LootLockerPlayer player { get; set; }
        }

        public void GetMemberRank(string leaderboardId, int member_id, Action<LootLockerGetMemberRankResponse> onComplete) { throw new NotImplementedException(); }
    }
    public class LootLockerLeaderboardApiV0 : LootLockerApiBase
    {
        public class LootLockerPlayer
        {
            public int id { get; set; }
            public string public_uid { get; set; }
            public string name { get; set; }
        }
        public class LootLockerGetMemberRankResponse : LootLockerResponse
        {
            public int rank { get; set; }
            public int score { get; set; }
            public LootLockerPlayer player { get; set; }
        }

        public void GetMemberRank(string leaderboardId, int member_id, Action<LootLockerGetMemberRankResponse> onComplete) { throw new NotImplementedException(); }
    }

    public static class LootLockerSdk
    {
        static LootLockerLeaderboardApi Leaderboard { get; } = new LootLockerLeaderboardApi();

        static T GetApi<T>() where T : LootLockerApiBase, new() { return new T(); }
    }

    // Example usage
    //
    // LootLockerSdk.Leaderboard.GetMemberRank(...);
    // LootLockerSdk.GetApi<LootLockerLeaderboardApiV0>().Leaderboard.GetMemberRank(...);
    //
}