using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace stateManagement.Pages
{
    public class DisplaySessionModel : PageModel
    {
        public string Name;
        public void OnGet()
        {
            Name = HttpContext.Session.GetString("n");
        }
    }
}
