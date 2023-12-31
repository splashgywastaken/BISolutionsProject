﻿using BISolutionsProject.Api.Settings;
using BISolutionsProject.Services.Settings;
using BISolutionsProject.Services.FirstApp;
using BISolutionsProject.Services.FirstAppResponse;
using BISolutionsProject.Services.SecondApp;
using BISolutionsProject.Services.SecondAppResponse;
using BISolutionsProject.Services.ThirdApp;
using BISolutionsProject.Services.ThirdAppResponse;

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
            .AddFirstAppResponseService()
            .AddSecondAppService()
            .AddSecondAppResponseService()
            .AddThirdAppService()
            .AddThirdAppResponseService();

        return services;
    }
}