namespace Portfolio.Models.ViewModels
{
    using System.Collections.Generic;

    public class IndexPortfolioViewModel
    {
        public virtual IEnumerable<ProjectPortfolioViewModel> Projects { get; set; }
    }
}
