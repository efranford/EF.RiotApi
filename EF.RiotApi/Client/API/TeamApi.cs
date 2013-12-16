using System;
using EF.RiotApi.WebRequestResults;
#if NET40 || NET45 || NET451
using System.Threading.Tasks;
using EF.RiotApi.Dto.Summoner;
#elif NET35
using System.Threading.Tasks;
#endif


namespace EF.RiotApi.Client.API
{
    /// <summary>
    /// The Team Api
    /// https://developer.riotgames.com/api/methods#!/256
    /// </summary>
    public class TeamApi : RiotApi
    {
        #region Singleton

        private static volatile TeamApi instance;
        private static object instanceLock = new object();
        
        /// <summary>
        /// The singleton instance of the Team Api
        /// </summary>
        public static TeamApi Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(instanceLock)
                    {
                        if(instance == null)
                        {
                            instance = new TeamApi();
                        }
                    }
                }
                return instance;
            }
        }

        private TeamApi() : base() { }

        #endregion

        #region Api Calls

#if NET45 || NET451
        /// <summary>
        /// Retrieves teams for given summoner ID aynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A task with the summoner teams in the result</returns>
        public async Task<TeamResult> GetSummonerTeamsAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<TeamResult>.CreateRequestAsync(GetApiUri(api: "team", version: "v2.1", region: region, summonerId: summonerId));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Retrieves teams for given summoner ID aynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A task with the summoner teams in the result</returns>
        public Task<TeamResult> GetSummonerTeamsAsync(long summonerId, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<TeamResult>.CreateRequest(GetApiUri(api: "team", version: "v2.1", region: region, summonerId: summonerId));
            });
            return result;
        }
#endif
        /// <summary>
        /// Retrieves teams for given summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve player stats.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The summoners teams</returns>
        public TeamResult GetSummonerTeams(long summonerId, string region = null)
        {
            var result = JsonWebRequest<TeamResult>.CreateRequest(GetApiUri(api: "team", version: "v2.1", region: region, summonerId: summonerId));
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
