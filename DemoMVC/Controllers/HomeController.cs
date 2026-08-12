using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Employee());
    }

    [HttpPost]
    public IActionResult Index(Employee employee)
    {
        ViewBag.Message = "Employee Saved Successfully";

        return View(employee);
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult test()
    {

        string x = "xyz";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
