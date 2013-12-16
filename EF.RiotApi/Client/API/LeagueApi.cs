using System;
#if NET40 || NET45 || NET451
using System.Threading.Tasks;
using EF.RiotApi.WebRequestResults;
using EF.RiotApi.Helpers;
#elif NET35
using System.Threading.Tasks;
#endif

namespace EF.RiotApi.Client.API
{
    /// <summary>
    /// The Leage Api
    /// https://developer.riotgames.com/api/methods#!/254
    /// </summary>
    public class LeagueApi : RiotApi
    {
        #region Singleton

        private static volatile LeagueApi instance;
        private static object instanceLock = new object();

        /// <summary>
        /// The instance of the League Api
        /// </summary>
        public static LeagueApi Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(instanceLock)
                    {
                        if(instance == null)
                        {
                            instance = new LeagueApi();
                        }
                    }
                }
                return instance;
            }
        }

        private LeagueApi() : base() { }

        #endregion

        #region Api Calls

#if NET45 || NET451
        /// <summary>
        /// Retrieves leagues data for summoner asynchronously, including leagues for all of summoner's teams
        /// </summary>
        /// <param name="summonerId">Summoner ID</param>
        /// <param name="region">The region of the leagues</param>
        /// <returns>A dictonary with the key as league name, and the value the League DTO</returns>
        public async Task<LeagueResult> GetLeagueBySummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<LeagueResult>.CreateRequestAsync(GetApiUri(api: "league", region: region, summonerId: summonerId, version: "v2.1"));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Retrieves leagues data for summoner asynchronously, including leagues for all of summoner's teams
        /// </summary>
        /// <param name="summonerId">Summoner ID</param>
        /// <param name="region">The region of the leagues</param>
        /// <returns>A dictonary with the key as league name, and the value the League DTO</returns>
        public Task<LeagueResult> GetLeagueBySummonerAsync(long summonerId, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<LeagueResult>.CreateRequest(GetApiUri(api: "league", region: region, summonerId: summonerId, version: "v2.1"));
            });
            return result;
        }
#endif

        /// <summary>
        /// Retrieves leagues data for summoner, including leagues for all of summoner's teams
        /// </summary>
        /// <param name="summonerId">Summoner ID</param>
        /// <param name="region">The region of the leagues</param>
        /// <returns>A dictonary with the key as league name, and the value the League DTO</returns>
        public LeagueResult GetLeagueBySummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<LeagueResult>.CreateRequest(GetApiUri(api: "league", region: region, summonerId: summonerId, version: "v2.1"));
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
            return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}?api_key={5}", ApiUrl.Replace("/lol", string.Empty), region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
        }

        #endregion
    }
}
