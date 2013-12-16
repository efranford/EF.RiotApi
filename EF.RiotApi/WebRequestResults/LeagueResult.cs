using EF.RiotApi.Dto.League;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.WebRequestResults
{
    /// <summary>
    /// The result of a league api request
    /// </summary>
    public class LeagueResult : Dictionary<string, LeagueDto> { }
}
