using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pens.Controllers
{
    public class SetupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditFillSystems()
        {
            return View();
        }

        public IActionResult EditPenMatters()
        {
            return View();
        }

        public IActionResult EditPenNibs()
        {
            return View();
        }

        public IActionResult EditPenPoints()
        {
            return View();
        }

        public IActionResult EditPenStates()
        {
            return View();
        }
    }
}
