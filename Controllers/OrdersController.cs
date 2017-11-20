using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bootstrap.Data;
using Microsoft.Extensions.Logging;

namespace Bootstrap.Controllers
{
    [Route("api/[Controller]")]
    public class OrdersController : Controller
    {
        private readonly IDutchRepository _Repository;
        private readonly ILogger<OrdersController> _Logger;

        public OrdersController(IDutchRepository _repository, ILogger<OrdersController> _logger)
        {
            _Repository = _repository;
            _Logger = _logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_Repository.getAllOrders());
            }
            catch (Exception ex)
            {
                _Logger.LogError($"Failed to get Orders: {ex}");
                return BadRequest("Failed to get Orders.");
            }
        }

    }
}