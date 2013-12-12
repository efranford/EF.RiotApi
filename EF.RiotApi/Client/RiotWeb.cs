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
            ApiLocation = string.Format("{0}/{1}/{2}", ApiUrl, ApiRegion, ApiVerision);
        }

        #endregion

        #region Properties

        public string ApiLocation { get; set; }
        public string ApiKey { get; set; }
        public string ApiUrl { get; set; }
        public string ApiRegion { get; set; }
        public string ApiVerision { get; set; }
        
        #endregion

        #region Champion

        public async Task<List<ChampionDto>> GetChampionsAsync(bool freeToPlay = false)
        {
            if(ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return ApiCache.Instance.Champions;
            }
            ChampionsResult result = new ChampionsResult();
            var requestUri = GetChampionUri(freeToPlay);
            var getChampionsRequest = (HttpWebRequest)WebRequest.Create(GetChampionUri(freeToPlay));
            var getChampionsResponse = await getChampionsRequest.GetResponseAsync();
            using(var reader = new System.IO.StreamReader(getChampionsResponse.GetResponseStream()))
            {
                var responseText = reader.ReadToEnd();
                result = JsonConvert.DeserializeObject<ChampionsResult>(responseText);
            }
            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
            return result.Champions;
        }

        public List<ChampionDto> GetChampions(bool freeToPlay = false)
        {
            if (ApiCache.Instance.CachingEnabled && ApiCache.Instance.Champions.Count > 0)
            {
                return ApiCache.Instance.Champions;
            }
            ChampionsResult result = new ChampionsResult();
            var getChampionsRequest = (HttpWebRequest)WebRequest.Create(GetChampionUri(freeToPlay));
            var getChampionsResponse = getChampionsRequest.GetResponse();
            using (var reader = new System.IO.StreamReader(getChampionsResponse.GetResponseStream()))
            {
                var responseText = reader.ReadToEnd();
                result = JsonConvert.DeserializeObject<ChampionsResult>(responseText);
            }
            if (ApiCache.Instance.CachingEnabled)
            {
                ApiCache.Instance.Champions = result.Champions;
            }
            return result.Champions;
        }

        #endregion

        #region Helpers

        private string GetChampionUri(bool freeToPlay)
        {
            return (freeToPlay) ? string.Format("{0}/champion?api_key={1}&freeToPlay=true", ApiLocation, ApiKey) : string.Format("{0}/champion?api_key={1}", ApiLocation, ApiKey);
        }

        #endregion
    }
}
