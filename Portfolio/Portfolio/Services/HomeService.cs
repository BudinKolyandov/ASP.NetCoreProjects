namespace Portfolio.Services
{
    using System.Threading.Tasks;
    using Portfolio.Data;
    using Portfolio.Data.Models;
    using Portfolio.Models.ViewModels;

    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext context;

        public HomeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<int> SaveContact(ContactInputModel model)
        {
            var contact = new ContactRequests
            {
                FullName = model.Name,
                Email = model.Name,
                Message = model.Message,
            };

            await this.context.ContactRequests.AddAsync(contact);
            await this.context.SaveChangesAsync();
            return contact.Id;
        }
    }
}
