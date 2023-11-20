//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using System;

namespace speech_master.core.Brokers.DateTimes
{
    public interface IDateTimeBroker
    {
        DateTimeOffset GetCurrentDateTimeOffset();
    }
}
