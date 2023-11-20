//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using System;

namespace speech_master.core.Brokers.Loggings
{
    public interface ILoggingBroker
    {
        public void LogCritical(Exception exception);
        public void LogError(Exception exception);
    }
}
