using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.SignalR.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudflareSignalROpenApiClientTests : HostedUnitTest
{
    public CloudflareSignalROpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
