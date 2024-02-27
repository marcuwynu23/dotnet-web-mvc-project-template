using System.Diagnostics;
using BHMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers.Auth;

public class RegisterController : Controller
{
    private readonly ILogger<RegisterController> _logger;

    public RegisterController(ILogger<RegisterController> logger)
    {
        _logger = logger;
    }

    [HttpGet("register")]
    [HttpGet("auth/register")]
    public IActionResult Index()
    {
        return View("~/Views/Auth/Register/Index.cshtml");
    }
}
