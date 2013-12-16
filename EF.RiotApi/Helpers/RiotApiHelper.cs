using EF.RiotApi.Client;
using System;

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

        public static string GetApiUri(string api, string method = null, long summonerId = -1, string region = null, string version = null, string season = null, bool freeToPlay = false, string summonerName = null, string summonerIds = null)
        {
            switch (api)
            {
                case "champion":
                    return string.Format("{0}/{1}/{2}/{3}?freeToPlay={4}&api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, freeToPlay, ApiKey);
                case "league":
                case "team":
                // I think riot means to have /lol in this url, but for now it's not there..
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}?api_key={5}", ApiUrl.Replace("/lol", string.Empty), region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
                case "game":
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}/recent?api_key={5}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, ApiKey);
                case "stats":
                    return string.Format("{0}/{1}/{2}/{3}/by-summoner/{4}/summary?season={5}&api_key={6}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, season ?? string.Empty, ApiKey);
                case "summoner":
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
                        if(method == "name")
                        {
                            return string.Format("{0}/{1}/{2}/{3}/{4}/{5}?api_key={6}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerIds, method, ApiKey);
                        }
                        else
                        { 
                            return string.Format("{0}/{1}/{2}/{3}/{4}/{5}?api_key={6}", ApiUrl, region ?? ApiRegion, version ?? ApiVerision, api, summonerId, method, ApiKey);
                        }
                    }
            }
            return string.Empty;
        }
    }
}
