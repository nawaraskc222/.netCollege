using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace stateManagement.Pages
{
    public class CookiesReadModel : PageModel
    {
        public string Name;
        public void OnGet()
        {
            Name = Request.Cookies["myName"];
        }
    }
}
