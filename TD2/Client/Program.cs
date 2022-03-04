using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Client
{
    class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            while (true)
            {
                string a = Console.ReadLine();
                httpClient.DefaultRequestHeaders.Accept.Clear();
                string result = await httpClient.GetStringAsync("http://localhost:8080/incr?val=" + a);
                // var js = new System.Web.Script.Serialization.JavaScriptSerializer();
                // var jsonObject = js.Deserialize(result, typeof(object));
                
                Console.WriteLine(result);

                // Console.WriteLine(result);
            }
        }
    }
}