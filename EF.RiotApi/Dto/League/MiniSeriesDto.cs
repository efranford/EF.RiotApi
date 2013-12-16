using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.League
{
    /// <summary>
    /// The miniseries data object
    /// </summary>
    public class MiniSeriesDto
    {
        /// <summary>
        /// The number of losses in the miniseries
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// The progress of the miniseries
        /// </summary>
        [JsonProperty("progress")]
        public string Progress { get; set; }

        /// <summary>
        /// Teh target for the miniseries
        /// </summary>
        [JsonProperty("target")]
        public int Target { get; set; }

        /// <summary>
        /// The time left to complete the miniseries
        /// </summary>
        [JsonProperty("timeLeftToPlayMillis")]
        public long TimeLeftToPlayMillis { get; set; }

        /// <summary>
        /// The number of wins in the miniseries
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
