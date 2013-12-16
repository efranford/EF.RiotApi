using EF.RiotApi.Dto.Summoner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.WebRequestResults
{
    public class SummonerNameListResult
    {
        /// <summary>
        /// The list of summoner name information.
        /// </summary>
        [JsonProperty("summoners")]
        public List<SummonerNameDto> Summoners { get; set; }
    }
}
