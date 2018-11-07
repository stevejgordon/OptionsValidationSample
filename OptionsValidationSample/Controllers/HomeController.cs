using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OptionsValidationSample.Configuration;
using OptionsValidationSample.Models;

namespace OptionsValidationSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<CustomConfig> _config;

        public HomeController(IOptions<CustomConfig> config, ILogger<HomeController> logger)
        {
            _config = config;

            try
            {
                var configValue = config.Value;               
            }
            catch(OptionsValidationException ex)
            {
                foreach(var failure in ex.Failures)
                {
                    logger.LogError(failure);
                }
            }            
        }

        public IActionResult Index()
        {
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
