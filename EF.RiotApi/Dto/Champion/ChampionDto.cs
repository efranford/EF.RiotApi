using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Champion
{
    public class ChampionDto
    {
        /// <summary>
        /// Champion ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Champion attack rank.
        /// </summary>
        [JsonProperty("attackRank")]
        public int AttackRank { get; set; }

        /// <summary>
        /// Bot enabled flag (for custom games).
        /// </summary>
        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }

        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        [JsonProperty("botMmEnabled")]
        public bool BotMmEnabled { get; set; }

        /// <summary>
        /// Champion defense rank.
        /// </summary>
        [JsonProperty("defenseRank")]
        public int DefenseRank { get; set; }

        /// <summary>
        /// Champion difficulty rank.
        /// </summary>
        [JsonProperty("difficultyRank")]
        public int DifficultyRank { get; set; }

        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }

        /// <summary>
        /// Champion magic rank.
        /// </summary>
        [JsonProperty("magicRank")]
        public int MagicRank { get; set; }

        /// <summary>
        /// Champion name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }
    }
}
