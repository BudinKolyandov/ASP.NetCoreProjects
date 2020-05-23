namespace PcBuildingGuide.Data.Models.Parts
{
    public class SolidStateDrive
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string Brand { get; set; }

        public string DeviceType { get; set; }

        public string UsedFor { get; set; }

        public string FormFactor { get; set; }

        public string Capacity { get; set; }

        public string Interface { get; set; }

        public string MemoryComponents { get; set; }
    }
}
