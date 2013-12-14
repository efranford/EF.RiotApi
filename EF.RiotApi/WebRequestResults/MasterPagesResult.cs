using EF.RiotApi.Dto.Summoner.Masteries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.WebRequestResults
{
    public class MasterPagesResult
    {
        /// <summary>
        /// List of mastery pages associated with the summoner.
        /// </summary>
        [JsonProperty("pages")]
        public List<MasteryPageDto> Pages { get; set; }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
