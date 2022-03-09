using System.Net;
using System.IO;

namespace Services
{
    public class Service
    {
        private static string url = "https://jsonplaceholder.typicode.com/posts";

        public static string GetPost()
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            var httpResponse = (HttpWebResponse)request.GetResponse();

            using(var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
