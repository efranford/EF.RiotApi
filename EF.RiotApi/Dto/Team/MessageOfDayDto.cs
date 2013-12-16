using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Team
{
    public class MessageOfDayDto
    {
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        [JsonProperty("createDate")]
        public string Message { get; set; }

        [JsonProperty("createDate")]
        public int Version { get; set; }
    }
}
