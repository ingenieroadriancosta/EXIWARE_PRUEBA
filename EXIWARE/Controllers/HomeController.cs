using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EXIWARE.Models;
using EXIWARE.Params;
using Microsoft.AspNetCore.Http;
//using Params;

namespace EXIWARE.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("/")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        

        [HttpGet("[action]")]
        public IActionResult Index2()
        {
            return View();
        }


        [HttpGet("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }
        //
        //
        //
        //
        [HttpGet("[action]")]
        public IActionResult Admin()
        {
            AdminViews sev = new AdminViews();
            string str2r = HttpContext.Session.GetString( AdminViews.sname );
            sev.Adpar = AdminViews.AdparA;
            sev.AdparAll = AdminViews.AdparAllA;
            sev.SesInit = str2r!=null;
            return View(sev);
        }
        //
        //
        //
        //
        [HttpGet("[action]")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //
        //
        //
        //
        //
        //
        //
        //
    }
}
