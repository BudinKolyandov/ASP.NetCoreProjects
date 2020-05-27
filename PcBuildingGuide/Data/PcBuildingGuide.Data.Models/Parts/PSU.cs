namespace PcBuildingGuide.Data.Models.Parts
{
    public class PSU
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public string MaximumPower { get; set; }

        public string Fans { get; set; }

        public string Modular { get; set; }

        public string EnergyEfficiency { get; set; }
    }
}
