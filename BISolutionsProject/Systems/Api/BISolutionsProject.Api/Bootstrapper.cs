using BISolutionsProject.Api.Settings;
using BISolutionsProject.Services.Settings;
using BISolutionsProject.Services.FirstApp;
using BISolutionsProject.Services.FirstAppResponse;

namespace BISolutionsProject.Api;

/// <summary>
/// Bootsrapper for BISolutionsProjec.Api
/// </summary>
public static class Bootstrapper
{
    /// <summary>
    /// Adds all of the services required to run the app
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection RegisterAppServices(this IServiceCollection services)
    {
        services
            .AddMainSettings()
            .AddApiSpecialSettings()
            .AddSwaggerSettings()
            .AddFirstAppService()
            .AddFirstAppResponseService();

        return services;
    }
}