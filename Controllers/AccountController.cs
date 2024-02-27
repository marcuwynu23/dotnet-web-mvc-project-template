using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BHMS.Controllers;

[Authorize]
public class AccountController : Controller
{
    // GET: AccountController
    public ActionResult Index()
    {
        return View();
    }
}
