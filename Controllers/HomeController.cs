using edxl_cap_v1_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace edxl_cap_v1_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexDe1()
        {
            return View();
        }

        public IActionResult IndexDe2()
        {
            return View();
        }

        public IActionResult IndexCapIntro()
        {
            return View();
        }

        public IActionResult IndexHave()
        {
            return View();
        }

        public IActionResult IndexRm()
        {
            return View();
        }

        public IActionResult IndexSitRep()
        {
            return View();
        }

        public IActionResult IndexTep()
        {
            return View();
        }

        public IActionResult IndexTec()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}