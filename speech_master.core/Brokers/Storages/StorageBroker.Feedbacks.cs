//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Microsoft.EntityFrameworkCore;
using speech_master.core.Models.Feetbacks;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace speech_master.core.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Feedback> Feedbacks { get; set; }

        public async ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback) =>
            await InsertAsync(feedback);

        public IQueryable<Feedback> SelectAllFeedbackes() =>
            SelectAll<Feedback>().AsQueryable();

        public async ValueTask<Feedback> SelectFeedbackByIdAsync(Guid feedbackId) =>
            await SelectAsync<Feedback>(feedbackId);

        public async ValueTask<Feedback> DeleteFeedbackAsync(Feedback feedback) =>
            await DeleteAsync(feedback);
    }
}
