//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using speech_master.core.Models.Users;
using speech_master.core.Models.Users.Exceptions;
using System;
using System.Threading.Tasks;

namespace speech_master.core.Services.Foundations.Users
{
    public partial class UserService
    {
        private delegate ValueTask<User> ReturningUserFunction();

        private async ValueTask<User> TryCatch(ReturningUserFunction returningUserFunction)
        {
            try
            {
                return await returningUserFunction();
            }
            catch(NullUserException nullUserException)
            {
                throw CreateAndLogValidationException(nullUserException);
            }
        }

        private UserValidationException CreateAndLogValidationException(NullUserException nullUserException)
        {
            var userValidationException = new UserValidationException(nullUserException);
            this.loggingBroker.LogError(userValidationException);

            return userValidationException;
        }
    }
}
