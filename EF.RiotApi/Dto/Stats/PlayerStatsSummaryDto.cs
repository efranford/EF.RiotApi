using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Stats
{
    public class PlayerStatsSummaryDto
    {
        /// <summary>
        /// List of aggregated stats.
        /// </summary>
        [JsonProperty("aggregatedStats")]
        List<AggregatedStatDto> AggregatedStats { get; set; }

        /// <summary>
        /// Number of losses for this queue type. Returned for ranked queue types only.
        /// </summary>
        [JsonProperty("losses")]
        int Losses { get; set; }

        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("modifyDate")]
        long ModifyDate { get; set; }

        /// <summary>
        /// Human readable string representing date stats were last modified.
        /// </summary>
        [JsonProperty("modifyDateStr")]
        string ModifyDateStr { get; set; }

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
        /// Unranked3x3)
        /// </summary>
        [JsonProperty("playerStatSummaryType")]
        string PlayerStatSummaryType { get; set; }

        /// <summary>
        /// Number of wins for this queue type.
        /// </summary>
        [JsonProperty("wins")]
        int Wins { get; set; }

    }
}
