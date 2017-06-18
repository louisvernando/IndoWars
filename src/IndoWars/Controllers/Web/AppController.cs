using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;

namespace IndoWars.Controllers.Web
{
    public class AppController : Controller
    {
        private ILogger<AppController> _logger;
        private IConfigurationRoot _config;
        private IWarsRepository _repository;

        public AppController(IConfigurationRoot config,
            ILogger<AppController> logger,
            IWarsRepository repository
            )
        {
            _config = config;
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            var news = _repository.GetNews();
            return View(news);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        [Authorize]
        public IActionResult ChapterList()
        {
            return View();
        }

        public IActionResult News()
        {
            var news = _repository.GetNews();
            return View(news);
        }

        [Route("/Error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
