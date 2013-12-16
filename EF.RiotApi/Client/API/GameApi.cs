using System;
using EF.RiotApi.WebRequestResults;
#if NET40 || NET45 || NET451
using System.Threading.Tasks;
#elif NET35
using System.Threading.Tasks;
#endif

namespace EF.RiotApi.Client.API
{
    public class GameApi : RiotApi
    {
        #region Singleton

        private static volatile GameApi instance;
        private static object instanceLock = new object();

        public static GameApi Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(instanceLock)
                    {
                        if(instance == null)
                        {
                            instance = new GameApi();
                        }
                    }
                }
                return instance;
            }
        }

        private GameApi() : base() { }

        #endregion 
        
        #region Api Calls

#if NET45 || NET451
        /// <summary>
        /// Get recent games by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <param name="region">Region where to retrieve the data</param>
        /// <returns>The Summoners Recent Games</returns>
        public async Task<RecentGamesResult> GetGamesBySummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<RecentGamesResult>.CreateRequestAsync(GetApiUri(api: "game", region: region, summonerId: summonerId));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Get recent games by summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <param name="region">Region where to retrieve the data</param>
        /// <returns>The Summoners Recent Games</returns>
        public Task<RecentGamesResult> GetGamesBySummonerAsync(long summonerId, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<RecentGamesResult>.CreateRequest(GetApiUri(api: "game", region: region, summonerId: summonerId));
            });
            return result;
        }
#endif

        /// <summary>
        /// Get recent games by summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <param name="region">Region where to retrieve the data</param>
        /// <returns>The Summoners Recent Games</returns>
        public RecentGamesResult GetGamesBySummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<RecentGamesResult>.CreateRequest(GetApiUri(api: "game", region: region, summonerId: summonerId));
            return result;
        }

        #endregion

        #region RiotApi Implementation

        protected override string GetApiUri(string api, string method = null, long summonerId = -1, string region = null, string version = null, string season = null, bool freeToPlay = false, string summonerName = null, string summonerIds = null)
        {
            return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}/recent?api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
        }

        #endregion
    }
}
