using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.Controllers.Api;
using IndoWars.Controllers.Web;
using IndoWars.Models;
using IndoWars.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Remotion.Linq.Parsing.ExpressionVisitors.Transformation.PredefinedTransformations;

namespace IndoWars.Controllers.Chapter
{
    public class IntroductionController : Controller
    {
        private IConfigurationRoot _config;
        private ILogger<ChapterController> _logger;
        private IWarsRepository _repository;

        public IntroductionController(IConfigurationRoot config,
            ILogger<ChapterController> logger,
            IWarsRepository repository)
        {
            _logger = logger;
            _config = config;
            _repository = repository;
        }

        [HttpGet("Introduction/Quiz")]
        public IActionResult getQuestion()
        {
            var vm = new QuestionViewModel();
            vm.QIntroductions = _repository.GetQIntroductions(true);
            vm.SelectedAnswer1 = "A";
            vm.SelectedAnswer2 = "A";
            vm.SelectedAnswer3 = "A";
            vm.SelectedAnswer4 = "A";
            vm.SelectedAnswer5 = "A";
            vm.SelectedAnswer6 = "A";
            vm.SelectedAnswer7 = "A";
            vm.SelectedAnswer8 = "A";
            vm.SelectedAnswer9 = "A";
            vm.SelectedAnswer10 = "A";
            return View("QuizIntroduction",vm);
        }
        
    }
}
