//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Xeptions;

namespace speech_master.core.Models.Users.Exceptions
{
    public class UserValidationException : Xeption
    {
        public UserValidationException(Xeption innerException)
            : base(message: "User validation error occurred, fix the error and try again. ",
                 innerException)
        { }
    }
}
