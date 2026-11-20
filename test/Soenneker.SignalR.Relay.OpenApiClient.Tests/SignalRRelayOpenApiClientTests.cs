using Soenneker.Tests.HostedUnit;

namespace Soenneker.SignalR.Relay.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SignalRRelayOpenApiClientTests : HostedUnitTest
{
    public SignalRRelayOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
