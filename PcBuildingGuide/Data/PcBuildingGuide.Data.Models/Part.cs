namespace PcBuildingGuide.Data.Models
{
    using System.Collections.Generic;

    using PcBuildingGuide.Data.Common.Models;

    public class Part : BaseDeletableModel<int>
    {
        public Part()
        {
            this.BuildParts = new HashSet<BuildPart>();
        }

        public string Name { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<BuildPart> BuildParts { get; set; }
    }
}
