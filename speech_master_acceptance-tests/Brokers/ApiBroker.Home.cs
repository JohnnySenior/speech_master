//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using System.Threading.Tasks;

namespace speech_master_acceptance_tests.Brokers
{
    public partial class ApiBroker
    {
        private const string HomeRelativeUrl = "api/home";

        public async ValueTask<string> GetHomeMessage() =>
            await this.apiFactoryClient.GetContentStringAsync(HomeRelativeUrl);
    }
}
