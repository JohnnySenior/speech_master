using speech_master.core.Models;

namespace Feedback_master.core.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> SelectAllFeedbackes();
        ValueTask<Feedback> SelectFeedbackByIdAsync(Guid feedbackId);
        ValueTask<Feedback> DeleteFeedbackAsync(Feedback feedback);
    }
}
