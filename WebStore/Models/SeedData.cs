using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product {
                        Name = "ASUS",
                        Images = "/images/Product/Asus01.jpg",
                        Price = 25000,
                        Description = "new model ASUS"
                    },
                        
                    new Product
                    {
                        Name = "Acer",
                        Images = "/images/Product/Acer01.jpg",
                        Price = 30000,
                        Description = "new model Acer"
                    },
                    new Product
                    {
                        Name = "MSI",
                        Images = "/images/Product/MSI01.jpg",
                        Price = 65000,
                        Description = "new model MSI"
                    },
                    new Product
                    {
                        Name = "Dell",
                        Images = "/images/Product/Dell01.jpg",
                        Price = 20000,
                        Description = "new model Dell"
                    },
                    new Product
                    {
                        Name = "Sony",
                        Images = "/images/Product/Sony01.jpg",
                        Price = 35000,
                        Description = "new model Sony Vio"
                    },
                    new Product
                    {
                        Name = "Apple",
                        Images = "/images/Product/Apple01.jpg",
                        Price = 100000,
                        Description = "new model Apple MacBook",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
