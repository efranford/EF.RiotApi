using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// The team id data object
    /// </summary>
    public class TeamIdDto
    {
        /// <summary>
        /// The full team id
        /// </summary>
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }
}
