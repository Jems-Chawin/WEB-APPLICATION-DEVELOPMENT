using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Exercise06.Models;

namespace Exercise06.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string fname, string lname, string email, string height, string tiebreaker)
    {
        Info person = new Info();
        person.Fname = fname;
        person.Lname = lname;
        person.Email = email;
        person.Height = height;
        person.Tiebreaker = tiebreaker;

        return View(person);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
