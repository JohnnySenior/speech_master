//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using FluentAssertions;
using Moq;
using RESTFulSense.Exceptions;
using speech_master.core.Models.Users;
using speech_master.core.Models.Users.Exceptions;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace speech_master_unit_tests.Services.Foundations.Users
{
    public partial class UserServiceTest
    {
        [Fact]
        public async Task ShouldThrowValidatonExceptionOnAddIfInputIsNullAndLogItAsync()
        {
            //given
            User nullUser = null;
            var nullUserException = new NullUserException();

            var expectedUserValidationException = 
                new UserValidationException(nullUserException);

            //when 
            ValueTask<User> addUserTask = this.userService.AddUserAsync(nullUser);

            UserValidationException actualUserValidationException =
                await Assert.ThrowsAsync<UserValidationException>(addUserTask.AsTask);

            //then 
            actualUserValidationException
                .Should().BeEquivalentTo(expectedUserValidationException);

            this.loggingBrokerMock.Verify(broker =>
                broker.LogError(It.Is(SameExceptionAs(
                    expectedUserValidationException))), Times.Once);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertUserAsync(It.IsAny<User>()), Times.Never);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public async Task ShouldThrowValidationExceptionOnAddIfUserIsInvalidAndLogIdAsync(string invalidText)
        {
            //given
            User invalidUser = new User
            {
                Name = invalidText,
            };
            
            var invalidUserException = new InvalidUserException();

            invalidUserException.AddData(
                key: nameof(User.Id),
                values: "Id is required");

            invalidUserException.AddData(
                key: nameof(User.Name),
                values: "Text is required");

            var expectedUserValidationException = 
                new UserValidationException(invalidUserException);

            // when 
            ValueTask<User> addUserTask =
                this.userService.AddUserAsync(invalidUser);

            UserValidationException actualUserValidationException =
                await Assert.ThrowsAsync<UserValidationException>(addUserTask.AsTask);

            //then
            actualUserValidationException
                .Should().BeEquivalentTo(expectedUserValidationException);

            this.loggingBrokerMock.Verify(broker =>
                broker.LogError(It.Is(SameExceptionAs(
                    expectedUserValidationException))), Times.Once);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertUserAsync(It.IsAny<User>()), Times.Never);

            this.loggingBrokerMock.VerifyNoOtherCalls();
            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
