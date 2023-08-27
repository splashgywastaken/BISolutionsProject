using System.Reflection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BISolutionsProject.Api.Configuration.HealthChecks;

public class SelfHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
    {
        var assembly = Assembly.Load("BISolutionsProject.API");
        var versionNumber = assembly.GetName().Version;

        return Task.FromResult(HealthCheckResult.Healthy(description: $"Build {versionNumber}"));
    }
}