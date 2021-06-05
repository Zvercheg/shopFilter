using Microsoft.EntityFrameworkCore;
using shoooooop.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoooooop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

       
       
    }
}
