using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class DashboardController : Controller
{
    private readonly ILogger<DashboardController> _logger;
    private readonly DatabaseManager _dbManager = new DatabaseManager();

    public DashboardController(ILogger<DashboardController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.CustomerNames = _dbManager.GetCustomerNamesFromProductsTable();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
