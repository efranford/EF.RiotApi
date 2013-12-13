using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto
{
    public class GameDto
    {
        /// <summary>
        /// Champion ID associated with game.
        /// </summary>
        [JsonProperty("championId")]
        int ChampionId { get; set; }

        /// <summary>
        /// Date game was played specified as epoch milliseconds.
        /// </summary>
        [JsonProperty("createDate")]
        long CreateDate { get; set; }

        /// <summary>
        /// Human readable string representing date game was played.
        /// </summary>
        [JsonProperty("createDateStr")]
        string CreateDateStr { get; set; }

        /// <summary>
        /// Other players associated with the game.
        /// </summary>
        [JsonProperty("fellowPlayers")]
        List<PlayerDto> FellowPlayers { get; set; }

        /// <summary>
        /// Game ID.
        /// </summary>
        [JsonProperty("gameId")]
        long GameId { get; set; }

        /// <summary>
        /// Game mode.
        /// </summary>
        [JsonProperty("gameMode")]
        string GameMode { get; set; }

        /// <summary>
        /// Game type.
        /// </summary>
        [JsonProperty("gameType")]
        string GameType { get; set; }

        /// <summary>
        /// Invalid flag.
        /// </summary>
        [JsonProperty("invalid")]
        bool Invalid { get; set; }

        /// <summary>
        /// Level.
        /// </summary>
        [JsonProperty("level")]
        int Level { get; set; }

        /// <summary>
        /// Map ID.
        /// </summary>
        [JsonProperty("mapId")]
        int MapId { get; set; }

        /// <summary>
        /// ID of first summoner spell.
        /// </summary>
        [JsonProperty("spell1")]
        int Spell1 { get; set; }

        /// <summary>
        /// ID of second summoner spell.
        /// </summary>
        [JsonProperty("spell2")]
        int Spell2 { get; set; }

        /// <summary>
        /// Statistics associated with the game for this summoner.
        /// </summary>
        [JsonProperty("statistics")]
        List<RawStatDto> Statistics { get; set; }

        /// <summary>
        /// Game sub-type.
        /// </summary>
        [JsonProperty("subType")]
        string SubType { get; set; }

        /// <summary>
        /// Team ID associated with game.
        /// </summary>
        [JsonProperty("teamId")]
        int TeamId { get; set; }
    }
}
