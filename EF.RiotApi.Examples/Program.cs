using EF.RiotApi.Dto.League;
using EF.RiotApi.Dto.Summoner;
using EF.RiotApi.WebRequestResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Examples
{
    class Program
    {
        /// <summary>
        /// A simple program that pulls down the summoner information and displays their league info
        /// </summary>
        /// <param name="args">Not implemented</param>
        static void Main(string[] args)
        {
            // Get the summoner
            var summoner = EF.RiotApi.Client.API.SummonerApi.Instance.GetSummonerAsync("Dome").Result;
            // Get the summoner's league info (helper method)
            var leagues =  GetSummonerLeagues(summoner);
            // Go through each entry 
            foreach(var league in leagues)
            {
                // league.key is going to be the ID for that league.  league.value is the actual DTO for the league.
                var leagueInfo = league.Value;
                Console.WriteLine("Summoner league info - {0} {1} {2}", leagueInfo.Name, leagueInfo.Queue, leagueInfo.Tier);
            }

            // Only pull out the league tier info for the queue type 
            var soloq = GetTierForQueue(leagues, Queue.RANKED_SOLO_5x5);
            Console.WriteLine("Solo Q 5v5 Tier = " + (soloq == null ? "Unranked" : soloq.Tier));

             // Only pull out the league tier info for the queue type 
             var threeVThree = GetTierForQueue(leagues, Queue.RANKED_TEAM_3x3);
            Console.WriteLine("3v3 Tier = " + (threeVThree == null ? "Unranked" : threeVThree.Tier));

             // Only pull out the league tier info for the queue type 
             var fiveVFive = GetTierForQueue(leagues, Queue.RANKED_TEAM_5x5);
            Console.WriteLine("Ranked Team 5v5 Tier = " + (fiveVFive == null ? "Unranked" : fiveVFive.Tier));

            // Wait for input before closing
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the league information out of the leagues for the given queue
        /// 
        /// Disclaimer: This only takes the first league info. If there are multiple
        /// leagues (e.g is a member of multiple ranked 3v3 or 5v5 teams) they will have
        /// more than one entry that should be handled.
        /// </summary>
        /// <param name="leagues">The leagues dto</param>
        /// <param name="queue">Which queue you are looking for</param>
        /// <returns></returns>
        private static LeagueDto GetTierForQueue(LeagueResult leagues, Queue queue)
        {
            return leagues.Where(l => l.Value.Queue == queue.ToString()).Select(l => l.Value).FirstOrDefault();
        }

        /// <summary>
        /// Gets the summoner's league infoby summoner dto
        /// </summary>
        /// <param name="summoner">The summoner dto</param>
        /// <returns>The league result</returns>
        private static LeagueResult GetSummonerLeagues(SummonerDto summoner)
        {
            return EF.RiotApi.Client.API.LeagueApi.Instance.GetLeagueBySummonerAsync(summoner.Id).Result;
        }

        /// <summary>
        /// Gets the summoner's league info by summoner id (long)
        /// </summary>
        /// <param name="summonerId">The summoner id</param>
        /// <returns>The league result</returns>
        private static LeagueResult GetSummonerLeagues(long summonerId)
        {
            return EF.RiotApi.Client.API.LeagueApi.Instance.GetLeagueBySummonerAsync(summonerId).Result;
        }
    }
}
