namespace PcBuildingGuide.Data.Models.Parts
{
    public class AirCooler
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string Brand { get; set; }

        public string FanSize { get; set; }

        public string CPUSocketCompatibility { get; set; }

        public string RPM { get; set; }

        public string PowerConnector { get; set; }

        public string MaxCPUCoolerHeight { get; set; }

        public string HeatsinkDimensions { get; set; }

        public string Weight { get; set; }
    }
}
