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
        public bool IsFreshBlood { get; set; }

        [JsonProperty("isHotStreak")]
        public bool IsHotStreak { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("isVeteran")]
        public bool IsVeteran { get; set; }

        [JsonProperty("lastPlayed")]
        public long LastPlayed { get; set; }

        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }

        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("miniSeries")]
        public MiniSeriesDto MiniSeries { get; set; }

        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [JsonProperty("queueType")]
        public string QueueType { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("timeUntilDecay")]
        public long TimeUntilDecay { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
