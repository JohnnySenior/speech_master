//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using System;
using speech_master.core.Models.Speechs;

namespace speech_master.core.Models.Feetbacks
{
    public class Feedback
    {
        public Guid FeedbackId { get; set; }
        public decimal Accuracy { get; set; }
        public decimal Fluency { get; set; }
        public decimal Prosody { get; set; }
        public decimal Completeness { get; set; }
        public decimal Pronunciation { get; set; }
        public Guid SpeechId { get; set; }
        public Speech Speech { get; set; }
        public Guid ParentId { get; set; }
    }
}
