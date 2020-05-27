namespace PcBuildingGuide.Data.Models.Parts
{
    public class Case
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public string Color { get; set; }

        public string CaseMaterial { get; set; }

        public string MotherboardCompatibility { get; set; }

        public string MaxGPULengthAllowance { get; set; }

        public string MaxCPUCoolerHeightAllowance { get; set; }

        public string SidePanelWindow { get; set; }

        public string ExpansionSlots { get; set; }
    }
}
