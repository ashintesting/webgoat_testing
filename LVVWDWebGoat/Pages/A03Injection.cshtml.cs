using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;

namespace LVVWDWebGoat.Pages
{
    public class A03InjectionModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var id = Request.Form["id"];
            // OWASP-A03 - Injection
            string connectionString = "data source=localhost;user id=webgoat_user;password=Top_Secret1";
            string sql = $"SELECT * FROM webgoat.dbo.hairstatus WHERE id = {id}";

            using (IDbConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                var cmd = dbConn.CreateCommand();
                cmd.CommandText = sql;
                var result = cmd.ExecuteReader();
                ViewData["Username"] = "";
                using (result)
                {
                    while (result.Read())
                    {
                        ViewData["Id"] = result.GetValue(0); // id
                        ViewData["Username"] = (ViewData["Username"] == "") ? result.GetValue(3) : ViewData["Username"] + ", " + result.GetValue(3); // username
                        ViewData["HairStatus"] = (ViewData["Username"].ToString().Contains(",")) ? "Ha! Ha! Ha! Pwned! Really, really bad hair day!" : result.GetValue(5) + " hair day";
                    }
                }
            }
        }
    }
}
