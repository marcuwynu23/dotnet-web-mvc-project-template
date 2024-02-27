using System.Diagnostics;
using BHMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace BHMS.Controllers;

[Authorize]
public class AboutController : Controller
{
    private readonly ILogger<AboutController> _logger;

    public AboutController(ILogger<AboutController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
