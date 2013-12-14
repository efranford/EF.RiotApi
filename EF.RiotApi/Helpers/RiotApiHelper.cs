using EF.RiotApi.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Helpers
{
    public class RiotApiHelper
    {
        public static string ApiKey
        {
            get
            {
                return RiotWeb.API.ApiKey;
            }
        }
        public static string ApiLocation
        {
            get
            {
                return GetApiUrl();
            }
        }
        public static string ApiUrl 
        {
            get
            {
                return RiotWeb.API.ApiUrl;
            }
        }

        public static string ApiRegion
        {
            get
            {
                return RiotWeb.API.ApiRegion;
            }
        }
        public static string ApiVerision
        {
            get
            {
                return RiotWeb.API.ApiVerision;
            }
        }

        public static string GetApiUrl(string region = null, string version = null)
        {
            return string.Format("{0}/{1}/{2}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision);
        }

        public static string GetApiUri(string api, long summonerId = -1, string region = null, string version = null, string season = null, bool freeToPlay = false)
        {
            switch (api)
            {
                case "champion":
                    return (freeToPlay) ? string.Format("{0}/champion?api_key={1}&freeToPlay=true", ApiLocation, ApiKey) : string.Format("{0}/champion?api_key={1}", ApiLocation, ApiKey);
                case "league":
                    // I think riot means to have /lol in this url, but for now it's not there..
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}?api_key={5}", ApiUrl.Replace("/lol", string.Empty), region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
                case "game":
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}/recent?api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
                case "stats":
                    //https://prod.api.pvp.net/api/lol/na/v1.1/stats/by-summoner/32144/summary?season=SEASON3&api_key=733867e2-f9e4-4de3-be67-eab57bb62ee6
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}/summary?season={5}&api_key={6}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, season ?? string.Empty, ApiKey);
            }
            return string.Empty;
        }
    }
}
