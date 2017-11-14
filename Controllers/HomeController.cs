using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bootstrap.ViewModels;
using Bootstrap.Data;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {

        private readonly DutchContext _context;

        public HomeController(DutchContext context)
        {
            _context = context;
        }

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

        public IActionResult Shop()
        {
            var results = _context.Products.OrderBy(p => p.Category).ToList();
            return View(results.ToList());
        }
    }
}