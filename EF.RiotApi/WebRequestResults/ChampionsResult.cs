using EF.RiotApi.Dto.Champion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.WebRequestResults
{
    public class ChampionsResult 
    {
        [JsonProperty("champions")]
        public List<ChampionDto> Champions { get; set; }
    }
}
