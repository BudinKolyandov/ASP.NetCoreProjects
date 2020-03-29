namespace PcBuildingGuide.Web.ViewModels.Categories
{
    using PcBuildingGuide.Data.Models;
    using PcBuildingGuide.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
