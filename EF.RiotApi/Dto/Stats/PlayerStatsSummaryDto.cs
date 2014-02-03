using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Stats
{
    /// <summary>
    /// The player stats summary object
    /// </summary>
    public class PlayerStatsSummaryDto
    {
        /// <summary>
        /// List of aggregated stats.
        /// </summary>
        [JsonProperty("aggregatedStats")]
        public List<AggregatedStatDto> AggregatedStats { get; set; }

        /// <summary>
        /// Number of losses for this queue type. Returned for ranked queue types only.
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }

        /// <summary>
        /// Human readable string representing date stats were last modified.
        /// </summary>
        [JsonProperty("modifyDateStr")]
        public string ModifyDateStr { get; set; }

        /// <summary>
        /// Player stats summary type.
        /// Legal Values: 
        /// AramUnranked5x5
        /// CoopVsAI
        /// OdinUnranked
        /// RankedPremade3x3
        /// RankedPremade5x5
        /// RankedSolo5x5
        /// RankedTeam3x3
        /// RankedTeam5x5
        /// Unranked
        /// Unranked3x3
        /// </summary>
        [JsonProperty("playerStatSummaryType")]
        public string PlayerStatSummaryType { get; set; }

        /// <summary>
        /// Number of wins for this queue type.
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
