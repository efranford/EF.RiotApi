using System;
using EF.RiotApi.Helpers;

namespace EF.RiotApi.Client.API
{
    /// <summary>
    /// The base class for all riot apis
    /// </summary>
    public abstract class RiotApi
    {
        #region Properties
        /// <summary>
        /// The Api Key
        /// Get one at http://developer.riotgames.com/
        /// </summary>
        public string ApiKey { get; set; }
        
        /// <summary>
        /// The Api Url
        /// </summary>
        public string ApiUrl { get; set; }
        
        /// <summary>
        /// The Api Region
        /// </summary>
        public string ApiRegion { get; set; }
        
        /// <summary>
        /// The Api Version
        /// </summary>
        public string ApiVerision { get; set; }

        #endregion

        internal RiotApi()
        {
            ApiKey = ConfigurationHelper.GetConfigurationValue("ApiKey", null);
            ApiUrl = ConfigurationHelper.GetConfigurationValue("ApiUrl", "https://prod.api.pvp.net/api/lol");
            ApiRegion = ConfigurationHelper.GetConfigurationValue("ApiRegion", "na");
            ApiVerision = ConfigurationHelper.GetConfigurationValue("ApiVerision", "v1.1");
        }

        internal RiotApi(string url, string region, string version)
        {
            ApiKey = ConfigurationHelper.GetConfigurationValue("ApiKey", null);
            ApiUrl = url;
            ApiRegion = region;
            ApiVerision = version;
        }

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
        protected abstract string GetApiUri(string api, string method = null, long summonerId = -1, string region = null, string version = null, string season = null, bool freeToPlay = false, string summonerName = null, string summonerIds = null);
    }
}
