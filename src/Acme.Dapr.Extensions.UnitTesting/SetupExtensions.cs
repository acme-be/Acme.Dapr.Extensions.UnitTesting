// -----------------------------------------------------------------------
//  <copyright file = "TestsExtensions.cs" company = "Prism">
//  Copyright (c) Prism.All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

using Dapr.Client;
using Moq;

namespace Acme.Dapr.Extensions.UnitTesting;

public static class SetupExtensions
{
    public static void SetupGetStateAsync<T>(this Mock<DaprClient> mock, string store, string key, T data)
    {
        mock.Setup(x => x.GetStateAsync<T>(store, key, null, null, It.IsAny<CancellationToken>()))
            .ReturnsAsync(data);
    }
}