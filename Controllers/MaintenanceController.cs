using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class MaintenanceController : Controller
{
    private readonly ILogger<MaintenanceController> _logger;
    private readonly DatabaseManager _dbManager = new DatabaseManager();

    public MaintenanceController(ILogger<MaintenanceController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.CustomerNames = _dbManager.GetCustomerNamesFromProductsTable();
        return View();
    }
}
