using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Team
{
    public class TeamStatSummaryDto
    {
        [JsonProperty("teamId")]
        public TeamIdDto TeamId { get; set; }

        [JsonProperty("teamStatDetails")]
        public List<TeamStatDetailDto> TeamStatDetails { get; set; }
    }
}
