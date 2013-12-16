using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// The result of a team stat summary api request
    /// </summary>
    public class TeamStatSummaryDto
    {
        /// <summary>
        /// The taam Id
        /// </summary>
        [JsonProperty("teamId")]
        public TeamIdDto TeamId { get; set; }

        /// <summary>
        /// A list of detailed team stats
        /// </summary>
        [JsonProperty("teamStatDetails")]
        public List<TeamStatDetailDto> TeamStatDetails { get; set; }
    }
}
