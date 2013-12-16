using System;
using EF.RiotApi.WebRequestResults;
#if NET40 || NET45 || NET451
using System.Threading.Tasks;
#elif NET35
using System.Threading.Tasks;
#endif

namespace EF.RiotApi.Client.API
{
    /// <summary>
    /// The Stats Api
    /// https://developer.riotgames.com/api/methods#!/294
    /// </summary>
    public class StatsApi : RiotApi
    {
        #region Singleton

        private static volatile StatsApi instance;
        private static object instanceLock = new object();

        /// <summary>
        /// The instance of the Stats Api
        /// </summary>
        public static StatsApi Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(instanceLock)
                    {
                        if(instance == null)
                        {
                            instance = new StatsApi();
                        }
                    }
                }
                return instance;
            }
        }

        private StatsApi() : base() { }

        #endregion

        #region Api Calls

#if NET45 || NET451
        /// <summary>
        /// Get player stats summaries by summoner ID asynchronously. One summary is returned per queue type
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>Player stats summary result</returns>
        public async Task<PlayerStatsSummaryResult> GetPlayerStatsSummaryAsync(long summonerId, string region = null, string season = null)
        {
            var recentGamesResult = JsonWebRequest<PlayerStatsSummaryResult>.CreateRequestAsync(GetApiUri(api: "stats", region: region, summonerId: summonerId, season: season));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>Player stats summary result</returns>
        public Task<PlayerStatsSummaryResult> GetPlayerStatsSummaryAsync(long summonerId, string region = null, string season = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<PlayerStatsSummaryResult>.CreateRequest(GetApiUri(api: "stats", region: region, summonerId: summonerId, season: season));
            });
            return result;
        }
#endif

        /// <summary>
        /// Get player stats summaries by summoner ID. One summary is returned per queue type
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="season">If specified, stats for the given season are returned. Otherwise, stats for the current season are returned.</param>
        /// <returns>Player stats summary result</returns>
        public PlayerStatsSummaryResult GetPlayerStatsSummary(long summonerId, string region = null, string season = null)
        {
            var result = JsonWebRequest<PlayerStatsSummaryResult>.CreateRequest(GetApiUri(api: "stats", region: region, summonerId: summonerId, season: season));
            return result;
        }

        #endregion


        #region RiotApi Implementation

        /// <summary>
        /// Returns the string for the api uri based on the given parameters. 
        /// Only pass in what you need here. Name parameters are your friend.
        /// </summary>
        /// <param name="api">Api name</param>
        /// <param name="method">Api method (optional)</param>
        /// <param name="summonerId">The summoner id (optional)</param>
        /// <param name="region">The region(optional)</param>
        /// <param name="version">The api version (optional)</param>
        /// <param name="season">The season (optional)</param>
        /// <param name="freeToPlay">If free to play (optional)</param>
        /// <param name="summonerName">The summoner name (optional)</param>
        /// <param name="summonerIds">The summoner ids (optional)</param>
        /// <returns>The request string to the given api (optional)</returns>
        protected override string GetApiUri(string api, string method = null, long summonerId = -1, string region = null, string version = null, string season = null, bool freeToPlay = false, string summonerName = null, string summonerIds = null)
        {
            return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}/summary?season={5}&api_key={6}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, season ?? string.Empty, ApiKey);
        }

        #endregion
    }
}
