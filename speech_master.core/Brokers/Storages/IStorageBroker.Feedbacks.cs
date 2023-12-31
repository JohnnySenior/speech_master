﻿//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using speech_master.core.Models.Feetbacks;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace speech_master.core.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> SelectAllFeedbackes();
        ValueTask<Feedback> SelectFeedbackByIdAsync(Guid feedbackId);
        ValueTask<Feedback> DeleteFeedbackAsync(Feedback feedback);
    }
}
