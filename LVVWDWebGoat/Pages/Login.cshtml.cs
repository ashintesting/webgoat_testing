using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LVVWDWebGoat.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IConfiguration Configuration;

        private IEnumerable<IConfigurationSection> _users;
        private string _userName;
        private string _passWord;

        Dictionary<string, string> users = new Dictionary<string, string>();

        public LoginModel(IConfiguration configuration)
        {
            Configuration = configuration;
            _users = Configuration.GetSection("Credentials").GetChildren();
            

            foreach (IConfigurationSection user in _users) { 
                var myUser = user["UName"];
                var myPassword = user["Password"];
                users.Add(myUser, myPassword);
            }

        }

        public void OnGet()
        {


        }

        public IActionResult OnPostLogin(string username, string password)
        {
            KeyValuePair<string, string> myKeyValuePair = new KeyValuePair<string, string>(username, password);

            if (users.Contains(myKeyValuePair))
            {
                Global.IsLoggedIn = true;
                Global.UserName = username;
                if (Global.UserName == "admin") Global.IsAdmin = true;
                return RedirectToPage("GoatHome");
            }
            if (_userName != username)
            {

            }
            return null;
        }
    }
}
