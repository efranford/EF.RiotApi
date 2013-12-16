using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Team
{
    public class TeamIdDto
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }
}
