using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace stateManagement.Pages
{
    public class QueryStringReadModel : PageModel
    {
        public string Name;
        public void OnGet(string myname)
        {
            Name = myname;  
        }
    }
}
