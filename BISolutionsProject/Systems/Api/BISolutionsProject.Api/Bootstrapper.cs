using BISolutionsProject.Services.Settings;

namespace BISolutionsProject.Api;

public static class Bootstrapper
{
    public static IServiceCollection RegisterAppServices(this IServiceCollection services)
    {
        services
            .AddSwaggerSettings();

        return services;
    }
}