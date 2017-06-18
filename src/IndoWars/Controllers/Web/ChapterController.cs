using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace IndoWars.Controllers.Web
{
    public class ChapterController : Controller
    {
        private IConfigurationRoot _config;
        private ILogger<ChapterController> _logger;
        private IWarsRepository _repository;

        public ChapterController(IConfigurationRoot config,
            ILogger<ChapterController> logger,
            IWarsRepository repository)
        {
            _config = config;
            _logger = logger;
            _repository = repository;
        }

        [Authorize]
        public IActionResult HindiaBelanda()
        {
            var user = _repository.GetDbUser(User.Identity.Name);
            return View(user);
        }

        [Authorize]
        public IActionResult TarakanBattle()
        {
            var user = _repository.GetDbUser(User.Identity.Name);
            return View(user);
        }

        public IActionResult Introduction()
        {
            return View();
        }

    }
}
