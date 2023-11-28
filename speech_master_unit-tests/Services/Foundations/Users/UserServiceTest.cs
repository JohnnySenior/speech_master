//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Moq;
using speech_master.core.Brokers.DateTimes;
using speech_master.core.Brokers.Loggings;
using speech_master.core.Brokers.Storages;
using speech_master.core.Models.Users;
using speech_master.core.Models.Users.Exceptions;
using speech_master.core.Services.Foundations.Users;
using System;
using System.Linq.Expressions;
using Tynamix.ObjectFiller;
using Xeptions;

namespace speech_master_unit_tests.Services.Foundations.Users
{
    public partial class UserServiceTest
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<IDateTimeBroker> dateTimeBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly IUserService userService;

        public UserServiceTest()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.dateTimeBrokerMock = new Mock<IDateTimeBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.userService =
                new UserService(
                    storageBroker: this.storageBrokerMock.Object,
                    loggingBroker: this.loggingBrokerMock.Object);
        }

        private User CreateRandomUser() =>
            CreateUserFiller(date: GetRandomDateTimeOffset()).Create();

        private DateTimeOffset GetRandomDateTimeOffset() =>
            new DateTimeRange(earliestDate: new DateTime()).GetValue();

        private static Filler<User> CreateUserFiller(DateTimeOffset date)
        {
            Filler<User> filler = new Filler<User>();

            filler.Setup().OnType<DateTimeOffset>().Use(date);

            return filler;
        }

        private Expression<Func<Xeption, bool>> SameExceptionAs(Xeption expectedException) =>
            actualException => actualException.SameExceptionAs(expectedException);
    }
}
