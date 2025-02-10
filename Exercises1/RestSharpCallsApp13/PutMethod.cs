using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpCallsApp
{
    public class PutMethod
    {
        public void PutMethodOne(int postId)
        {

            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest($"/posts/{postId}", Method.Put);
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                id = postId,
                title = "Updated Title",
                body = "This is an updated post body.",
                userId = 1
            };

            request.AddJsonBody(body);

            var response = client.Execute(request);
            Console.WriteLine("PUT Response:");
            Console.WriteLine(response.Content);
        }
    }
}
