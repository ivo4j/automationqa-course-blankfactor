using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpCallsApp
{
    internal class DeleteMethod
    {
        public void DeleteMethodOne(int postId)
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest($"/posts/{postId}", Method.Delete);

            var response = client.Execute(request);
            Console.WriteLine("DELETE Response:");
            Console.WriteLine(response.Content);
        }
    }
}
