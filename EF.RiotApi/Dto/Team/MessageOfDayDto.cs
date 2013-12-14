using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
