using Microsoft.AspNetCore.Authentication;

namespace Crm.Web;

public sealed class ApiKeyAuthenticationHandler : AuthenticationHandler<ApiKeyRequirement>
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ApiKeyAuthenticationHandler(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ApiKeyRequirement requirement)
    {
        if (_httpContextAccessor.HttpContext is null)
            throw new ArgumentException(nameof(_httpContextAccessor.HttpContext));

        if (!_httpContextAccessor.HttpContext.Request.Headers.ContainsKey(Constants.ApiKeyName))
        {
            context.Fail(new(this, $"{Constants.ApiKeyName} not provided in request headers!"));
            return Task.CompletedTask;
        }

        string? providedApiKey = _httpContextAccessor.HttpContext.Request.Headers[Constants.ApiKeyName];
        if (string.IsNullOrEmpty(providedApiKey) || !providedApiKey.Equals(requirement.ApiKey))
        {
            context.Fail(new(this, $"{Constants.ApiKeyName} not valid!"));
            return Task.CompletedTask;
        }

        context.Succeed(requirement);
        return Task.CompletedTask;
    }
}