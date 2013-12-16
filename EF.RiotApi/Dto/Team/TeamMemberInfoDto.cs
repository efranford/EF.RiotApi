using Newtonsoft.Json;
using System;

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
