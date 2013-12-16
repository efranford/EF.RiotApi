using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Summoner.Masteries
{
    /// <summary>
    /// The talent data object
    /// </summary>
    public class TalentDto
    {
        /// <summary>
        /// Talent id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Talent name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Talent rank.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
