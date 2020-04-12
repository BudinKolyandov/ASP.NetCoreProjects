namespace Portfolio.Services
{
    using System.Threading.Tasks;
    using Portfolio.Models.ViewModels;

    public interface IHomeService
    {
        Task<int> SaveContact(ContactInputModel model);
    }
}
