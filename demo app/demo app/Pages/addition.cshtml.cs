using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demo_app.Pages
{
    public class additionModel : PageModel
    {
        [BindProperty]
        public int Number1 {get; set;}
        [BindProperty]
        public int Number2 { get; set; }

        public int Result;

        public void OnGet()
        {
        }
        
        public void OnPost()
        {
            Result = Number1 + Number2;
        }
    }
}
