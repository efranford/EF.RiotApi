using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Stats
{
    public class AggregatedStatDto
    {
        /// <summary>
        /// Aggregated stat value.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        
        /// <summary>
        /// Aggregated stat type ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// Aggregated stat type name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
