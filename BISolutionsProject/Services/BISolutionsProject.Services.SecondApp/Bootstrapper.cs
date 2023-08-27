using Microsoft.Extensions.DependencyInjection;

namespace BISolutionsProject.Services.SecondApp;

/// <summary>
/// Bootstrapper for adding SecondAppServices service 
/// </summary>
public static class Bootstrapper
{
    /// <summary>
    /// Main method for adding SecondAppService to your application
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddSecondAppService(this IServiceCollection services)
    {
        services
            .AddSingleton<ISecondAppService, SecondAppService>();

        return services;
    }
}