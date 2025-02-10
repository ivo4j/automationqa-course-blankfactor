using Newtonsoft.Json.Linq;
using RestSharp;

namespace RestSharpCallsApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int postId = 1; // Example post ID for PUT, PATCH, and DELETE
            Console.WriteLine("Select one method between 1 and 4:");
            Console.WriteLine("1. Get ");
            Console.WriteLine("2. Post - method 1");
            Console.WriteLine("3. Post - method 2");
            Console.WriteLine("4. Put");
            Console.WriteLine("5. Patch");
            Console.WriteLine("6. Delete");
            bool res = int.TryParse(Console.ReadLine(), out int selection);

            switch (selection)
            {
                case 1:
                    var getMethod = new GetMethod();
                    getMethod.GetMethodOne(postId);
                    break;
                case 2:
                    var postRequest = new PostRequest();
                    postRequest.PostMethodOne();
                    break;
                case 3:
                    var postRequest2 = new PostRequest();
                    postRequest2.RestMethodTwo();
                    break;
                case 4:
                    var putRequest = new PutMethod();
                    putRequest.PutMethodOne(postId);
                    break;
                case 5:
                    var patchMethod = new PatchMethod();
                    patchMethod.PatchMethodOne(postId);
                    break;
                case 6:
                    var deleteMethod = new DeleteMethod();
                    deleteMethod.DeleteMethodOne(postId);
                    break;
            }



            
        }
    }
}
