//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using speech_master.core.Models.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace speech_master_acceptance_tests.Brokers
{
    public partial class ApiBroker
    {
        private const string UsersRelativeUrl = "api/users";

        public async ValueTask<User> PostUserAsync(User user) =>
            await this.apiFactoryClient.PostContentAsync(UsersRelativeUrl, user);

        public async ValueTask<User> GetUserByIdAsync(Guid userId) =>
            await this.apiFactoryClient.GetContentAsync<User>($"{UsersRelativeUrl}/{userId}");

        public async ValueTask<List<User>> GetAllUsersAsync() =>
            await this.apiFactoryClient.GetContentAsync<List<User>>($"{UsersRelativeUrl}/");

        public async ValueTask<User> PutUserAsync(User user) =>
            await this.apiFactoryClient.PutContentAsync(UsersRelativeUrl, user);

        public async ValueTask<User> DeleteUserAsync(Guid userId) =>
            await this.apiFactoryClient.DeleteContentAsync<User>($"{UsersRelativeUrl}/{userId}");

    }
}
