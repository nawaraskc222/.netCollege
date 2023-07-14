using Microsoft.AspNetCore.Mvc;

namespace Username_and_password.Pages.Students
{
    public class User
    {
        [BindProperty]
        public int id { get; set; }
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }    
    }
}
