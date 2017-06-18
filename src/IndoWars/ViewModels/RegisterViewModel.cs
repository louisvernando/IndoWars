using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndoWars.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string Username { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
