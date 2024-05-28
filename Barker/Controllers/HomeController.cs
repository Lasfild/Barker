using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Возвращает представление для действия Index
    }
    public IActionResult About()
    {
        return View(); // Возвращает представление для действия About
    }
    public IActionResult Category()
    {
        return View(); // Возвращает представление для действия Category
    }
    public IActionResult Error()
    {
        return View(); // Возвращает представление для действия Error
    }
}
