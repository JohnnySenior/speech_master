//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using FluentAssertions;
using Force.DeepCloner;
using Moq;
using speech_master.core.Models.Users;
using System.Threading.Tasks;
using Xunit;

namespace speech_master_unit_tests.Services.Foundations.Users
{
    public partial class UserServiceTest
    {
        [Fact]
        public async Task ShouldAddUserAsync()
        {
            //given
            User randomUser = CreateRandomUser();
            User inputUser = randomUser;
            User persistedUser = inputUser;
            User expectedUser = persistedUser.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertUserAsync(inputUser))
                    .ReturnsAsync(expectedUser);

            //when
            User actualUser = await this.userService.AddUserAsync(inputUser);

            //then
            actualUser.Should().BeEquivalentTo(expectedUser);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertUserAsync(inputUser), Times.Once());

            this.storageBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
        }

    }
}
