//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using speech_master.core.Brokers.Storages;
using speech_master.core.Models.Users;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace speech_master.core.Services.Foundations.Users
{
    public partial class UserService : IUserService
    {
        private readonly IStorageBroker storageBroker;

        public UserService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<User> AddUserAsync(User user)
        {
            ValidateUserOnAdd(user);

            throw new NotImplementedException();
        }

        public IQueryable<User> RetrieveUsers() =>
            this.storageBroker.SelectAllUsers();

        public async ValueTask<User> RetrieveUserByIdAsync(Guid userId)
        {
            ValidateUserId(userId);

            User user = await this.storageBroker.SelectUserByIdAsync(userId);

            return user;
        }

        public async ValueTask<User> ModifyUserAsync(User user)
        {
            ValidateUserOnModify(user);

            return await this.storageBroker.UpdateUserAsync(user);
        }
        public async ValueTask<User> RemoveUserAsync(Guid userId)
        {
            ValidateUserId(userId);

            User user = await this.storageBroker.SelectUserByIdAsync(userId);

            return await this.storageBroker.DeleteUserAsync(user);
        }

    }
}
