using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LVVWDWebGoat.Pages
{
    public class LogoutModel : PageModel
    {
        public void OnGet()
        {
            Global.IsLoggedIn = false;
            Global.UserName = null;
        }
    }
}
