using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.League
{
    public class LeagueDtoEntry
    {
        [JsonProperty("isFreshBlood")]
        bool IsFreshBlood { get; set; }

        [JsonProperty("isHotStreak")]
        bool IsHotStreak { get; set; }

        [JsonProperty("isInactive")]
        bool IsInactive { get; set; }

        [JsonProperty("isVeteran")]
        bool IsVeteran { get; set; }

        [JsonProperty("lastPlayed")]
        long LastPlayed { get; set; }

        [JsonProperty("leagueName")]
        string LeagueName { get; set; }

        [JsonProperty("leaguePoints")]
        int LeaguePoints { get; set; }

        [JsonProperty("losses")]
        int Losses { get; set; }

        [JsonProperty("miniSeries")]
        MiniSeriesDto MiniSeries { get; set; }

        [JsonProperty("playerOrTeamId")]
        string PlayerOrTeamId { get; set; }

        [JsonProperty("playerOrTeamName")]
        string PlayerOrTeamName { get; set; }

        [JsonProperty("queueType")]
        string QueueType { get; set; }

        [JsonProperty("rank")]
        string Rank { get; set; }

        [JsonProperty("tier")]
        string Tier { get; set; }

        [JsonProperty("timeUntilDecay")]
        long TimeUntilDecay { get; set; }

        [JsonProperty("wins")]
        int Wins { get; set; }
    }
}
