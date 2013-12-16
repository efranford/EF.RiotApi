using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// The team data object
    /// </summary>
    public class TeamDto
    {
        /// <summary>
        /// The date the team was created
        /// </summary>
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        /// <summary>
        /// The date of the last game the team played
        /// </summary>
        [JsonProperty("lastGameDate")]
        public string LastGameDate { get; set; }

        /// <summary>
        /// The last join date
        /// </summary>
        [JsonProperty("lastJoinDate")]
        public string LastJoinDate { get; set; }

        /// <summary>
        /// The last joined ranked team queue date
        /// </summary>
        [JsonProperty("lastJoinedRankedTeamQueueDate")]
        public string LastJoinedRankedTeamQueueDate { get; set; }

        /// <summary>
        /// The list of match history for the team
        /// </summary>
        [JsonProperty("matchHistory")]
        public List<MatchHistorySummaryDto> MatchHistory { get; set; }

        /// <summary>
        /// The teams message of the day
        /// </summary>
        [JsonProperty("messageOfDay")]
        public MessageOfDayDto MessageOfDay { get; set; }

        /// <summary>
        /// The last time the team was modified
        /// </summary>
        [JsonProperty("modifyDate")]
        public string ModifyDate { get; set; }

        /// <summary>
        /// The team name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The team roster
        /// </summary>
        [JsonProperty("roster")]
        public RosterDto Roster { get; set; }

        /// <summary>
        /// The second last join date
        /// </summary>
        [JsonProperty("secondLastJoinDate")]
        public string SecondLastJoinDate { get; set; }

        /// <summary>
        /// The team status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The team tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// The team id
        /// </summary>
        [JsonProperty("teamId")]
        public TeamIdDto TeamId { get; set; }

        /// <summary>
        /// The stat summary for the team
        /// </summary>
        [JsonProperty("teamStatSummary")]
        public TeamStatSummaryDto TeamStatSummary { get; set; }

        /// <summary>
        /// The third last join date
        /// </summary>
        [JsonProperty("thirdLastJoinDate")]
        public string ThirdLastJoinDate { get; set; }

        /// <summary>
        /// The timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
