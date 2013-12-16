using System;
using EF.RiotApi.Caching;
using EF.RiotApi.WebRequestResults;
#if NET40 || NET45 || NET451
using System.Threading.Tasks;
#elif NET35
using System.Threading.Tasks;
#endif

namespace EF.RiotApi.Client.API
{
    /// <summary>
    /// The Champion Api
    /// https://developer.riotgames.com/api/methods#!/291
    /// </summary>
    public class ChampionApi : RiotApi
    {
        #region Singleton

        private static volatile ChampionApi instance;
        private static object instanceLock = new object();

        /// <summary>
        /// The instance of the Champion Api
        /// </summary>
        public static ChampionApi Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(instanceLock)
                    {
                        if(instance == null)
                        {
                            instance = new ChampionApi();
                        }
                    }
                }
                return instance;
            }
        }

        private ChampionApi() : base() { }

        #endregion 
        
        #region Api Calls

#if NET45 || NET451
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

            var championsRequest = JsonWebRequest<ChampionsResult>.CreateRequestAsync(GetApiUri(api: "champion", freeToPlay: freeToPlay));
            var result = await championsRequest;

            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
            return result;
        }
#elif NET35 || NET40
        /// <summary>
        /// Retrieve all champions asynchronously
        /// </summary>
        /// <param name="region">The region of the leagues</param>
        /// <param name="freeToPlay">Optional filter param to retrieve only free to play champions.</param>
        /// <returns>Champion list task containing the result</returns>
        public Task<ChampionsResult> GetChampionsAsync(string region = null, bool freeToPlay = false)
        {
            if (ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return Task.Factory.StartNew(()=>
                {
                    return new ChampionsResult { Champions = ApiCache.Instance.Champions };
                });
            }

            var result = Task.Factory.StartNew(() =>
            {
                return JsonWebRequest<ChampionsResult>.CreateRequest(GetApiUri(api: "champion", freeToPlay: freeToPlay));
            });

            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Result.Champions;
            }

            return result;
        }
#endif

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

            var result = JsonWebRequest<ChampionsResult>.CreateRequest(GetApiUri(api: "champion", freeToPlay: freeToPlay));

            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
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
            return string.Format("{0}/{1}/{2}/{3}?freeToPlay={4}&api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, freeToPlay, ApiKey);
        }

        #endregion
    }
}
