using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;
	
[Authorize]
public class TenantController : Controller
{
    private readonly ILogger<TenantController> _logger;
    private readonly DatabaseManager _dbManager = new DatabaseManager();

    public TenantController(ILogger<TenantController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.CustomerNames = _dbManager.GetCustomerNamesFromProductsTable();
        return View();
    }
}
