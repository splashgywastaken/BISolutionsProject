using BISolutionsProject.Api;
using BISolutionsProject.Api.Configuration;
using BISolutionsProject.Services.Settings;
using BISolutionsProject.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.AddAppLogger();

// Get settings
var swaggerSettings = Settings.Load<SwaggerSettings>("Swagger");

var services = builder.Services;

services.AddApiVersioning();
services.AddAppSwagger(swaggerSettings);
services.AddAppHealthChecks();
services.AddAppAutoMappers();

services.AddAppControllerAndViews();

services.RegisterAppServices();

var app = builder.Build();

app.UseAppHealthChecks();

app.UseSwagger();

app.UseAppControllerAndViews();

app.UseAppMiddlewares();

app.UseStaticFiles();

app.Run();