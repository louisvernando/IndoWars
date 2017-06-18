using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IndoWars.Models
{
    public class aIntroduction
    {
        public int Id { get; set; }
        public string Choices { get; set; }
        public string Text { get; set; }
    }
}
