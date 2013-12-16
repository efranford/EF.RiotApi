using EF.RiotApi.Dto.Champion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.WebRequestResults
{
    /// <summary>
    /// The result of a champions api request
    /// </summary>
    public class ChampionsResult 
    {
        /// <summary>
        /// The list of champions
        /// </summary>
        [JsonProperty("champions")]
        public List<ChampionDto> Champions { get; set; }
    }
}
