using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.League
{
    /// <summary>
    /// The league data object
    /// </summary>
    public class LeagueDto
    {
        /// <summary>
        /// The league name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)
        /// </summary>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// (legal values: CHALLENGER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }  

        /// <summary>
        /// The timestamp for this query
        /// </summary>
        [JsonProperty("timeStamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// The information entries for the league
        /// </summary>
        [JsonProperty("entries")]
        public List<LeagueDtoEntry> Entries { get; set; }
    }
}
