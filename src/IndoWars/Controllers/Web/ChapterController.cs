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
            var user = _repository.GetUserViewModel(User.Identity.Name);
            return View(user);
        }

        [Authorize]
        public IActionResult TarakanBattle()
        {
            var user = _repository.GetUserViewModel(User.Identity.Name);
            return View(user);
        }

        [Authorize]
        public IActionResult PalembangBattle()
        {
            var user = _repository.GetUserViewModel(User.Identity.Name);
            return View(user);
        }

        [Authorize]
        public IActionResult JavaSeaBattle()
        {
            var user = _repository.GetUserViewModel(User.Identity.Name);
            return View(user);
        }

        [Authorize]
        public IActionResult TimorBattle()
        {
            var user = _repository.GetUserViewModel(User.Identity.Name);
            return View(user);
        }
        public IActionResult Introduction()
        {
            return View();
        }

        public IActionResult ChapterOnProgress()
        {
            return View();
        }

        [Route("/Chapterlist")]
        [Authorize]
        public IActionResult ChapterList()
        {
            var user = _repository.GetUserViewModel(User.Identity.Name);
            var chapterList = _repository.GetChapterLists();

            var viewModels = new ChapterListViewModel()
            {
                ChapterLists = chapterList,
                Users = user
            };
            
            return View(viewModels);
        }
    }
}
