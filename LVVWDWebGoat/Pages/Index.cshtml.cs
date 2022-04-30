using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;

namespace LVVWDWebGoat.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // OWASP-A02 - Cryptographic Failure (hard-coded password)
            string connectionString = "data source=localhost;user id=webgoat_user;password=Top_Secret1";
            string sql = @"SELECT GETDATE() AS TheDate";
            using (IDbConnection dbConn = new SqlConnection(connectionString))
            {
                dbConn.Open();
                var cmd = dbConn.CreateCommand();
                cmd.CommandText = sql;
                var result = cmd.ExecuteScalar();
                ViewData["TheDate"] = result;
            }
        }
    }
}