using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Helpers
{
    internal class ConfigurationHelper
    {
        public static string GetConfigurationValue(string key, string valueIfNull)
        {
            string result = string.Empty;
            if(string.IsNullOrEmpty(result = ConfigurationManager.AppSettings[key]))
            {
                if (string.IsNullOrEmpty(valueIfNull))
                {
                    throw new Exception(string.Format("You must specify a value for {0} in your app/web.config file.", key), new KeyNotFoundException(key));
                }
                else
                {
                    return valueIfNull;
                }
            }
            else
            {
                return result;
            }
        }
    }
}
