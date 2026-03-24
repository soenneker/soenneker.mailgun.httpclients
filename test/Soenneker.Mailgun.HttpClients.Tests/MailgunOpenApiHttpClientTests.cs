using Soenneker.Mailgun.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Mailgun.HttpClients.Tests;

[Collection("Collection")]
public sealed class MailgunOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IMailgunOpenApiHttpClient _httpclient;

    public MailgunOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IMailgunOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
