using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.ViewModels;
using IndoWars.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace IndoWars.Models
{
    public class WarsRepository : IWarsRepository
    {
        private WarsContext _context;
        private ILogger<WarsRepository> _logger;
        private UserManager<DbUser> _userManager;

        public WarsRepository(WarsContext context,
                ILogger<WarsRepository> logger,
                UserManager<DbUser> userManager )
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        public IEnumerable<News> GetNews()
        {
            return _context.News.ToList();
        }

        public IEnumerable<ChapterList> GetChapterLists()
        {
            return _context.ChapterLists.ToList();
        }

        public List<qIntroduction> GetQIntroductions(bool isRandom)
        {
            var listofq = GenerateLCM();
            try
            {
                if (isRandom)
                {
                    return _context.QIntroductions
                     .Include(t => t.Answer)
                     .OrderBy(t => Array.IndexOf(listofq, t.Id))
                     .ToList();
                }
                else
                {
                    return _context.QIntroductions
                     .Include(t => t.Answer)
                     .OrderBy(t => t.Id)
                     .ToList();
                }
                
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get Questions from Database", ex);
                return null;
            }
        }

        public List<qHindiaBelanda> GetQHindiaBelanda(bool isRandom)
        {
            var listofq = GenerateLCM();
            try
            {
                if (isRandom)
                {
                    return _context.QHindiaBelanda
                     .Include(t => t.Answer)
                     .OrderBy(t => Array.IndexOf(listofq, t.Id))
                     .ToList();
                }
                else
                {
                    return _context.QHindiaBelanda
                     .Include(t => t.Answer)
                     .OrderBy(t => t.Id)
                     .ToList();
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get Questions from Database", ex);
                return null;
            }
        }

        public List<qTarakanBattle> GetQTarakanBattle (bool isRandom)
        {
            var listofq = GenerateLCM();
            try
            {
                if (isRandom)
                {
                    return _context.QTarakanBattle
                     .Include(t => t.Answer)
                     .OrderBy(t => Array.IndexOf(listofq, t.Id)) 
                     .ToList();
                }
                else
                {
                    return _context.QTarakanBattle
                     .Include(t => t.Answer)
                     .OrderBy(t => t.Id)
                     .ToList();
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get Questions from Database", ex);
                return null;
            }
        }

        int[] GenerateLCM()
        {
            Random rnd = new Random();
            int[] value = new int[10];
            int x = rnd.Next(1,10);

            for (int index = 0; index < 10; index++)
            {
                int lcmValue = ((3 * x) + 3) % 10;
                x = lcmValue;
                value[index] = lcmValue;
            }
            return value;
        }

        public AnswerViewModel GetScore(QuestionViewModel vm, int questionId, string name)
        {
            AnswerViewModel answer = new AnswerViewModel();
            int score = 0;
            string[] rightAnswer = new string[10];
            int index = 0;
            switch (questionId)
            {
                case 0:
                    List<qIntroduction> DB = GetQIntroductions(false);
                    index = 0;
                    foreach (var item in DB)
                    {
                        rightAnswer[index] = item.RightChoices;
                        index++;
                    }
                    break;

                case 1:
                    List<qHindiaBelanda> DBa = GetQHindiaBelanda(false);
                    index = 0;
                    foreach (var item in DBa)
                    {
                        rightAnswer[index] = item.RightChoices;
                        index++;
                    }
                    break;

                case 2:
                    List<qTarakanBattle> DBb = GetQTarakanBattle(false);
                    index = 0;
                    foreach (var item in DBb)
                    {
                        rightAnswer[index] = item.RightChoices;
                        index++;
                    }
                    break;
            }

            if (vm.SelectedAnswer1 == rightAnswer[0]) score += 10;
            if (vm.SelectedAnswer2 == rightAnswer[1]) score += 10;
            if (vm.SelectedAnswer3 == rightAnswer[2]) score += 10;
            if (vm.SelectedAnswer4 == rightAnswer[3]) score += 10;
            if (vm.SelectedAnswer5 == rightAnswer[4]) score += 10;
            if (vm.SelectedAnswer6 == rightAnswer[5]) score += 10;
            if (vm.SelectedAnswer7 == rightAnswer[6]) score += 10;
            if (vm.SelectedAnswer8 == rightAnswer[7]) score += 10;
            if (vm.SelectedAnswer9 == rightAnswer[8]) score += 10;
            if (vm.SelectedAnswer10 == rightAnswer[9]) score += 10;

            answer.Score = score;
            answer.QuestionId = questionId;
            return answer;
        }

        public async Task SaveProgress (int questionId, string name)
        {
            
            DbUser user = await _userManager.FindByNameAsync(name);
            IdentityResult id = null;
            if (user != null)
            {
                user.ChapterProgress = questionId;
                id = await _userManager.UpdateAsync(user);
                await _context.SaveChangesAsync();
            }
            //if (user != null)
            //{ 
            //    if (questionId == 1)
            //    {
            //        user.ChapterProgress = 1;
            //        id = await _userManager.UpdateAsync(user);
            //        await _context.SaveChangesAsync();
            //    }
            //    else if (questionId == 2)
            //    {
            //        user.ChapterProgress = 2;
            //        id = await _userManager.UpdateAsync(user);
            //        await _context.SaveChangesAsync();
            //    }
            //    else if (questionId == 3)
            //    {
            //        user.ChapterProgress = 3;
            //        id = await _userManager.UpdateAsync(user);
            //        await _context.SaveChangesAsync();
            //    }
            //}
        }

        public UserViewModel GetUserViewModel(string name)
        {
            var item = _context.DbUser
                     .Where(t => t.UserName == name)
                     .ToList();

            UserViewModel user = new UserViewModel()
            {
                Username = item[0].UserName,
                ChapterProgress = item[0].ChapterProgress
            };

            var idQuestion = _context.AHindiaBelanda
                            .GroupBy(y => y.Choices)
                            .ToList();

            

            //testClass test = new testClass();
            //foreach(char id in idQuestion.ToString())
            //{
            //    test.Id = id;

            //    test.a = _context.AHindiaBelanda
            //        .Where(t => t.Choices == "A" && t.Id == id)
            //        .Count();

            //    test.b = _context.AHindiaBelanda
            //            .Where(t => t.Choices == "B" && t.Id == id)
            //            .Count();

            //    test.c = _context.AHindiaBelanda
            //            .Where(t => t.Choices == "C" && t.Id == id)
            //            .Count();

            //    test.d= _context.AHindiaBelanda
            //            .Where(t => t.Choices == "D" && t.Id == id)
            //            .Count();
            //}
            //var look = test;

            return user;
        }

        public async Task RegisterAccount(RegisterViewModel vm)
        {
            if (await _userManager.FindByEmailAsync(vm.Email) == null)
            {
                var user = new DbUser()
                {
                    UserName = vm.Username,
                    Email = vm.Email,
                    ChapterProgress = 0
                };
                await _userManager.CreateAsync(user, vm.Password);
                
            }
            else
            {
                _logger.LogError("Email is already Used");
            }
        }
    }
}
