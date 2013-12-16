using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Game
{
    public class RawStatDto
    {
        /// <summary>
        /// Raw stat ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Raw stat name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Raw stat value.
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
