using EF.RiotApi.Dto;
using EF.RiotApi.Dto.Champion;
using EF.RiotApi.Helpers;
using System;
using System.Collections.Generic;

namespace EF.RiotApi.Caching
{
    public class ApiCache
    {
        #region Singleton

        private static volatile ApiCache instance;
        private static object instanceLock = new object();

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

        public List<ChampionDto> Champions { get; set; }
        public bool CachingEnabled { get; set; }

        #endregion
    }
}
