using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// Contains information about the team member
    /// </summary>
    public class TeamMemberInfoDto
    {
        /// <summary>
        /// The date the team member was invited
        /// </summary>
        [JsonProperty("inviteDate")]
        public string InviteDate { get; set; }
        
        /// <summary>
        /// The date the team member joined
        /// </summary>
        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }
        
        /// <summary>
        /// The team members player id
        /// </summary>
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }

        /// <summary>
        /// The team members status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
