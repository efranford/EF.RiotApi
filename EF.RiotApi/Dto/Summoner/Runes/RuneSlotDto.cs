using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Summoner.Runes
{
    /// <summary>
    /// The rune slot data object
    /// </summary>
    public class RuneSlotDto
    {
        /// <summary>
        /// Rune associated with the rune slot.
        /// </summary>
        [JsonProperty("rune")]
        public RuneDto Rune { get; set; }

        /// <summary>
        /// Rune slot ID.
        /// </summary>
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }
    }
}
