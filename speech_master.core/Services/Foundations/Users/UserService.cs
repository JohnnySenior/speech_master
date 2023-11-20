//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Microsoft.EntityFrameworkCore.Metadata;
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

        public async ValueTask<User> InsertUserAsync(User user)
        {
            ValidateUserOnAdd(user);

            return await this.storageBroker.InsertUserAsync(user);
        }

        public IQueryable<User> SelectUsers()
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> SelectUserByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
        public ValueTask<User> DeleteUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

    }
}
