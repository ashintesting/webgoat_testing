using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace LVVWDWebGoat.Pages
{
    public class PayLoad
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }

    public class A08DataIntegrityFailureModel : PageModel
    {
        public string MessageReceived = "";

        public void OnGet()
        {
            var payLoad = new PayLoad()
            {
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = new DateTime(1970, 1, 1)
            };

            ViewData["PayLoad"] = JsonConvert.SerializeObject(payLoad);
        }

        public void OnPost()
        {
            var request = Request.Form["PayLoad"];
            var payLoad = JsonConvert.DeserializeObject(request);
            MessageReceived = JsonConvert.SerializeObject(DoSomethingWithPayload(payLoad));
        }

        private Object DoSomethingWithPayload(Object payLoad)
        {
            var jsonResult = JsonConvert.SerializeObject(payLoad);

            return jsonResult;
        }
    }
}
