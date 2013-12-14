using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Team
{
    public class TeamStatDetailDto
    {
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("maxRating")]
        public int MaxRating { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("seedRating")]
        public int SeedRating { get; set; }

        [JsonProperty("teamId")]
        public TeamIdDto TeamId { get; set; }

        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
