using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Game
{
    /// <summary>
    /// The game data object
    /// </summary>
    public class GameDto
    {
        /// <summary>
        /// Champion ID associated with game.
        /// </summary>
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        /// <summary>
        /// Date game was played specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        /// <summary>
        /// Human readable string representing date game was played.
        /// </summary>
        [JsonProperty("createDateStr")]
        public string CreateDateStr { get; set; }

        /// <summary>
        /// Other players associated with the game.
        /// </summary>
        [JsonProperty("fellowPlayers")]
        public List<PlayerDto> FellowPlayers { get; set; }

        /// <summary>
        /// Game ID.
        /// </summary>
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        /// <summary>
        /// Game mode.
        /// </summary>
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        /// <summary>
        /// Game type.
        /// </summary>
        [JsonProperty("gameType")]
        public string GameType { get; set; }

        /// <summary>
        /// Invalid flag.
        /// </summary>
        [JsonProperty("invalid")]
        public bool Invalid { get; set; }

        /// <summary>
        /// Level.
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }

        /// <summary>
        /// Map ID.
        /// </summary>
        [JsonProperty("mapId")]
        public int MapId { get; set; }

        /// <summary>
        /// ID of first summoner spell.
        /// </summary>
        [JsonProperty("spell1")]
        public int Spell1 { get; set; }

        /// <summary>
        /// ID of second summoner spell.
        /// </summary>
        [JsonProperty("spell2")]
        public int Spell2 { get; set; }

        /// <summary>
        /// Statistics associated with the game for this summoner.
        /// </summary>
        [JsonProperty("statistics")]
        public List<RawStatDto> Statistics { get; set; }

        /// <summary>
        /// Game sub-type.
        /// </summary>
        [JsonProperty("subType")]
        public string SubType { get; set; }

        /// <summary>
        /// Team ID associated with game.
        /// </summary>
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}
