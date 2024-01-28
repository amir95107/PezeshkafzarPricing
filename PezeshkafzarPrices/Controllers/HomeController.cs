using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PezeshkafzarPrices.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PezeshkafzarPrices.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnectionString");
            return View();
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
