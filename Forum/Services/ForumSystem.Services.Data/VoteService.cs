namespace ForumSystem.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using ForumSystem.Data.Common.Repositories;
    using ForumSystem.Data.Models;

    public class VoteService : IVoteService
    {
        private readonly IRepository<Vote> votesRepository;

        public VoteService(IRepository<Vote> votesRepository)
        {
            this.votesRepository = votesRepository;
        }

        public int GetVotes(int postId)
        {
            var votes = this.votesRepository.All()
                .Where(x => x.PostId == postId).Sum(x => (int)x.Type);
            return votes;
        }

        public async Task VoteAsync(int postId, string userId, bool isUpvote)
        {
            var vote = this.votesRepository.All()
                .FirstOrDefault(x => x.Id == postId && x.UserId == userId);
            if (vote == null)
            {
                vote = new Vote
                {
                    PostId = postId,
                    UserId = userId,
                    Type = isUpvote ? VoteType.UpVote : VoteType.DownVote,
                };

                await this.votesRepository.AddAsync(vote);
            }
            else
            {
                vote.Type = isUpvote ? VoteType.UpVote : VoteType.DownVote;
            }

            await this.votesRepository.SaveChangesAsync();
        }
    }
}
