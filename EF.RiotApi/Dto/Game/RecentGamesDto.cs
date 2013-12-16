using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Game
{
    /// <summary>
    /// The recent games data object
    /// </summary>
    public class RecentGamesDto
    {
        /// <summary>
        /// The lis tof recent games
        /// </summary>
        [JsonProperty("games")]
        public List<GameDto> Games { get; set; }

        /// <summary>
        /// The summoner id who played the games
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
