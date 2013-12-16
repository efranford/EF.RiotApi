using System;
using EF.RiotApi.Dto;
using EF.RiotApi.Dto.Champion;
using EF.RiotApi.Helpers;
using System.Collections.Generic;

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
        }

        #endregion 

        #region Properties

        /// <summary>
        /// The list of champions
        /// </summary>
        public List<ChampionDto> Champions { get; set; }

        /// <summary>
        /// If caching is enabled or not
        /// </summary>
        public bool CachingEnabled { get; set; }

        #endregion
    }
}
