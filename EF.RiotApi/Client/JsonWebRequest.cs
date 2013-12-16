using Newtonsoft.Json;
using System;
using System.Net;
#if NET45 || NET451
using System.Threading.Tasks;
#endif
namespace EF.RiotApi.Client
{
    /// <summary>
    /// This class creates web requests that parse a json response and 
    /// return the deserialized value.
    /// </summary>
    /// <typeparam name="T">The type to serialize the response to</typeparam>
    public class JsonWebRequest<T> where T : new()
    {
#if NET45 || NET451
        /// <summary>
        /// Creates an asynchronous (awaitable) request to the given url
        /// </summary>
        /// <param name="url">The url to make the request to</param>
        /// <returns>A task containing the deserialized response object</returns>
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
        /// <summary>
        /// Creates a synchronous request to the given url
        /// </summary>
        /// <param name="url">The url to make the request to</param>
        /// <returns>The deserialized response object</returns>
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
