using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Team
{
    public class RosterDto
    {
        [JsonProperty("memberList")]
        public List<TeamMemberInfoDto> MemberList { get; set; }
    }
}
