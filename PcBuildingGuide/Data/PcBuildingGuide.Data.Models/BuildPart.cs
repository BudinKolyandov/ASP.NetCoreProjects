namespace PcBuildingGuide.Data.Models
{
    using PcBuildingGuide.Data.Common.Models;

    public class BuildPart : BaseDeletableModel<int>
    {
        public int BuildId { get; set; }

        public Build Build { get; set; }

        public int PartId { get; set; }

        public Part Part { get; set; }
    }
}
