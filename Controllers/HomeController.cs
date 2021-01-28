using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assign1_413.Models;

namespace Assign1_413.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //this returns the view for the calculator page
        [HttpGet("Calculator")]
        public IActionResult Calculator()
        {
            return View();
        }

        //this is for when you use the calculator, which sends it as a post, not a get
        [HttpPost("Calculator")]
        public IActionResult Calculator (CalculatorModel model)
        {
            return View();
        }
    }
}
