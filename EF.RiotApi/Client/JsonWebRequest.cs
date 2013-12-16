using Newtonsoft.Json;
using System;
using System.Net;
#if NET45 || NET451
using System.Threading.Tasks;
#endif
namespace EF.RiotApi.Client
{
    public class JsonWebRequest<T> where T : new()
    {
#if NET45 || NET451
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
#endif

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
