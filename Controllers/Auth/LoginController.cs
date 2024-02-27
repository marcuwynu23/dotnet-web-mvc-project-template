using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using BHMS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers.Auth;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    [HttpGet("login")]
    [HttpGet("auth")]
    [HttpGet("auth/login")]
    public IActionResult Get()
    {
        return View("~/Views/Auth/Login/Index.cshtml");
    }

    [HttpPost("auth/login")]
    public IActionResult Post(LoginViewModel model)
    {
        if (model.Username == "admin" && model.Password == "admin")
        {
            Console.WriteLine("true.");
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, model.Username),
                // Add other claims as needed
            };
            // Create identity
            var claimsIdentity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );
            // Sign in the user
            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity)
            );

            return RedirectToAction("Index", "Dashboard");
        }
        return View("~/Views/Auth/Login/Index.cshtml");
    }

    [HttpGet("auth/logout")]
    public IActionResult Logout()
    {
        // Sign out the user
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        // Redirect to the login page or any other page after logout
        return RedirectToAction("Get", "Login"); // Redirect to home page after logout
    }
}
