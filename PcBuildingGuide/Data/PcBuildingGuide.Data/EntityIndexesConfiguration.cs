namespace PcBuildingGuide.Data
{
    using System.Linq;

    using Microsoft.EntityFrameworkCore;
    using PcBuildingGuide.Data.Common.Models;

    internal static class EntityIndexesConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            // IDeletableEntity.IsDeleted index
            var deletableEntityTypes = modelBuilder.Model
                .GetEntityTypes()
                .Where(et => et.ClrType != null && typeof(IdeletableModel).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                modelBuilder.Entity(deletableEntityType.ClrType).HasIndex(nameof(IdeletableModel.IsDeleted));
            }
        }
    }
}
