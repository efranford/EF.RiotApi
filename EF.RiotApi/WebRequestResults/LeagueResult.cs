using EF.RiotApi.Dto;
using EF.RiotApi.Dto.League;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.WebRequestResults
{
    public class LeagueResult : Dictionary<string, LeagueDto> { }
}
