using System.Collections.Generic;
using System.Threading.Tasks;
using IndoWars.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IndoWars.Models
{
    public interface IWarsRepository
    {
        IEnumerable<News> GetNews();
        IEnumerable<ChapterList> GetChapterLists(); 
        List<qIntroduction> GetQIntroductions(bool isRandom);
        List<qHindiaBelanda> GetQHindiaBelanda(bool isRandom);
        List<qTarakanBattle> GetQTarakanBattle(bool isRandom);
        Task RegisterAccount(RegisterViewModel vm);
        AnswerViewModel GetScore(QuestionViewModel vm, int questionId, string name);
        UserViewModel GetUserViewModel(string name);
        Task SaveProgress(int questionId, string name);
    }
}