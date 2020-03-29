namespace PcBuildingGuide.Data.Models
{
    using System.Collections.Generic;

    using PcBuildingGuide.Data.Common.Models;

    public class Build : BaseDeletableModel<int>
    {
        public Build()
        {
            this.BuildParts = new HashSet<BuildPart>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<BuildPart> BuildParts { get; set; }
    }
}
