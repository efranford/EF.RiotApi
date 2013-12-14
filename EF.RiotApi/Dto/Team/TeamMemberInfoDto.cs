using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Dto.Team
{
    public class TeamMemberInfoDto
    {
        [JsonProperty("inviteDate")]
        public string InviteDate { get; set; }
        
        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }
        
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
