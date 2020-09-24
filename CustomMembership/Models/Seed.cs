using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMembership.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.users.Any())
                {
                    return;
                }

                context.users.AddRange(
                   new User { Id = 1, Name = "Fatih", SurName = "Çakıroğlu", Email = "f-cakiroglu@outlook.com", Password = "1234", UserName = "fcakiroglu16" },
                   new User { Id = 2, Name = "Ahmet", SurName = "Yılmaz", Email = "ahmet@outlook.com", Password = "1234", UserName = "ahmet15" },
                   new User { Id = 3, Name = "Mehmet", SurName = "Doğan", Email = "mehmet@outlook.com", Password = "1234", UserName = "mehmet15" });

                context.SaveChanges();
            }
        }
    }
}