using EF.RiotApi.Dto.Stats;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.WebRequestResults
{
    public class PlayerStatsSummaryResult
    {
        /// <summary>
        /// List of player stats summaries associated with the summoner.
        /// </summary>
        [JsonProperty("playerStatSummaries")]
        public List<PlayerStatsSummaryDto> PlayerStatSummaries;

        /// <summary>
        /// Summoner ID
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId;
    }
}
