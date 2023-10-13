﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheHangerCompany.Data;
using System;
using System.Linq;

namespace TheHangerCompany.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TheHangerCompanyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TheHangerCompanyContext>>()))
            {
                // Look for any 
                if (context.Hanger.Any())
                {
                    return;   // DB has been seeded
                }

                context.Hanger.AddRange(
                    new Hanger
                    {
                        Title = "Standard Wooden Hanger",
                        ReleaseDate = DateTime.Parse("2022-2-12"),
                        Type = "Wooden",
                        Price = 7.99M,
                        Color = "Brown",
                        Size = "Adult",
                        MaxWeightCapacity = 5000,  // 5kg
                        Material = "Wood"
                    },

                    new Hanger
                    {
                        Title = "Plastic Hanger",
                        ReleaseDate = DateTime.Parse("2022-3-13"),
                        Type = "Plastic",
                        Price = 3.99M,
                        Color = "Black",
                        Size = "Adult",
                        MaxWeightCapacity = 3000,  //  3kg
                        Material = "Plastic"
                    },

                    new Hanger
                    {
                        Title = "Kid's Hanger",
                        ReleaseDate = DateTime.Parse("2022-6-23"),
                        Type = "Plastic",
                        Price = 4.99M,
                        Color = "Silver",
                        Size = "Child",
                        MaxWeightCapacity = 2500,  //  2.5kg
                        Material = "Plastic"
                    },

                    new Hanger
                    {
                        Title = "Deluxe Padded Hanger",
                        ReleaseDate = DateTime.Parse("2022-1-15"),
                        Type = "Padded",
                        Price = 5.99M,
                        Color = "White",
                        Size = "Adult",
                        MaxWeightCapacity = 4000,  //  4kg
                        Material = "Fabric"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}