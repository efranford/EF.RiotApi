using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// A team roster
    /// </summary>
    public class RosterDto
    {
        /// <summary>
        /// The list of team member infoes
        /// </summary>
        [JsonProperty("memberList")]
        public List<TeamMemberInfoDto> MemberList { get; set; }
    }
}
