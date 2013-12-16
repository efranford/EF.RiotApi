using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// The team stats data object
    /// </summary>
    public class TeamStatDetailDto
    {
        /// <summary>
        /// The average games played
        /// </summary>
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        /// <summary>
        /// The number of losses the team has
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// The teams max rating
        /// </summary>
        [JsonProperty("maxRating")]
        public int MaxRating { get; set; }

        /// <summary>
        /// The teams current rating
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// The teams seed rating
        /// </summary>
        [JsonProperty("seedRating")]
        public int SeedRating { get; set; }

        /// <summary>
        /// The team id
        /// </summary>
        [JsonProperty("teamId")]
        public TeamIdDto TeamId { get; set; }

        /// <summary>
        /// The team stat type
        /// </summary>
        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }

        /// <summary>
        /// Number of wins the team has
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
