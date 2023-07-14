using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace stateManagement.Pages
{
    public class sessionWriteModel : PageModel
    {
        [BindProperty]
        public string Name { get; set;  }

        public async Task<IActionResult> OnPostAsync()
        {
            HttpContext.Session.SetString("n", Name);
            return RedirectToPage("./DisplaySession");
        }
        public void OnGet()
        {
        }
    }
}
