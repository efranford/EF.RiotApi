using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Summoner.Runes
{
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
