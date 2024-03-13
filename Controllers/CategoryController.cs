using Microsoft.AspNetCore.Mvc;

namespace ShoeWebShop.Controllers;
public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}