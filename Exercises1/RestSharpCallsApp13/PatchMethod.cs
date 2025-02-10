using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpCallsApp
{
    public class PatchMethod
    {
        public void PatchMethodOne(int postId)
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest($"/posts/{postId}", Method.Patch);
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                title = "Patched Title"
            };

            request.AddJsonBody(body);

            var response = client.Execute(request);
            Console.WriteLine("PATCH Response:");
            Console.WriteLine(response.Content);

        }

    }
}
