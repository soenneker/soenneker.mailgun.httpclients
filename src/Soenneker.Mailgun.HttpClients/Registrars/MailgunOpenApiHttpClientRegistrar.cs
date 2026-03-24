using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Mailgun.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Mailgun.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class MailgunOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="MailgunOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddMailgunOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IMailgunOpenApiHttpClient, MailgunOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="MailgunOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddMailgunOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IMailgunOpenApiHttpClient, MailgunOpenApiHttpClient>();

        return services;
    }
}
