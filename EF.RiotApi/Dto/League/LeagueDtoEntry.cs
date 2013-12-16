using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.League
{
    /// <summary>
    /// The league data object
    /// </summary>
    public class LeagueDtoEntry
    {
        /// <summary>
        /// If the player or team is new to the league
        /// </summary>
        [JsonProperty("isFreshBlood")]
        public bool IsFreshBlood { get; set; }

        /// <summary>
        /// If the player or team is on a hot streak
        /// </summary>
        [JsonProperty("isHotStreak")]
        public bool IsHotStreak { get; set; }

        /// <summary>
        /// If the player or team is inactive
        /// </summary>
        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }

        /// <summary>
        /// If the player or team is a veteran of this league (over 100 played games in it)
        /// </summary>
        [JsonProperty("isVeteran")]
        public bool IsVeteran { get; set; }

        /// <summary>
        /// The last time the player or team played in this league
        /// </summary>
        [JsonProperty("lastPlayed")]
        public long LastPlayed { get; set; }

        /// <summary>
        /// The league name
        /// </summary>
        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }

        /// <summary>
        /// The number of league points the player or team has
        /// </summary>
        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        /// <summary>
        /// The number of losses the player or team has
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// The current miniseries data for the player or team
        /// </summary>
        [JsonProperty("miniSeries")]
        public MiniSeriesDto MiniSeries { get; set; }

        /// <summary>
        /// The player or team id
        /// </summary>
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        /// <summary>
        /// The player or team name
        /// </summary>
        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        /// <summary>
        /// The queue type
        /// </summary>
        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        /// <summary>
        /// The current rank of the player or team
        /// </summary>
        [JsonProperty("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// The current tier of the player or team
        /// </summary>
        [JsonProperty("tier")]
        public string Tier { get; set; }
        
        /// <summary>
        /// The amount of time until decay
        /// </summary>
        [JsonProperty("timeUntilDecay")]
        public long TimeUntilDecay { get; set; }

        /// <summary>
        /// The number of wins the player or team has
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
