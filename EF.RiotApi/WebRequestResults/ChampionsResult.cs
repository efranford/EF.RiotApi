using EF.RiotApi.Dto;
using EF.RiotApi.Dto.Champion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.WebRequestResults
{
    public class ChampionsResult 
    {
        [JsonProperty("champions")]
        public List<ChampionDto> Champions { get; set; }
    }
}
