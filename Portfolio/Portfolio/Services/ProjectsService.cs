namespace Portfolio.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using global::Services.Mapping;
    using Portfolio.Data;
    using Portfolio.Data.Models;

    public class ProjectsService : IProjectsService
    {
        private readonly ApplicationDbContext context;

        public ProjectsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Project> query = this.context.Projects.OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public T GetByName<T>(string name)
        {
            var category = this.context.Projects
                .Where(x => x.Name == name)
                .To<T>().FirstOrDefault();
            return category;
        }
    }
}
