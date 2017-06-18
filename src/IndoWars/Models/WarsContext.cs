using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IndoWars.Models
{
    public class WarsContext : IdentityDbContext<DbUser>
    {
        private IConfigurationRoot _config;

        public WarsContext(IConfigurationRoot config, DbContextOptions options)
            : base(options)
        {
            _config = config;
            //Database.EnsureCreated();
        }

        public DbSet<News> News { get; set; }
        public DbSet<aIntroduction> AIntroductions { get; set; }
        public DbSet<aHindiaBelanda> AHindiaBelanda { get; set; }
        public DbSet<aTarakanBattle> ATarakanBattle { get; set; }
        public DbSet<qIntroduction> QIntroductions { get; set; }
        public DbSet<qHindiaBelanda> QHindiaBelanda { get; set; }
        public DbSet<qTarakanBattle> QTarakanBattle { get; set; }
        public DbSet<DbUser> DbUser { get; set; }
        public DbSet<ChapterList> ChapterLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:WarsContextConnection"]);
        }
    }
}
