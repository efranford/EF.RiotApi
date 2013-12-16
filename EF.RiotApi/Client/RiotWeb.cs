using System;
using EF.RiotApi.Client.API;

namespace EF.RiotApi.Client
{
    /// <summary>
    /// RiotWeb wraps all the apis that are a part of the Developer Api.
    /// It has properties that allow quick acess to all the different apis
    /// </summary>
    public class RiotWeb
    {
        #region Singleton

        private static volatile RiotWeb instance;
        private static object instanceLock = new object();

        /// <summary>
        /// Gets the instance of the RiotWeb wrapper
        /// </summary>
        public static RiotWeb API
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new RiotWeb();
                        }
                    }
                }
                return instance;
            }
        }

        #endregion
        
        /// <summary>
        /// Returns the instance of the Champion Api
        /// </summary>
        public ChampionApi Champion
        {
            get
            {
                return ChampionApi.Instance;
            }
        }

        /// <summary>
        /// Returns the instance of the Game Api
        /// </summary>
        public GameApi Game
        {
            get
            {
                return GameApi.Instance;
            }
        }
        /// <summary>
        /// Returns the instance of the League Api
        /// </summary>
        public LeagueApi League
        {
            get
            {
                return LeagueApi.Instance;
            }
        }

        /// <summary>
        /// Returns the instance of the Stats Api
        /// </summary>
        public StatsApi Stats
        {
            get
            {
                return StatsApi.Instance;
            }
        }

        /// <summary>
        /// Returns the instance of the Summoner Api
        /// </summary>
        public SummonerApi Summoner
        {
            get
            {
                return SummonerApi.Instance;
            }
        }

        /// <summary>
        /// Returns the instance of the Team Api
        /// </summary>
        public TeamApi Team
        {
            get
            {
                return TeamApi.Instance;
            }
        }

    }
}
