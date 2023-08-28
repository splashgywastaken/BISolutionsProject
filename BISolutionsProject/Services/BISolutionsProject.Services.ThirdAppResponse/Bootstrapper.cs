using Microsoft.Extensions.DependencyInjection;

namespace BISolutionsProject.Services.ThirdAppResponse;

/// <summary>
/// Bootstrapper for ThirdAppResponseService services
/// </summary>
public static class Bootstrapper
{
    /// <summary>
    /// Adds ThirdAppResponse services to your application
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddThirdAppResponseService(this IServiceCollection services)
    {
        services.AddSingleton<IThirdAppResponseService, ThirdAppResponseService>();

        return services;
    } 
}