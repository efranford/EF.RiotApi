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
            Console.ReadKey();
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
