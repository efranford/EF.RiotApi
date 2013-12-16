using EF.RiotApi.Dto.Summoner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.WebRequestResults
{
    /// <summary>
    /// The result of requesting a summoner name list
    /// </summary>
    public class SummonerNameListResult
    {
        /// <summary>
        /// The list of summoner name information.
        /// </summary>
        [JsonProperty("summoners")]
        public List<SummonerNameDto> Summoners { get; set; }
    }
}
