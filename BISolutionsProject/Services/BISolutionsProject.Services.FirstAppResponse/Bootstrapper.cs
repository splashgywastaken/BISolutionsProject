using Microsoft.Extensions.DependencyInjection;

namespace BISolutionsProject.Services.FirstAppResponse;

/// <summary>
/// Bootstrapper for FirstAppResponseService service
/// </summary>
public static class Bootstrapper
{
    /// <summary>
    /// Adds FirstAppResponseService service to ServiceCollection
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddFirstAppResponseService(this IServiceCollection services)
    {
        services
            .AddSingleton<IFirstAppResponseService, FirstAppResponseService>();

        return services;
    }
}