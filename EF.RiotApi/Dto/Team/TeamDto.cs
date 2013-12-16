using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Dto.Team
{
    public class TeamDto
    {
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("lastGameDate")]
        public string LastGameDate { get; set; }

        [JsonProperty("lastJoinDate")]
        public string LastJoinDate { get; set; }

        [JsonProperty("lastJoinedRankedTeamQueueDate")]
        public string LastJoinedRankedTeamQueueDate { get; set; }

        [JsonProperty("matchHistory")]
        public List<MatchHistorySummaryDto> MatchHistory { get; set; }

        [JsonProperty("messageOfDay")]
        public MessageOfDayDto MessageOfDay { get; set; }

        [JsonProperty("modifyDate")]
        public string ModifyDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roster")]
        public RosterDto Roster { get; set; }

        [JsonProperty("secondLastJoinDate")]
        public string SecondLastJoinDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("teamId")]
        public TeamIdDto TeamId { get; set; }

        [JsonProperty("teamStatSummary")]
        public TeamStatSummaryDto TeamStatSummary { get; set; }

        [JsonProperty("thirdLastJoinDate")]
        public string ThirdLastJoinDate { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
