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
        ValueTask<Speech> InsertSpeechAsync(Speech speech);
        IQueryable<Speech> SelectAllSpeeches();
        ValueTask<Speech> SelectSpeechByIdAsync(Guid speechId);
        ValueTask<Speech> DeleteSpeechAsync(Speech speech);
    }
}
