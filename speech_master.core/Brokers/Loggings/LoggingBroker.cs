//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Microsoft.Extensions.Logging;
using System;

namespace speech_master.core.Brokers.Loggings
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger<LoggingBroker> logger;

        public LoggingBroker(ILogger<LoggingBroker> logger)
        {
            this.logger = logger;
        }

        public void LogCritical(Exception exception) =>
            this.logger.LogCritical(exception.Message, exception);

        public void LogError(Exception exception) =>
            this.logger.LogError(exception.Message, exception);

    }
}
