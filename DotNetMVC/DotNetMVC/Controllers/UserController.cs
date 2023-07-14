using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace DotNetMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string username = form["user"];
            string password= form["pass"];

            if(username=="" && password == ""){ 
                return View();
            }
            else
            {
                ClaimsIdentity identity = null;
                bool isAuthenticated = false;

                if (username == "admin" && password=="admin") {
                    identity = new ClaimsIdentity(new[]
                    {
                            new Claim(ClaimTypes.Name, username),
                            new Claim(ClaimTypes.Role,"Admin")
                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticated=true;

                }

                if (username == "user" && password == "user")
                {
                    identity = new ClaimsIdentity(new[]
                    {
                            new Claim(ClaimTypes.Name, username),
                            new Claim(ClaimTypes.Role,"User")
                        }, CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticated = true;




                }

                if (isAuthenticated)
                {
                    var principal = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [Authorize(Roles="Admin")]
        public IActionResult Index1()
        {
            return View();
        }
         
        [Authorize(Roles = "User")]
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
    }
}
