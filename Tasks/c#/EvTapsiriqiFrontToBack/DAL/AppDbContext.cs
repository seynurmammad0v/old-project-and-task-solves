using EvTapsiriqiFrontToBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<SliderDescription> SliderDescriptions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ValentineDescription> ValentineDescriptions { get; set; }
        public DbSet<FlowerExpert> FlowerExperts { get; set; }
        public DbSet<FlowerExpertItem> FlowerExpertItems { get; set; }
        public DbSet<EmailSection> EmailSections { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<SliderFlorist> SliderFlorists { get; set; }
        public DbSet<Bio> Bio { get; set; }
    }
}
