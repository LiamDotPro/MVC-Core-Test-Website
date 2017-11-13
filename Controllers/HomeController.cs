using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bootstrap.ViewModels;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// This action is where the information that has been sent by the user is "worked on".
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }
    }
}