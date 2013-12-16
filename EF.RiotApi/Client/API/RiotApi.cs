using EF.RiotApi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Client.API
{
    public abstract class RiotApi
    {
        #region Properties

        public string ApiKey { get; set; }
        public string ApiUrl { get; set; }
        public string ApiRegion { get; set; }
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

        protected abstract string GetApiUri(string api, string method = null, long summonerId = -1, string region = null, string version = null, string season = null, bool freeToPlay = false, string summonerName = null, string summonerIds = null);
    }
}
