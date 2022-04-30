using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LVVWDWebGoat.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IConfiguration Configuration;
        private string _userName;
        private string _passWord;
        private bool _loggedIn = false;

        public LoginModel(IConfiguration configuration) { 
            Configuration = configuration;
            _userName = Configuration["UName"];
            _passWord = Configuration["Password"];
        }

        public void OnGet()
        {
            

        }

        public IActionResult OnPostLogin(string username, string password) {
            if (_userName == username && _passWord == password)
            {
                Global.IsLoggedIn = true;
                Global.UserName = username;
                return RedirectToPage("GoatHome");
            }
            if (_userName != username) { 

            }
            return null;
        }
    }
}
