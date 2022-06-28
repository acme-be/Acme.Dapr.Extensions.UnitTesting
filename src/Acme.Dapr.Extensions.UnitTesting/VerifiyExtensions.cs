using Dapr.Client;
using Moq;

namespace Acme.Dapr.Extensions.UnitTesting;

public static class VerifiyExtensions
{
    public static void VerifyPublishEvent<TExpected>(this Mock<DaprClient> mock, string expectedPubsub, string expectedTopic)
    {
        mock.Verify(x => x.PublishEventAsync(expectedPubsub, expectedTopic, It.IsAny<TExpected>(), default), Times.Once);
    }

    public static void VerifySaveState<TExpected>(this Mock<DaprClient> mock, string expectedStore)
    {
        mock.Verify(x => x.SaveStateAsync(expectedStore, It.IsAny<string>(), It.IsAny<TExpected>(), It.IsAny<StateOptions>(), It.IsAny<IReadOnlyDictionary<string, string>>(), default),
            Times.Once);
    }
}