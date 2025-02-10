using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpCallsApp
{
    internal class GetMethod
    {
        public void GetMethodOne(int postId)
        {
            using var client = new RestClient("https://jsonplaceholder.typicode.com/");

            var request = new RestRequest($"/posts/{postId}", Method.Get);

            var response = client.Execute(request);
            Console.WriteLine("GET Response:");
            Console.WriteLine(response.Content);

        }
        


}
}
