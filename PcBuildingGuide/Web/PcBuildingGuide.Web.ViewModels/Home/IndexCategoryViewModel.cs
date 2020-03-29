namespace PcBuildingGuide.Web.ViewModels.Home
{
    using PcBuildingGuide.Data.Models;
    using PcBuildingGuide.Services.Mapping;

    public class IndexCategoryViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Url => $"/{this.Name.Replace(' ', '-')}";
    }
}
