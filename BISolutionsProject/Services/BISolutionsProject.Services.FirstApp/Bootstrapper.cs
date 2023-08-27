using Microsoft.Extensions.DependencyInjection;

namespace BISolutionsProject.Services.FirstApp;

/// <summary>
/// Bootrstrapper class for FirstApp services
/// </summary>
public static class Bootstrapper
{
    /// <summary>
    /// Adds FirstAppService to ServiceCollection
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddFirstAppService(this IServiceCollection services)
    {
        services
            .AddSingleton<IFirstAppService, FirstAppService>();

        return services;
    }
}