using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoWars.Models
{
    public class qTarakanBattle
    {
        public int Id { get; set; }
        public string Questions { get; set; }
        public List<aTarakanBattle> Answer { get; set; }
        public string RightChoices { get; set; }
    }
}
