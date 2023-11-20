//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using speech_master.core.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace speech_master.core.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
        IQueryable<User> SelectAllUsers();
        ValueTask<User> SelectUserByIdAsync(Guid userId);
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
    }
}
