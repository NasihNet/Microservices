using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;
using System;
using System.Linq;

namespace PlatformService.Data
{
    public static class PrepDb
    {

        public static void PrepPopulation(IApplicationBuilder app)
        {
                using(var service = app.ApplicationServices.CreateScope())
                {
                    


                }

        }

        private static void SeedData(AppDbContext context)
        {

            if (!context.Platforms.Any())
            {
                Console.WriteLine("seeding data....");
                context.Platforms.AddRange(
                    new Platform{ Name="Dot Net", Publisher = "Microsoft", Cost = "Free"},
                      new Platform { Name = "Sql Server Express", Publisher = "Microsoft", Cost = "Free" },
                        new Platform { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" });

                context.SaveChanges();
            } else {
                Console.WriteLine("--> We already have data");
            }
        
        }



    }


}