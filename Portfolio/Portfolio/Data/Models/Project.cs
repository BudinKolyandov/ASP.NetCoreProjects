namespace Portfolio.Data.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string Url { get; set; }

        public string GitHubUrl { get; set; }
    }
}
