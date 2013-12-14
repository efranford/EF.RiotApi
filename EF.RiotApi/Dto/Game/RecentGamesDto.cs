using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Game
{
    public class RecentGamesDto
    {
        [JsonProperty("games")]
        public List<GameDto> Games { get; set; }

        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
