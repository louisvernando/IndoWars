﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoWars.Models
{
    public class qHindiaBelanda
    {
        public int Id { get; set; }
        public string Questions { get; set; }
        public List<aHindiaBelanda> Answer { get; set; }
        public string RightChoices { get; set; }
    }
}
