using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutureValueCalculatorTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValueCalculatorTutorial.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public IActionResult Index() {
            ViewBag.FutureValue = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel futureValue) {
            if (ModelState.IsValid) {
                ViewBag.FutureValue = futureValue.Calculate();
            }
            else {
                ViewBag.FutureValue = "";
            }

            return View();
        }
    }
}
