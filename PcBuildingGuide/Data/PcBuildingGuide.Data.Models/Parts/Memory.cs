﻿namespace PcBuildingGuide.Data.Models.Parts
{
    public class Memory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string ImgUrl { get; set; }

        public string Brand { get; set; }

        public string Capacity { get; set; }

        public string Series { get; set; }

        public string Model { get; set; }

        public string Type { get; set; }

        public string Speed { get; set; }

        public string CASLatency { get; set; }

        public string Timing { get; set; }

        public string HeatSpreader { get; set; }
    }
}
