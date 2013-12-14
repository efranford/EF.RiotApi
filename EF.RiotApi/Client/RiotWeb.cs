using EF.RiotApi.Caching;
using EF.RiotApi.Dto;
using EF.RiotApi.Dto.Summoner;
using EF.RiotApi.Helpers;
using EF.RiotApi.WebRequestResults;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Client
{
    public class RiotWeb
    {
        #region Singleton

        private static volatile RiotWeb instance;
        private static object instanceLock = new object();

        public static RiotWeb API
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new RiotWeb();
                        }
                    }
                }
                return instance;
            }
        }

        private RiotWeb()
        {
            ApiKey = ConfigurationManager.AppSettings["ApiKey"];
            ApiUrl = ConfigurationManager.AppSettings["ApiUrl"];
            ApiRegion = ConfigurationManager.AppSettings["ApiRegion"];
            ApiVerision = ConfigurationManager.AppSettings["ApiVerision"];
        }

        #endregion

        #region Properties

        public string ApiKey { get; set; }
        public string ApiLocation 
        { 
            get
            {
                return RiotApiHelper.GetApiUrl();
            }
        }
        public string ApiUrl { get; set; }
        public string ApiRegion { get; set; }
        public string ApiVerision { get; set; }
        
        #endregion

        #region Champion Api

        /// <summary>
        /// Retrieve all champions asynchronously
        /// </summary>
        /// <param name="region">The region of the leagues</param>
        /// <param name="freeToPlay">Optional filter param to retrieve only free to play champions.</param>
        /// <returns>Champion list task containing the result</returns>
        public async Task<ChampionsResult> GetChampionsAsync(string region = null, bool freeToPlay = false)
        {
            if (ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return new ChampionsResult { Champions = ApiCache.Instance.Champions };
            }

            var championsRequest = JsonWebRequest<ChampionsResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"champion", freeToPlay:freeToPlay));
            var result = await championsRequest;

            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
            return result;
        }

        /// <summary>
        /// Retrieve all champions
        /// </summary>
        /// <param name="region">The region of the leagues</param>
        /// <param name="freeToPlay">Optional filter param to retrieve only free to play champions.</param>
        /// <returns>Champions result</returns>
        public ChampionsResult GetChampions(string region = null, bool freeToPlay = false)
        {
            if (ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return new ChampionsResult { Champions = ApiCache.Instance.Champions };
            }

            var result = JsonWebRequest<ChampionsResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "champion", freeToPlay: freeToPlay));

            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
            return result;
        }

        #endregion

        #region Game Api

        /// <summary>
        /// Get recent games by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <param name="region">Region where to retrieve the data</param>
        /// <returns>The Summoners Recent Games</returns>
        public async Task<RecentGamesResult> GetGamesBySummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<RecentGamesResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"game", region:region, summonerId:summonerId));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Get recent games by summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <param name="region">Region where to retrieve the data</param>
        /// <returns>The Summoners Recent Games</returns>
        public RecentGamesResult GetGamesBySummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<RecentGamesResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "game", region: region, summonerId: summonerId));
            return result;
        }

        #endregion

        #region League Api

        /// <summary>
        /// Retrieves leagues data for summoner asynchronously, including leagues for all of summoner's teams
        /// </summary>
        /// <param name="summonerId">Summoner ID</param>
        /// <param name="region">The region of the leagues</param>
        /// <returns>A dictonary with the key as league name, and the value the League DTO</returns>
        public async Task<LeagueResult> GetLeagueBySummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<LeagueResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"league", region:region, summonerId:summonerId, version:"v2.1"));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams
        /// </summary>
        /// <param name="summonerId">Summoner ID</param>
        /// <param name="region">The region of the leagues</param>
        /// <returns>A dictonary with the key as league name, and the value the League DTO</returns>
        public LeagueResult GetLeagueBySummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<LeagueResult>.CreateRequest(RiotApiHelper.GetApiUri(api:"league", region:region, summonerId:summonerId, version:"v2.1"));
            return result;
        }

        #endregion

        #region Stats Api

        /// <summary>
        /// Get player stats summaries by summoner ID asynchronously. One summary is returned per queue type
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>Player stats summary result</returns>
        public async Task<PlayerStatsSummaryResult> GetPlayerStatsSummaryAsync(long summonerId, string region = null, string season = null)
        {
            var recentGamesResult = JsonWebRequest<PlayerStatsSummaryResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"stats", region:region, summonerId:summonerId, season:season));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Get player stats summaries by summoner ID. One summary is returned per queue type
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>Player stats summary result</returns>
        public PlayerStatsSummaryResult GetPlayerStatsSummary(long summonerId, string region = null, string season = null)
        {
            var result = JsonWebRequest<PlayerStatsSummaryResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "stats", region: region, summonerId: summonerId, season: season));
            return result;
        }

        #endregion

        #region Summoner Api

        #region Runes

        /// <summary>
        /// Get rune pages by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve rune pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>Task containing the rune pages result</returns>
        public async Task<RunePagesResult> GetSummonerRunesAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<RunePagesResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api: "summoner", method: "runes", region: region, summonerId: summonerId));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Get rune pages by summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve rune pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The rune pages result</returns>
        public RunePagesResult GetSummonerRunes(long summonerId, string region = null)
        {
            var result = JsonWebRequest<RunePagesResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "summoner", method: "runes", region: region, summonerId: summonerId));
            return result;
        }

        #endregion

        #region Masteries

        /// <summary>
        /// Get mastery pages by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve mastery pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The Mastery Pages</returns>
        public async Task<MasterPagesResult> GetSummonerMasteriesAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<MasterPagesResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api: "summoner", method: "masteries", region: region, summonerId: summonerId));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Get mastery pages by summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve mastery pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The Mastery Pages</returns>
        public MasterPagesResult GetSummonerMasteries(long summonerId, string region = null)
        {
            var result = JsonWebRequest<MasterPagesResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "summoner", method: "masteries", region: region, summonerId: summonerId));
            return result;
        }

        #endregion

        #region Summoner

        /// <summary>
        /// Get summoner by name asynchronously
        /// </summary>
        /// <param name="name">Name of summoner to retrieve.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A summoner task</returns>
        public async Task<SummonerDto> GetSummonerAsync(string name, string region = null)
        {
            var recentGamesResult = JsonWebRequest<SummonerDto>.CreateRequestAsync(RiotApiHelper.GetApiUri(api: "summoner", summonerName:name, region: region));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Get summoner by name 
        /// </summary>
        /// <param name="name">Name of summoner to retrieve.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A Summoner</returns>
        public SummonerDto GetSummoner(string name, string region = null)
        {
            var result = JsonWebRequest<SummonerDto>.CreateRequest(RiotApiHelper.GetApiUri(api: "summoner", summonerName: name, region: region));
            return result;
        }

        /// <summary>
        /// Get summoner by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner to retrieve</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A Summoner task</returns>
        public async Task<SummonerDto> GetSummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<SummonerDto>.CreateRequestAsync(RiotApiHelper.GetApiUri(api: "summoner", summonerId: summonerId, region: region));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Get summoner by summoner ID 
        /// </summary>
        /// <param name="summonerId">ID of the summoner to retrieve</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A Summoner</returns>
        public SummonerDto GetSummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<SummonerDto>.CreateRequest(RiotApiHelper.GetApiUri(api: "summoner", summonerId: summonerId, region: region));
            return result;
        }

        /// <summary>
        /// Get list of summoner names by summoner IDs asynchronously
        /// </summary>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The task containing a list of summoner name information </returns>
        public async Task<SummonerNameListResult> GetSummonersAsync(string summonerIds, string region = null)
        {
            var recentGamesResult = JsonWebRequest<SummonerNameListResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api: "summoner", method: "name", summonerIds: summonerIds, region: region));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Get list of summoner names by summoner ID
        /// </summary>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The list of summoner name information.</returns>
        public SummonerNameListResult GetSummoners(string summonerIds, string region = null)
        {
            var result = JsonWebRequest<SummonerNameListResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "summoner", method:"name", summonerIds: summonerIds, region: region));
            return result;
        }

        #endregion

        #endregion

        #region Team Api

        /// <summary>
        /// Retrieves teams for given summoner ID aynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A task with the summoner teams in the result</returns>
        public async Task<TeamResult> GetSummonerTeamsAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<TeamResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api: "team", version:"v2.1", region: region, summonerId: summonerId));
            var result = await recentGamesResult;
            return result;
        }

        /// <summary>
        /// Retrieves teams for given summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The summoners teams</returns>
        public TeamResult GetSummonerTeams(long summonerId, string region = null)
        {
            var result = JsonWebRequest<TeamResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "team", version:"v2.1", region: region, summonerId: summonerId));
            return result;
        }

        #endregion
    }
}
