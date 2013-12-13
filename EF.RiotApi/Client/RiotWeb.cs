using EF.RiotApi.Caching;
using EF.RiotApi.Dto;
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
                return GetApiUrl();
            }
        }
        public string ApiUrl { get; set; }
        public string ApiRegion { get; set; }
        public string ApiVerision { get; set; }
        
        #endregion

        #region Champion

        public async Task<ChampionsResult> GetChampionsAsync(bool freeToPlay = false)
        {
            if (ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return new ChampionsResult { Champions = ApiCache.Instance.Champions };
            }

            var championsRequest = RiotWebRequest<ChampionsResult>.CreateRequestAsync(GetChampionUri(false));
            var result = await championsRequest;

            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
            return result;
        }

        public ChampionsResult GetChampions(bool freeToPlay = false)
        {
            if (ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return new ChampionsResult { Champions = ApiCache.Instance.Champions };
            }

            var result = RiotWebRequest<ChampionsResult>.CreateRequest(GetChampionUri(false));

            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
            return result;
        }

        #endregion

        #region Game

        public async Task<RecentGamesResult> GetGamesBySummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = RiotWebRequest<RecentGamesResult>.CreateRequestAsync(GetBySummonerUri("game", region, summonerId));
            var result = await recentGamesResult;
            return result;
        }

        public RecentGamesResult GetGamesBySummoner(long summonerId, string region = null)
        {
            var result = RiotWebRequest<RecentGamesResult>.CreateRequest(GetBySummonerUri("game", region, summonerId));
            return result;
        }

        #endregion

        #region League

        public async Task<LeagueResult> GetLeagueBySummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = RiotWebRequest<LeagueResult>.CreateRequestAsync(GetBySummonerUri("league", region, summonerId, "v2.1"));
            var result = await recentGamesResult;
            return result;
        }

        public LeagueResult GetLeagueBySummoner(long summonerId, string region = null)
        {
            var result = RiotWebRequest<LeagueResult>.CreateRequest(GetBySummonerUri("league", region, summonerId, "v2.1"));
            return result;
        }

        #endregion

        #region Helpers

        #region Formatters

        public string GetApiUrl(string region = null, string version = null)
        {
            return string.Format("{0}/{1}/{2}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision);
        }

        private string GetBySummonerUri(string api, string region, long summonerId, string version = null)
        {
            switch(api)
            {
                case "league":
                    // I think riot means to have /lol in this url, but for now it's not there..
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}?api_key={5}", ApiUrl.Replace("/lol",""), region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
                case "game":
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}/recent?api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
            }
            return string.Empty;
        }
   
        public string GetChampionUri(bool freeToPlay)
        {
            return (freeToPlay) ? string.Format("{0}/champion?api_key={1}&freeToPlay=true", ApiLocation, ApiKey) : string.Format("{0}/champion?api_key={1}", ApiLocation, ApiKey);
        }

        #endregion

        #endregion
    }
}
