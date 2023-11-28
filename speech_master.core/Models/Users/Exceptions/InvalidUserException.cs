//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Xeptions;

namespace speech_master.core.Models.Users.Exceptions
{
    public class InvalidUserException : Xeption
    {
        public InvalidUserException()
            : base(message: "User is invalid.")
        { } 
    }
}
