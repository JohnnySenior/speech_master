//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using speech_master.core.Models.Users;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace speech_master.core.Services.Foundations.Users
{
    public interface IUserService
    {
        ValueTask<User> InsertUserAsync(User user);
        IQueryable<User> SelectUsers();
        ValueTask<User> SelectUserByIdAsync(Guid userId);
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(Guid userId);
    }
}
