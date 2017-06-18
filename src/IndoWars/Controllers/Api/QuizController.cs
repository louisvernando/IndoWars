using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using IndoWars.Controllers.Web;
using IndoWars.Models;
using IndoWars.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;

namespace IndoWars.Controllers.Api
{
    public class QuizController : Controller
    {
        private IConfigurationRoot _config;
        private ILogger<QuizController> _logger;
        private IWarsRepository _repository;

        public QuizController(IConfigurationRoot config,
            ILogger<QuizController> logger,
            IWarsRepository repository)
        {
            _logger = logger;
            _config = config;
            _repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult> CheckAnswerIntro(QuestionViewModel vm)
        {
            string name = User.Identity.Name;
            AnswerViewModel ans = _repository.GetScore(vm, 0, name);
            if (ans.Score >= 70)
            {
                await _repository.SaveProgress(0, name);
            }
            return View("Result", ans);
        }

        [HttpPost]
        public async Task<ActionResult> CheckAnswerHindia(QuestionViewModel vm)
        {
            string name = User.Identity.Name;
            AnswerViewModel ans = _repository.GetScore(vm, 1, name);
            if (ans.Score >= 70)
            {
                await _repository.SaveProgress(1, name);
            }
            return View("Result", ans);
        }

        [HttpPost]
        public async Task<ActionResult> CheckAnswerTarakan(QuestionViewModel vm)
        {
            string name = User.Identity.Name;
            AnswerViewModel ans = _repository.GetScore(vm, 2, name);
            if (ans.Score >= 70)
            {
                await _repository.SaveProgress(2, name);
            }
            return View("Result", ans);
        }

    }
}
