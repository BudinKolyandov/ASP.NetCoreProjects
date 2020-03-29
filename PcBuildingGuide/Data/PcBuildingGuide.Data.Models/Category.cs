namespace PcBuildingGuide.Data.Models
{
    using System.Collections.Generic;

    using PcBuildingGuide.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Parts = new HashSet<Part>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
