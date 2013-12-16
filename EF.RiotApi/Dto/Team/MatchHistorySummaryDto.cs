using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// The match history summory data object
    /// </summary>
    public class MatchHistorySummaryDto
    {
        /// <summary>
        /// The number of assists in the match
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// The date of the match
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The number of deaths in the match
        /// </summary>
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// The game id
        /// </summary>
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        /// <summary>
        /// The game mode
        /// </summary>
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        /// <summary>
        /// If the match was invalid
        /// </summary>
        [JsonProperty("invalid")]
        public bool Invalid { get; set; }

        /// <summary>
        /// The number of kills in the match
        /// </summary>
        [JsonProperty("kills")]
        public int Kills { get; set; }

        /// <summary>
        /// The map id
        /// </summary>
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        
        /// <summary>
        /// The number of kills the opposing team had
        /// </summary>
        [JsonProperty("opposingTeamKills")]
        public int OpposingTeamKills { get; set; }

        /// <summary>
        /// The opposing team name
        /// </summary>
        [JsonProperty("opposingTeamName")]
        public string OpposingTeamName { get; set; }

        /// <summary>
        /// If the team won or not
        /// </summary>
        [JsonProperty("win")]
        public bool Win { get; set; }
    }
}
