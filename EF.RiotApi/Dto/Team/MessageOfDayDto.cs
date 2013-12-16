using Newtonsoft.Json;
using System;

namespace EF.RiotApi.Dto.Team
{
    /// <summary>
    /// The message of the day
    /// </summary>
    public class MessageOfDayDto
    {
        /// <summary>
        /// The date the message was created
        /// </summary>
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }

        /// <summary>
        /// The message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The version
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
