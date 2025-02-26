using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MVCModelViewAssignment.Models;
using Microsoft.AspNetCore.Authentication;

namespace MVCModelViewAssignment.Controllers
{
   //[Route("Account")]
    public class AccountController : Controller
    {
        [HttpGet]
       //[Route("Login/{ReturnUrl}")]
        public IActionResult Login(string ReturnUrl)
        {
            ViewData.Add("ReturnURL", ReturnUrl);
            return View();
        }   

        [HttpPost]
        public IActionResult Login(UserDetails user, string ReturnUrl)
        {
            //Validate user
            if(user.UserName == "Admin" &&  user.Password == "Admin123")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                };

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));
                return Redirect(ReturnUrl);
            }
            else
            {
                ViewData.Add("ReturnURL", ReturnUrl);
                return Redirect("/Account/AccessDenied");
            }
            
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Home/Index");
        }

        public IActionResult AccessDenied() { 
            return View();
        }
    }
}
