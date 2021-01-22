using Illie.Ecommerce.Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Illie.Ecommerce.Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.ProductBrands.Any())
                {
                    var brandData = File.ReadAllText(@"C:\DEV\Illie.Ecommerce\Illie.Ecommerce.Infrustructure\Data\Seeds\brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);

                    foreach (var brand in brands)
                    {
                        context.ProductBrands.Add(brand);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.ProductTypes.Any())
                {
                    var typeData = File.ReadAllText(@"C:\DEV\Illie.Ecommerce\Illie.Ecommerce.Infrustructure\Data\Seeds\types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typeData);

                    foreach (var type in types)
                    {
                        context.ProductTypes.Add(type);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    var productData = File.ReadAllText(@"C:\DEV\Illie.Ecommerce\Illie.Ecommerce.Infrustructure\Data\Seeds\products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productData);

                    foreach (var product in products)
                    {
                        context.Products.Add(product);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(e.Message);
            }
        }
    }
}
