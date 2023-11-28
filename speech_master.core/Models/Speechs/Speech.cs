//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using System;
using speech_master.core.Models.Feetbacks;
using speech_master.core.Models.Users;

namespace speech_master.core.Models.Speechs
{
    public class Speech
    {
        public Guid SpeechId { get; set; }
        public string Sentence { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Feedback Feedback { get; set; }
    }
}
