using EF.RiotApi.Caching;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EF.RiotApi.Client
{
    public class RiotWebRequest<T> where T : new()
    {
        public static async Task<T> CreateRequestAsync(string url)
        {
            var result = new T();
            var getRequest = (HttpWebRequest)WebRequest.Create(url);
            using(var getResponse = await getRequest.GetResponseAsync())
            using (var reader = new System.IO.StreamReader(getResponse.GetResponseStream()))
            {
                var responseText = reader.ReadToEnd();
                result = JsonConvert.DeserializeObject<T>(responseText);
            }
            return result;
        }

        public static T CreateRequest(string url)
        {
            var result = new T();
            var getRequest = (HttpWebRequest)WebRequest.Create(url);
            using(var getResponse = getRequest.GetResponse())
            using (var reader = new System.IO.StreamReader(getResponse.GetResponseStream()))
            {
                var responseText = reader.ReadToEnd();
                result = JsonConvert.DeserializeObject<T>(responseText);
            }
            return result;
        }
    }
}
