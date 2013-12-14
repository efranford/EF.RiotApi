using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Team
{
    public class TeamIdDto
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }
}
