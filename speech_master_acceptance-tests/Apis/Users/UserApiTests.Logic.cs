//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using FluentAssertions;
using speech_master_acceptance_tests.Models.Users;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Xunit;


namespace speech_master_acceptance_tests.Apis.Users
{
    public partial class UserApiTests
    {
        [Fact]
        public async Task ShouldPostUserAsync()
        {
            // given
            User randomUser = CreateRandomUser();
            User inputUser = randomUser;
            User expectedUser = inputUser;

            // when
            await this.apiBroker.PostUserAsync(inputUser);

            User actualUser = 
                await this.apiBroker.GetUserByIdAsync(inputUser.Id);

            // then
            actualUser.Should().BeEquivalentTo(expectedUser);
            await DeleteUserAsync(actualUser);
        }
    }
}
