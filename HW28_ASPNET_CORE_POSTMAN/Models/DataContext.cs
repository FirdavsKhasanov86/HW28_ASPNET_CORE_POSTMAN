using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW28_ASPNET_CORE_POSTMAN.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        {
        
        }
       public  DbSet<Citata> Citatas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Citata>().HasData(new Citata() { Id = 1, Text = "Grohnim vse", Author="Hurshed", Date=DateTime.Parse("30.05.2020")},
                                                    new Citata() { Id = 2, Text = "Dobudet svet", Author = "Firdavs", Date = DateTime.Parse("30.05.2020") },
                                                    new Citata() { Id = 3, Text = "FREE Internet Unlim Forever", Author = "Payrav", Date = DateTime.Parse("30.05.2020") },
                                                    new Citata() { Id = 4, Text = "Kali luchshe tochno", Author = "Shahzod", Date = DateTime.Parse("30.05.2020") },
                                                    new Citata() { Id = 5, Text = "Davay vrubimsya v CS1.6", Author = "Karim", Date = DateTime.Parse("30.05.2020") });
        }

    }
}
