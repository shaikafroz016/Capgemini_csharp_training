using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webappwithdbs.Controllers
{
    public class joinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult rec_empdept()
        {
            return View();
        }
    }
}
