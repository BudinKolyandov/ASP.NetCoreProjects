namespace ForumSystem.Web.Controllers
{
    using System.Threading.Tasks;

    using ForumSystem.Data.Models;
    using ForumSystem.Services.Data;
    using ForumSystem.Web.ViewModels.Votes;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class VotesController : ControllerBase
    {
        private readonly IVoteService votesService;
        private readonly UserManager<ApplicationUser> userManager;

        public VotesController(
            IVoteService votesService,
            UserManager<ApplicationUser> userManager)
        {
            this.votesService = votesService;
            this.userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<VoteResponseModel>> Post(VoteInputModel inputModel)
        {
            var userId = this.userManager.GetUserId(this.User);
            await this.votesService.VoteAsync(inputModel.PostId, userId, inputModel.IsUpvote);
            var votes = this.votesService.GetVotes(inputModel.PostId);
            return new VoteResponseModel { VotesCount = votes };
        }
    }
}
