namespace PcBuildingGuide.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using PcBuildingGuide.Common;

    using PcBuildingGuide.Data.Models;

    public class CategoriesSeedeer : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categoriesNames = new List<string>
            {
                "Processors",
                "Memory",
                "Motherboard",
                "Video Card",
                "Computer Case",
                "Cooling",
                "Power Supply",
                "Storage",
            };

            var categoriesDescription = new List<string>
            {
                GlobalConstants.ProcessorsDescription,
                GlobalConstants.MemoryDescription,
                GlobalConstants.MotherboardDescription,
                GlobalConstants.VideoCardDescription,
                GlobalConstants.CaseDescription,
                GlobalConstants.CoolingDescription,
                GlobalConstants.PowerSupplyDescription,
                GlobalConstants.StorageDescription,
            };

            var categories = new Dictionary<string, string>();

            for (int i = 0; i < categoriesNames.Count; i++)
            {
                categories.Add(categoriesNames[i], categoriesDescription[i]);
            }

            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category.Key,
                    Description = category.Value,
                });
            }
        }
    }
}
