using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpCallsApp
{
    internal class PostRequest
    {
        public void PostMethodOne()
        {
            using var httpClient = new RestClient("https://jsonplaceholder.typicode.com/posts");
            var payload = new JObject
             {
                 { "title", "some cool title"},
                 { "body", "some cool body" }

              };

           
            var request = new RestRequest();

            request.AddStringBody(payload.ToString(), DataFormat.Json);

            var res = httpClient.PostAsync(request).Result;
            Console.WriteLine(res.Content);

            
        }

        public void RestMethodTwo()
        {
            using var httpClient = new RestClient("https://jsonplaceholder.typicode.com/posts");
            

            var post = new MyPost()
            {
                Title = "some cool title",
                Body = "some cool body"
            };
            var request = new RestRequest();


            request.AddJsonBody(post);

            var res = httpClient.PostAsync(request).Result;
            Console.WriteLine(res.Content);

            //request.AddJsonBody(post);
        }
    }
}
