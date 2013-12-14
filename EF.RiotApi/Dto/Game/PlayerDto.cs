using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Game
{
    public class PlayerDto
    {
        /// <summary>
        /// Champion id associated with player.
        /// </summary>
        [JsonProperty("championId")]
        int ChampionId { get; set; }

        /// <summary>
        /// Summoner id associated with player.
        /// </summary>
        [JsonProperty("summonerId")]
        long SummonerId { get; set; }

        /// <summary>
        /// Team id associated with player.
        /// </summary>
        [JsonProperty("teamId")]
        int TeamId { get; set; }
    }
}
