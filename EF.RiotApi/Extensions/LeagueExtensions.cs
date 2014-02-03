using EF.RiotApi.Dto.League;
using EF.RiotApi.Dto.League.Types;
using EF.RiotApi.WebRequestResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Extensions
{
    /// <summary>
    /// Extensions for the League classes
    /// </summary>
    public static class LeagueExtensions
    {
        /// <summary>
        /// Returns the RANKED_SOLO_5x5 LeagueDto information
        /// </summary>
        /// <param name="leagues">The leagues object to pull from</param>
        /// <returns>The RANKED_SOLO_5x5 LeagueDto information or NULL</returns>
        public static LeagueDto GetSoloQLeagueInfo(this LeagueResult leagues)
        {
            return leagues.Where(l => l.Value.Queue == Queue.RANKED_SOLO_5x5.ToString()).FirstOrDefault().Value;
        }

        /// <summary>
        /// Gets the RANKED_TEAM_3x3 league information.  
        /// </summary>
        /// <param name="leagues">The leagues object to pull from</param>
        /// <returns>Returns multiple leagues if the summoner is on multiple teams</returns>
        public static List<LeagueDto> Get3v3LeagueInfo(this LeagueResult leagues) 
        {
            return leagues.Where(l => l.Value.Queue == Queue.RANKED_TEAM_3x3.ToString()).Select(l=>l.Value).ToList();
        }

        /// <summary>
        /// Gets the RANKED_TEAM_5x5 league information.  
        /// </summary>
        /// <param name="leagues">The leagues object to pull from</param>
        /// <returns>Returns multiple leagues if the summoner is on multiple teams</returns>
        public static List<LeagueDto> Get5v5LeagueInfo(this LeagueResult leagues)
        {
            return leagues.Where(l => l.Value.Queue == Queue.RANKED_TEAM_5x5.ToString()).Select(l => l.Value).ToList();
        }
    }
}
