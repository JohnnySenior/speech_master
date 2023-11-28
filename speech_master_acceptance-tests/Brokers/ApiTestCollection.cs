//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Xunit;

namespace speech_master_acceptance_tests.Brokers
{
	[CollectionDefinition(nameof(ApiTestCollection))]
	public class ApiTestCollection : ICollectionFixture<ApiBroker>
	{
	}
}
