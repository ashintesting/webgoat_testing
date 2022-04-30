using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LVVWDWebGoat.Pages
{
    public class A04ForgotPasswordModel : PageModel
    {
        private readonly IConfiguration Configuration;
        private string _question1;
        private string _answer1;
        private string _question2;
        private string _answer2;
        private string _question3;
        private string _answer3;
        private string _passWord;
        private string _userName;
        public bool showPassword = false;
        public bool tryAndFail = false;

        public A04ForgotPasswordModel(IConfiguration configuration) {
            Configuration = configuration;
            _question1 = Configuration["Question1"];
            _question2 = Configuration["Question2"];
            _question3 = Configuration["Question3"];
            _answer1 = Configuration["Answer1"];
            _answer2 = Configuration["Answer2"];
            _answer3 = Configuration["Answer3"];
            _userName = Configuration["UName"];
            _passWord = Configuration["Password"];
            
        }

        public void OnGet()
        {
            
            GetQuestions();
        }

        public void OnPost()
        {
            var username = Request.Form["username"];
            var answer1 = Request.Form["Answer1"];
            var answer2 = Request.Form["Answer2"];
            var answer3 = Request.Form["Answer3"];



            showPassword = DoSomethingWithInfo(username, answer1, answer2, answer3);
            ViewData["username"] = "Your username: " + _userName;
            ViewData["password"] = "Your password: " + _passWord;

            GetQuestions();
        }

        private void GetQuestions()
        {
            ViewData["Question1"] = _question1;
            ViewData["Question2"] = _question2;
            ViewData["Question3"] = _question3;
        }

        private bool DoSomethingWithInfo(string username, string answer1, string answer2, string answer3)
        {
            if (username == _userName && answer1 == _answer1 && answer2 == _answer2 && answer3 == _answer3)
            {
                tryAndFail = false;
                return true;
            }
            else {
                tryAndFail=true;    
                return false;
            }
        }
    }
}
