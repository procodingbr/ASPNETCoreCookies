using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProCoding.Demos.ASPNETCore.Cookies.Models;

namespace ProCoding.Demos.ASPNETCore.Cookies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Response.Cookies.Append("To Client", "With Love");
            return View();
        }

        public IActionResult CookieFromClient()
        {
            string cookieFromClient = Request.Cookies["From Client"];
            return Content(cookieFromClient);
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
}
