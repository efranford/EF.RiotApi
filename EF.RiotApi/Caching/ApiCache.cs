using System;
using EF.RiotApi.Dto;
using EF.RiotApi.Dto.Champion;
using EF.RiotApi.Helpers;
using System.Collections.Generic;
using EF.RiotApi.Dto.Summoner;
using EF.RiotApi.Dto.Game;
using EF.RiotApi.Dto.League;
using EF.RiotApi.Dto.Team;
using EF.RiotApi.Dto.Stats;
using System.Linq;

namespace EF.RiotApi.Caching
{
    /// <summary>
    /// This class will hold caches of all of the Api data
    /// in an effort to reduce the number of api calls the 
    /// developer has to make
    /// </summary>
    public class ApiCache
    {
        #region Singleton

        private static volatile ApiCache instance;
        private static object instanceLock = new object();

        /// <summary>
        /// The instance of the Api Cache
        /// </summary>
        public static ApiCache Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(instanceLock)
                    {
                        if(instance == null)
                        {
                            instance = new ApiCache();
                        }
                    }
                }
                return instance;
            }
        }

        private ApiCache ()
        {
            CachingEnabled = ConfigurationHelper.GetConfigurationValue("CachingEnabled", "false") == "true" ? true : false;
            Champions = new List<ChampionDto>();
            RecentGames = new List<RecentGamesDto>();
            Summoners = new List<SummonerDto>();
        }

        #endregion 

        #region Properties

        /// <summary>
        /// The cache of summoners
        /// </summary>
        public List<SummonerDto> Summoners{ get; set; }

        /// <summary>
        /// The cache of recent games
        /// </summary>
        public List<RecentGamesDto> RecentGames { get; set; }

        /// <summary>
        /// The cache of champions
        /// </summary>
        public List<ChampionDto> Champions { get; set; }

        /// <summary>
        /// The cache of leagues
        /// </summary>
        public List<LeagueDto> Leagues{ get; set; }

        /// <summary>
        /// The cache of teams
        /// </summary>
        public List<TeamDto> Teams{ get; set; }

        /// <summary>
        /// The cache of teams
        /// </summary>
        public List<PlayerStatsSummaryDto> PlayerStatsSummary { get; set; }

        /// <summary>
        /// If caching is enabled or not
        /// </summary>
        public bool CachingEnabled { get; set; }

        #endregion

        internal List<GameDto> GetRecentSummonerGames(long summonerId)
        {
            return RecentGames.Where(g => g.SummonerId == summonerId).SelectMany(g=>g.Games).ToList();
        }

        internal void UpdateGames(GameDto game)
        {
            var result = RecentGames.Where(rg => rg.Games.Where(g => g.GameId == game.GameId).FirstOrDefault() != null).FirstOrDefault();
            if(result == null)
            {
                //RecentGames.
            }
        }
    }
}
