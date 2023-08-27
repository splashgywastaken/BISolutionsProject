using Microsoft.Extensions.DependencyInjection;

namespace BISolutionsProject.Services.SecondAppResponse;

/// <summary>
/// Bootstrapper class for SecondAppResponseService services
/// </summary>
public static class Bootstrapper
{
    /// <summary>
    /// Method that adds new SecondAppResponseService service to ServiceCollection 
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddSecondAppResponseService(this IServiceCollection services)
    {
        services
            .AddSingleton<ISecondAppResponseService, SecondAppResponseService>();
        return services;
    }
}