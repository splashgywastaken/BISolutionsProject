using BISolutionsProject.Api;
using BISolutionsProject.Api.Configuration;
using BISolutionsProject.Services.Settings;
using BISolutionsProject.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.AddAppLogger();

// Get settings
var swaggerSettings = Settings.Load<SwaggerSettings>("Swagger");

var services = builder.Services;

// Needs to be here because either way assemblies are not loaded in
// and application can't get an info for AutoMapper configuration
services.RegisterAppServices();

services.AddAppVersioning();
services.AddAppHealthChecks();
services.AddAppSwagger(swaggerSettings);
// Loads configuration from loaded assemblies and adds an AutoMapper to this app
services.AddAppAutoMappers();

services.AddAppControllerAndViews();

var app = builder.Build();

app.UseAppHealthChecks();

app.UseAppSwagger();

app.UseAppControllerAndViews();

app.UseAppMiddlewares();

app.UseStaticFiles();

app.Run();