using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Summoner
{
    /// <summary>
    /// The summoner name data object
    /// </summary>
    public class SummonerNameDto
    {
        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Summoner name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
