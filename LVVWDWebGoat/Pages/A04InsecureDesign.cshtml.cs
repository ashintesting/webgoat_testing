using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LVVWDWebGoat.Pages
{
    public class A04InsecureDesignModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var username = Request.Form["username"];
            var forgot = Request.Form["forgot"];
            var password = Request.Form["password"];

            ViewData["username"] = username;
            if (forgot.ToString().ToUpper() == "ON")
            {

            }
        }
    }
}
