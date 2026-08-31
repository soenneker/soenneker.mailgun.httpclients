[![](https://img.shields.io/nuget/v/soenneker.mailgun.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.mailgun.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.mailgun.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.mailgun.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.mailgun.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.mailgun.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.mailgun.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.mailgun.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Mailgun.HttpClients

Reuse an authenticated HTTP client for Mailgun's API.

## Install

```bash
dotnet add package Soenneker.Mailgun.HttpClients
```

## Configure and register

```json
{ "Mailgun": { "ApiKey": "<private API key>" } }
```

The provider defaults to `https://api.mailgun.net/` and HTTP Basic authentication with username `api` and the configured key as the password.

```csharp
services.AddMailgunOpenApiHttpClientAsSingleton();
```

Use the scoped registration only when each scope should own its transport. Provider instances use isolated cache keys, so disposing one scope removes only its own client.

```csharp
HttpClient client = await mailgunHttpClient.Get(cancellationToken);
HttpResponseMessage response = await client.GetAsync("v3/domains", cancellationToken);
response.EnsureSuccessStatusCode();
```

Optional settings are `Mailgun:ClientBaseUrl`, `Mailgun:AuthHeaderName`, and `Mailgun:AuthHeaderValueTemplate`. A custom value template receives the raw API key through `{token}` and replaces the default Basic-auth construction.

The provider owns the cached client. Let the service container dispose the provider.
