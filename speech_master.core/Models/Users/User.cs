//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using System;
using System.Collections.Generic;
using speech_master.core.Models.Speechs;

namespace speech_master.core.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Speech> Speeches { get; set; }
    }
}
