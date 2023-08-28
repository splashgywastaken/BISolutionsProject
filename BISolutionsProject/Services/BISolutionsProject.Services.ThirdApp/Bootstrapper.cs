using Microsoft.Extensions.DependencyInjection;

namespace BISolutionsProject.Services.ThirdApp;

/// <summary>
/// Bootstrapper class for ThirdApp services
/// </summary>
public static class Bootstrapper
{
    /// <summary>
    /// Adds ThirdAppService services to your app
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddThirdAppService(this IServiceCollection services)
    {
        services.AddSingleton<IThirdAppService, ThirdAppWithTreeService>();

        return services;
    }
}