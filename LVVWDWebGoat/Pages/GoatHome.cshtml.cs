using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LVVWDWebGoat.Pages
{
    public class GoatHomeModel : PageModel
    {
        public void OnGet()
        {
            ViewData["user"] = Global.UserName;
        }
    }
}
