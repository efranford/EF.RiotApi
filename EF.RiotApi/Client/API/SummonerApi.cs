using System;
using EF.RiotApi.WebRequestResults;
using EF.RiotApi.Dto.Summoner;
#if NET40 || NET45 || NET451
using System.Threading.Tasks;
#elif NET35
using System.Threading.Tasks;
#endif

namespace EF.RiotApi.Client.API
{
    /// <summary>
    /// The Summoner Api
    /// </summary>
    public class SummonerApi : RiotApi
    {
        #region Singleton

        private static volatile SummonerApi instance;
        private static object instanceLock = new object();

        /// <summary>
        /// The instance of the Summoner Api
        /// </summary>
        public static SummonerApi Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(instanceLock)
                    {
                        if(instance == null)
                        {
                            instance = new SummonerApi();
                        }
                    }
                }
                return instance;
            }
        }

        private SummonerApi() : base() { }

        #endregion

        #region Api Callls

        #region Runes

#if NET45 || NET451
        /// <summary>
        /// Get rune pages by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve rune pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>Task containing the rune pages result</returns>
        public async Task<RunePagesResult> GetSummonerRunesAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<RunePagesResult>.CreateRequestAsync(GetApiUri(api: "summoner", method: "runes", region: region, summonerId: summonerId));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Get rune pages by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve rune pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>Task containing the rune pages result</returns>
        public Task<RunePagesResult> GetSummonerRunesAsync(long summonerId, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<RunePagesResult>.CreateRequest(GetApiUri(api: "summoner", method: "runes", region: region, summonerId: summonerId));
            });
            return result;
        }
#endif

        /// <summary>
        /// Get rune pages by summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve rune pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The rune pages result</returns>
        public RunePagesResult GetSummonerRunes(long summonerId, string region = null)
        {
            var result = JsonWebRequest<RunePagesResult>.CreateRequest(GetApiUri(api: "summoner", method: "runes", region: region, summonerId: summonerId));
            return result;
        }

        #endregion

        #region Masteries

#if NET45 || NET451
        /// <summary>
        /// Get mastery pages by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve mastery pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The Mastery Pages</returns>
        public async Task<MasterPagesResult> GetSummonerMasteriesAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<MasterPagesResult>.CreateRequestAsync(GetApiUri(api: "summoner", method: "masteries", region: region, summonerId: summonerId));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Get mastery pages by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve mastery pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The Mastery Pages</returns>
        public Task<MasterPagesResult> GetSummonerMasteriesAsync(long summonerId, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<MasterPagesResult>.CreateRequest(GetApiUri(api: "summoner", method: "masteries", region: region, summonerId: summonerId));
            });
            return result;
        }
#endif

        /// <summary>
        /// Get mastery pages by summoner ID
        /// </summary>
        /// <param name="summonerId">ID of the summoner for which to retrieve mastery pages.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The Mastery Pages</returns>
        public MasterPagesResult GetSummonerMasteries(long summonerId, string region = null)
        {
            var result = JsonWebRequest<MasterPagesResult>.CreateRequest(GetApiUri(api: "summoner", method: "masteries", region: region, summonerId: summonerId));
            return result;
        }

        #endregion

        #region Summoner

#if NET45 || NET451
        /// <summary>
        /// Get summoner by name asynchronously
        /// </summary>
        /// <param name="name">Name of summoner to retrieve.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A summoner task</returns>
        public async Task<SummonerDto> GetSummonerAsync(string name, string region = null)
        {
            var recentGamesResult = JsonWebRequest<SummonerDto>.CreateRequestAsync(GetApiUri(api: "summoner", summonerName: name, region: region));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Get summoner by name asynchronously
        /// </summary>
        /// <param name="name">Name of summoner to retrieve.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A summoner task</returns>
        public Task<SummonerDto> GetSummonerAsync(string name, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<SummonerDto>.CreateRequest(GetApiUri(api: "summoner", summonerName: name, region: region));
            });
            return result;
        }
#endif

        /// <summary>
        /// Get summoner by name 
        /// </summary>
        /// <param name="name">Name of summoner to retrieve.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A Summoner</returns>
        public SummonerDto GetSummoner(string name, string region = null)
        {
            var result = JsonWebRequest<SummonerDto>.CreateRequest(GetApiUri(api: "summoner", summonerName: name, region: region));
            return result;
        }

#if NET45 || NET451

        /// <summary>
        /// Get summoner by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner to retrieve</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A Summoner task</returns>
        public async Task<SummonerDto> GetSummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<SummonerDto>.CreateRequestAsync(GetApiUri(api: "summoner", summonerId: summonerId, region: region));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Get summoner by summoner ID asynchronously
        /// </summary>
        /// <param name="summonerId">ID of the summoner to retrieve</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A Summoner task</returns>
        public Task<SummonerDto> GetSummonerAsync(long summonerId, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<SummonerDto>.CreateRequest(GetApiUri(api: "summoner", summonerId: summonerId, region: region));
            });
            return result;
        }
#endif

        /// <summary>
        /// Get summoner by summoner ID 
        /// </summary>
        /// <param name="summonerId">ID of the summoner to retrieve</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>A Summoner</returns>
        public SummonerDto GetSummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<SummonerDto>.CreateRequest(GetApiUri(api: "summoner", summonerId: summonerId, region: region));
            return result;
        }

#if NET45 || NET451
        /// <summary>
        /// Get list of summoner names by summoner IDs asynchronously
        /// </summary>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The task containing a list of summoner name information </returns>
        public async Task<SummonerNameListResult> GetSummonersAsync(string summonerIds, string region = null)
        {
            var recentGamesResult = JsonWebRequest<SummonerNameListResult>.CreateRequestAsync(GetApiUri(api: "summoner", method: "name", summonerIds: summonerIds, region: region));
            var result = await recentGamesResult;
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Get list of summoner names by summoner IDs asynchronously
        /// </summary>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The task containing a list of summoner name information </returns>
        public Task<SummonerNameListResult> GetSummonersAsync(string summonerIds, string region = null)
        {
            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<SummonerNameListResult>.CreateRequest(GetApiUri(api: "summoner", method: "name", summonerIds: summonerIds, region: region));
            });
            return result;
        }
#endif

        /// <summary>
        /// Get list of summoner names by summoner ID
        /// </summary>
        /// <param name="summonerIds">Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.</param>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>The list of summoner name information.</returns>
        public SummonerNameListResult GetSummoners(string summonerIds, string region = null)
        {
            var result = JsonWebRequest<SummonerNameListResult>.CreateRequest(GetApiUri(api: "summoner", method: "name", summonerIds: summonerIds, region: region));
            return result;
        }

        #endregion

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
            if (string.IsNullOrEmpty(method))
            {
                if (string.IsNullOrEmpty(summonerName))
                {
                    return string.Format("{0}/{1}/{2}/{3}/{4}?api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
                }
                else
                {
                    return string.Format("{0}/{1}/{2}/{3}/by-name/{4}?api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerName, ApiKey);
                }
            }
            else
            {
                if (method == "name")
                {
                    return string.Format("{0}/{1}/{2}/{3}/{4}/{5}?api_key={6}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerIds, method, ApiKey);
                }
                else
                {
                    return string.Format("{0}/{1}/{2}/{3}/{4}/{5}?api_key={6}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, method, ApiKey);
                }
            }
        }
        
        #endregion
    }
}
