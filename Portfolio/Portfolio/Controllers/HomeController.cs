namespace Portfolio.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Portfolio.Models;
    using Portfolio.Models.ViewModels;
    using Portfolio.Services;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IHomeService homeService;
        private readonly IProjectsService projectsService;

        public HomeController(
            ILogger<HomeController> logger,
            IHomeService homeService,
            IProjectsService projectsService)
        {
            this.logger = logger;
            this.homeService = homeService;
            this.projectsService = projectsService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult About()
        {
            return this.View();
        }

        public IActionResult Contact()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var id = await this.homeService.SaveContact(model);
            if (id <= 0)
            {
                return this.BadRequest();
            }

            return this.RedirectToAction("Index");
        }

        public IActionResult Portfolio()
        {
            var viewModel = new IndexPortfolioViewModel
            {
                Projects = this.projectsService.GetAll<ProjectPortfolioViewModel>(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            this.logger.LogError("Error");
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
