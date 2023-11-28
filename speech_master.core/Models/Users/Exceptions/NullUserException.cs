//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Xeptions;

namespace speech_master.core.Models.Users.Exceptions
{
    public class NullUserException : Xeption
    {
        public NullUserException()
            : base(message: "User is null.")
        { }
    }
}
