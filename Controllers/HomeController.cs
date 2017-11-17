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
        private readonly IDutchRepository _repository;

        public HomeController(IDutchRepository repository)
        {
            _repository = repository;
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

        [HttpGet("shop")]
        public IActionResult Shop()
        {
            // Pulls the results out from the entitiy framework.
            var results = _repository.GetAllProducts();
            return View(results);
        }
    }
}