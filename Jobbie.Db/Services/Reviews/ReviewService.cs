using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    /// <inheritdoc />
    public class ReviewService : BaseService<Review>, IReviewService
    {
        public ReviewService(ApplicationContext context) : base(context)
        {
        }
    }
}
