using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndoWars.Models;

namespace IndoWars.ViewModels
{
    public class ChapterListViewModel
    {
        public UserViewModel Users { get; set; }
        public IEnumerable<ChapterList> ChapterLists { get; set; }
    }
}
