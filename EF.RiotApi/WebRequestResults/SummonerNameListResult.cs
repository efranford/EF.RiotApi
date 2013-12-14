using EF.RiotApi.Dto.Summoner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
