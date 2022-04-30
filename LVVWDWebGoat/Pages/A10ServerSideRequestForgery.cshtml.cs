using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace LVVWDWebGoat.Pages
{
    public class A10ServerSideRequestForgeryModel : PageModel
    {
        private static HttpClient client = null;

        public string Response = "";

        public void OnGet()
        {
        }
        
        public void OnPost()
        {
            Response = "";
            var badUrl = Request.Form["badurl"];
            //var web = new WebClient();
            //ViewData["Response"] = web.DownloadString(badUrl);

            if (client == null)
            {
                HttpClientHandler handler = new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                };
                client = new HttpClient(handler);
            }
            //client.BaseAddress = new Uri(badUrl);
            HttpResponseMessage response = client.GetAsync(badUrl).Result;
            response.EnsureSuccessStatusCode();
            Response = response.Content.ReadAsStringAsync().Result;
        }
    }
}
