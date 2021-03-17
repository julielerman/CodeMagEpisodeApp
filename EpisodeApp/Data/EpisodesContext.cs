using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1;

namespace EpisodeApp.Data
{
    public class EpisodesContext : DbContext
    {
        public EpisodesContext (DbContextOptions<EpisodesContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Episode> Episode { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Episode>().HasData(
                new Episode { EpisodeId = 1, Title = "All about Open Source and .NET", GuestName = "Claire Novotny", Date = new System.DateTime(2021, 3, 2), URL = "https://www.youtube.com/watch?v=flj9MHrOU0k" },
                new Episode { EpisodeId = 2, Title = "Migrating ASP NET Identity to Azure AD B2C", GuestName = "Layla Porter", Date = new System.DateTime(2020, 12, 4), URL = "https://www.youtube.com/watch?v=lQlev9oRtXQ" },
                new Episode { EpisodeId = 3, Title = "Identity Crisis sidecar: Legacy software. Let's learn foxpro!", GuestName = "Joonas Westlin", Date = new System.DateTime(2021, 1, 6), URL = "https://www.youtube.com/watch?v=xCkS0e2voE8" },
                new Episode { EpisodeId = 4, Title = "Identity Crisis - Getting started with Identity", GuestName = "", Date = new System.DateTime(2021, 1, 5), URL = "https://www.youtube.com/watch?v=bniAj9q4s7c" },
                new Episode { EpisodeId = 5, Title = "Secure DevOps with Pulumi and Azure AD", GuestName = "Sean Whitesell", Date = new System.DateTime(2021, 2, 1), URL = "https://www.youtube.com/watch?v=DdTJNAXZ1k4" }
    );
        }
    }
}
