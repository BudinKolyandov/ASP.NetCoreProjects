namespace PcBuildingGuide.Data.Models.Parts
{
    public class HardDiskDrive
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string Brand { get; set; }

        public string Interface { get; set; }

        public string Capacity { get; set; }

        public string RPM { get; set; }

        public string Cache { get; set; }

        public string Usage { get; set; }

        public string FormFactor { get; set; }
    }
}
