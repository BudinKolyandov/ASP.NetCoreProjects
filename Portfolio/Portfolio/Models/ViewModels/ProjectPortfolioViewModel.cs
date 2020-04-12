namespace Portfolio.Models.ViewModels
{
    using System.ComponentModel;
    using global::Services.Mapping;
    using Portfolio.Data.Models;

    public class ProjectPortfolioViewModel : IMapFrom<Project>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        [DisplayName("Site Link")]
        public string Url { get; set; }

        [DisplayName("GitHub Link")]
        public string GitHubUrl { get; set; }
    }
}
