using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.Models;
using IndoWars.ViewModels;
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
            var Chapterlist = _repository.GetChapterLists();
            var ViewModels = new IndexViewModel()
            {
                ChapterLists = Chapterlist,
                News = news
            };
            return View(ViewModels);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Help()
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
