using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class ReportsController : Controller
{
    private readonly ILogger<ReportsController> _logger;
    private readonly DatabaseManager _dbManager = new DatabaseManager();

    public ReportsController(ILogger<ReportsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.CustomerNames = _dbManager.GetCustomerNamesFromProductsTable();
        return View();
    }
}
