//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using speech_master_acceptance_tests.Brokers;
using speech_master_acceptance_tests.Models.Users;
using System;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;
using Xunit;

namespace speech_master_acceptance_tests.Apis.Users
{
    [Collection(nameof(ApiTestCollection))]

    public partial class UserApiTests
    {
        private readonly ApiBroker apiBroker;

        public UserApiTests(ApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        private User CreateRandomUser()
        {
            var filler = new Filler<User>();

            return  filler.Create();
        }
        
        private async ValueTask<User> DeleteUserAsync(User actualUser)
        {
            User deletedUser =
                await apiBroker.DeleteUserAsync(actualUser.Id);

            return deletedUser;
        }
    }
}
