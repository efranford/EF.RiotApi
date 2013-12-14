using EF.RiotApi.Caching;
using EF.RiotApi.Dto;
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

        #region Champion

        public async Task<ChampionsResult> GetChampionsAsync(bool freeToPlay = false)
        {
            if (ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return new ChampionsResult { Champions = ApiCache.Instance.Champions };
            }

            var championsRequest = JsonWebRequest<ChampionsResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"chapmion", freeToPlay:freeToPlay));
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

            var result = JsonWebRequest<ChampionsResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "chapmion", freeToPlay: freeToPlay));

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
            var recentGamesResult = JsonWebRequest<RecentGamesResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"game", region:region, summonerId:summonerId));
            var result = await recentGamesResult;
            return result;
        }

        public RecentGamesResult GetGamesBySummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<RecentGamesResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "game", region: region, summonerId: summonerId));
            return result;
        }

        #endregion

        #region League

        public async Task<LeagueResult> GetLeagueBySummonerAsync(long summonerId, string region = null)
        {
            var recentGamesResult = JsonWebRequest<LeagueResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"league", region:region, summonerId:summonerId, version:"v2.1"));
            var result = await recentGamesResult;
            return result;
        }

        public LeagueResult GetLeagueBySummoner(long summonerId, string region = null)
        {
            var result = JsonWebRequest<LeagueResult>.CreateRequest(RiotApiHelper.GetApiUri(api:"league", region:region, summonerId:summonerId, version:"v2.1"));
            return result;
        }

        #endregion

        #region Stats

        public async Task<PlayerStatsSummaryResult> GetPlayerStatsSummaryAsync(long summonerId, string region = null, string season = null)
        {
            var recentGamesResult = JsonWebRequest<PlayerStatsSummaryResult>.CreateRequestAsync(RiotApiHelper.GetApiUri(api:"stats", region:region, summonerId:summonerId, season:season));
            var result = await recentGamesResult;
            return result;
        }

        public PlayerStatsSummaryResult GetPlayerStatsSummary(long summonerId, string region = null, string season = null)
        {
            var result = JsonWebRequest<PlayerStatsSummaryResult>.CreateRequest(RiotApiHelper.GetApiUri(api: "stats", region: region, summonerId: summonerId, season: season));
            return result;
        }

        #endregion
    }
}
