using Microsoft.EntityFrameworkCore;
using speech_master.core.Models;

namespace speech_master.core.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Speech> Speeches { get; set; }

        public async ValueTask<Speech> InsertSpeechAsync(Speech speech) =>
            await InsertAsync(speech);

        public IQueryable<Speech> SelectAllSpeeches() =>
            SelectAll<Speech>().AsQueryable();

        public async ValueTask<Speech> SelectSpeechByIdAsync(Guid speechId) =>
            await SelectAsync<Speech>(speechId);

        public async ValueTask<Speech> DeleteSpeechAsync(Speech speech) =>
            await DeleteAsync(speech);
    }
}
