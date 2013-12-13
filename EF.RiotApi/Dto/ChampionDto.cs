using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto
{
    public class ChampionDto
    {
        /// <summary>
        /// Champion ID
        /// </summary>
        [JsonProperty("id")]
        long Id { get; set; }

        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        [JsonProperty("active")]
        bool Active { get; set; }

        /// <summary>
        /// Champion attack rank.
        /// </summary>
        [JsonProperty("attackRank")]
        int AttackRank { get; set; }

        /// <summary>
        /// Bot enabled flag (for custom games).
        /// </summary>
        [JsonProperty("botEnabled")]
        bool BotEnabled { get; set; }

        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        [JsonProperty("botMmEnabled")]
        bool BotMmEnabled { get; set; }

        /// <summary>
        /// Champion defense rank.
        /// </summary>
        [JsonProperty("defenseRank")]
        int DefenseRank { get; set; }

        /// <summary>
        /// Champion difficulty rank.
        /// </summary>
        [JsonProperty("difficultyRank")]
        int DifficultyRank { get; set; }

        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        [JsonProperty("freeToPlay")]
        bool FreeToPlay { get; set; }

        /// <summary>
        /// Champion magic rank.
        /// </summary>
        [JsonProperty("magicRank")]
        int MagicRank { get; set; }

        /// <summary>
        /// Champion name.
        /// </summary>
        [JsonProperty("name")]
        string Name { get; set; }

        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        [JsonProperty("rankedPlayEnabled")]
        bool RankedPlayEnabled { get; set; }
    }
}
