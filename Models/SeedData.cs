using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScrewDepot.Data;
using System;
using System.Linq;

namespace ScrewDepot.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScrewDepotContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScrewDepotContext>>()))
            {
                // Look for any movies.
                if (context.ScrewsModel.Any())
                {
                    return;   // DB has been seeded
                }

                context.ScrewsModel.AddRange(
                    new ScrewsModel
                    {
                        
                        Name = "Concrete Screws",
                        Description = "3/16\" x 1 1/4\" Flat Head / Blue Perma-Seal",
                        Material = "Blue Perma-Seal",
                        LengthInMillimeters = 16,
                        DiameterInMillimeters = 14,
                        Price = 5,
                        StockQuantity = 34,
                        Manufacturer = "Phillips",
                        Rating = "4"
                    },

                    new ScrewsModel
                    {
                        Name = "Hex Washer Head",
                        Description = "3/16\" x 1 1/4\" Concrete Screws / Slotted / Hex Washer Head / Blue Perma-Seal",
                        Material = "Blue Perma-Seal",
                        LengthInMillimeters = 19,
                        DiameterInMillimeters = 13,
                        Price = 8,
                        StockQuantity = 56,
                        Manufacturer = "Axe",
                        Rating = "5"
                    },

                    new ScrewsModel
                    {
                        Name = "Washer Screws",
                        Description = "3/16\" x 1 1/4\" Flat Head / Blue Perma-Seal Bulk Packaging",
                        Material = "Blue Perma-Seal",
                        LengthInMillimeters = 16,
                        DiameterInMillimeters = 11,
                        Price = 19,
                        StockQuantity = 30,
                        Manufacturer = "Arrow",
                        Rating = "3"
                    },

                    new ScrewsModel
                    {
                        Name = "Concrete Screws",
                        Description = "3/16\" x 1 1/4\" Concrete Screws / Blue Perma-Seal",
                        Material = "Blue Perma-Seal",
                        LengthInMillimeters = 10,
                        DiameterInMillimeters = 18,
                        Price = 5,
                        StockQuantity = 8,
                        Manufacturer = "Axe",
                        Rating = "5"
                    },
                     new ScrewsModel
                     {
                         Name = "Concrete Screws",
                         Description = "3/16\" x 1 1/4\" Flat Head / Blue Perma-Seal",
                         Material = "Blue Perma-Seal",
                         LengthInMillimeters = 18,
                         DiameterInMillimeters = 12,
                         Price = 5,
                         StockQuantity = 3,
                         Manufacturer = "Samsung",
                         Rating = "4"
                     },
                      new ScrewsModel
                      {
                          Name = "Concrete Screws",
                          Description = "3/16\" x 1 1/4\" Concrete Screws / Blue Perma-Seal Bulk Packaging",
                          Material = "Blue Perma-Seal",
                          LengthInMillimeters = 16,
                          DiameterInMillimeters = 14,
                          Price = 5,
                          StockQuantity = 50,
                          Manufacturer = "Phillips",
                          Rating = "4"
                      },
                       new ScrewsModel
                       {
                           Name = "Concrete Screws",
                           Description = "3/16\" x 1 1/4\" Flat Head / Blue Perma-Seal",
                           Material = "Blue Perma-Seal",
                           LengthInMillimeters = 16,
                           DiameterInMillimeters = 14,
                           Price = 5,
                           StockQuantity = 36,
                           Manufacturer = "Samsung",
                           Rating = "2"
                       },
                        new ScrewsModel
                        {
                            Name = "Concrete Screws",
                            Description = "3/16\" x 1 1/4\" Concrete Screws / Blue Perma-Seal Bulk Packaging",
                            Material = "Blue Perma-Seal",
                            LengthInMillimeters = 16,
                            DiameterInMillimeters = 14,
                            Price = 5,
                            StockQuantity = 22,
                            Manufacturer = "Axe",
                            Rating = "5"
                        },
                         new ScrewsModel
                         {
                             Name = "Concrete Screws",
                             Description = "3/16\" x 1 1/4\" Flat Head / Blue Perma-Seal",
                             Material = "Blue Perma-Seal",
                             LengthInMillimeters = 16,
                             DiameterInMillimeters = 20,
                             Price = 5,
                             StockQuantity = 12,
                             Manufacturer = "Samsung",
                             Rating = "4"
                         },
                          new ScrewsModel
                          {
                              Name = "Concrete Screws",
                              Description = "3/16\" x 1 1/4\" Flat Head / Blue Perma-Seal",
                              Material = "Blue Perma-Seal",
                              LengthInMillimeters = 15,
                              DiameterInMillimeters = 13,
                              Price = 5,
                              StockQuantity = 14,
                              Manufacturer = "Axe",
                              Rating = "3"
                          }
                ); ;
                context.SaveChanges();
            }
        }

        private static int DbContextOptions<T>()
        {
            throw new NotImplementedException();
        }
    }
}
