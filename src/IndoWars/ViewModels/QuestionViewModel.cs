using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.Models;

namespace IndoWars.ViewModels
{
    public class QuestionViewModel
    {
        [Required]
        public string SelectedAnswer1 { set; get; }
        [Required]
        public string SelectedAnswer2 { set; get; }
        [Required]
        public string SelectedAnswer3 { set; get; }
        [Required]
        public string SelectedAnswer4 { set; get; }
        [Required]
        public string SelectedAnswer5 { set; get; }
        [Required]
        public string SelectedAnswer6 { set; get; }
        [Required]
        public string SelectedAnswer7 { set; get; }
        [Required]
        public string SelectedAnswer8 { set; get; }
        [Required]
        public string SelectedAnswer9 { set; get; }
        [Required]
        public string SelectedAnswer10 { set; get; }
        public List<qIntroduction> QIntroductions { get; set; }
        public List<qHindiaBelanda> QHindiaBelanda { get; set; }
        public List<qTarakanBattle> QTarakanBattle { get; set; }
    }
}
