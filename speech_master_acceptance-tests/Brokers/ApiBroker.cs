//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using speech_master;
using System.Net.Http;

namespace speech_master_acceptance_tests.Brokers
{
    public partial class ApiBroker
    {
        private readonly WebApplicationFactory<Startup> webApplicationFactory;
        private readonly HttpClient httpClient;
        private readonly IRESTFulApiFactoryClient apiFactoryClient;

        public ApiBroker()
        {
            this.webApplicationFactory = new WebApplicationFactory<Startup>();
            this.httpClient = this.webApplicationFactory.CreateClient();
            this.apiFactoryClient = new RESTFulApiFactoryClient(this.httpClient);
        }
    }
}
