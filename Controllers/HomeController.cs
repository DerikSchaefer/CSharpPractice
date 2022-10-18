using EmpManagementSystem.Filters;
using EmpManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmpManagementSystem.Controllers
{
    [TypeFilter(typeof(SampleExceptionFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            //Employee employee = new Employee();
            //employee.Id = 34;
            //employee.Name = "deepali";
           
           
                //int i=30, j=0;
                //int result = i / j;
           
            


            return View();
        }
        [AllowAnonymous]
        public IActionResult About()
        {
            return View();  
        }
        [AllowAnonymous]
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
}