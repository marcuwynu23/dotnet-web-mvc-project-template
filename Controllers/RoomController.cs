using System.Diagnostics;
using BHMS.Database;
using BHMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class RoomController : Controller
{
    private readonly ILogger<RoomController> _logger;
    private readonly DatabaseManager _dbManager = new DatabaseManager();

    public RoomController(ILogger<RoomController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.CustomerNames = _dbManager.GetCustomerNamesFromProductsTable();
        return View();
    }
}
