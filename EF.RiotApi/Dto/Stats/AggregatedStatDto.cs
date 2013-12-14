using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Stats
{
    public class AggregatedStatDto
    {
        /// <summary>
        /// Aggregated stat value.
        /// </summary>
        [JsonProperty("count")]
        int Count { get; set; }
        
        /// <summary>
        /// Aggregated stat type ID.
        /// </summary>
        [JsonProperty("id")]
        int Id { get; set; }
        
        /// <summary>
        /// Aggregated stat type name.
        /// </summary>
        [JsonProperty("name")]
        string Name { get; set; }
    }
}
