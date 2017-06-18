using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IndoWars.Models
{
    public class DbUser : IdentityUser
    {
        public int ChapterProgress { get; set; }
    }
}
