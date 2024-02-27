using System.Diagnostics;
using BHMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers.Auth;

public class RecoveryController : Controller
{
    private readonly ILogger<RecoveryController> _logger;

    public RecoveryController(ILogger<RecoveryController> logger)
    {
        _logger = logger;
    }

    [HttpGet("recovery")]
    [HttpGet("auth/recovery")]
    public IActionResult Index()
    {
        return View("~/Views/Auth/Recovery/Index.cshtml");
    }

    // recovery-confirmation
    [HttpGet("auth/recovery/confirm")]
    public IActionResult RecoveryConfirmation()
    {
        return View("~/Views/Auth/Recovery/Recovery-Confirmation.cshtml");
    }
}
