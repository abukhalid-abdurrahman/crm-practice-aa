using Crm.BusinessLogic;
using Crm.Web;
using Microsoft.AspNetCore.Authorization;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.ConfigureCrmServices();

builder.Services.AddAuthentication
    (ApiKeyAuthenticationOptions.DefaultScheme)
    .AddScheme<ApiKeyAuthenticationOptions, ApiKeyHandler>();

builder.Services.AddAuthentication();

builder.Services.AddAuthorization(options => 
{
    options.AddPolicy("ApiKey", policy =>
    {
        policy.AddAuthenticationSchemes("ApiKeyScheme");
        policy.Requirements.Add(new ApiKeyRequirement());
    });
});

builder.Services.AddScoped<IAuthorizationHandler, ApiKeyHandler>();

builder.Services.AddControllers();

WebApplication app = builder.Build();

app.MapControllers();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.Run();
