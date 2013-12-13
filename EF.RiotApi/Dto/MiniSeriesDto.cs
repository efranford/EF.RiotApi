using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto
{
    public class MiniSeriesDto
    {
        [JsonProperty("losses")]
        int Losses { get; set; }

        [JsonProperty("progress")]
        string Progress { get; set; }

        [JsonProperty("target")]
        int Target { get; set; }

        [JsonProperty("timeLeftToPlayMillis")]
        long TimeLeftToPlayMillis { get; set; }

        [JsonProperty("wins")]
        int	Wins { get; set; }
    }
}
