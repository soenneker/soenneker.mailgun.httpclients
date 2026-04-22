using Soenneker.Mailgun.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Mailgun.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MailgunOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IMailgunOpenApiHttpClient _httpclient;

    public MailgunOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IMailgunOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
