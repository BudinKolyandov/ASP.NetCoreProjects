namespace Portfolio.Services
{
    using System.Collections.Generic;

    public interface IProjectsService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);
    }
}
