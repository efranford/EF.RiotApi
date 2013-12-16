using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Game
{
    /// <summary>
    /// The player stats data object
    /// </summary>
    public class PlayerDto
    {
        /// <summary>
        /// Champion id associated with player.
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Summoner id associated with player.
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        /// Team id associated with player.
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}
