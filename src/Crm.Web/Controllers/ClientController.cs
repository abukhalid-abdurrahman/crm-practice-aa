using Crm.BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Crm.Web;

[ApiController]
[Route("api/clients")]
[Authorize]
public sealed class ClientController : ControllerBase
{
    private readonly IClientService _clientService;
    private readonly IOptionsMonitor<ConnectionStrings> _options;

    public ClientController(
        IClientService clientService,
        IOptionsMonitor<ConnectionStrings> options)
    {
        _clientService = clientService;
        _options = options;
    }

    [HttpPost]
    public ClientInfo CreateClient([FromBody] ClientInfo clientInfo)
        => _clientService.CreateClient(clientInfo);

    [HttpGet]
    [AllowAnonymous]
    public ClientInfo GetClient([FromQuery] string firstName, [FromQuery] string lastName)
        => _clientService.GetClient(firstName, lastName);

    [HttpDelete]
    public bool DeleteClient([FromQuery] string firstName, [FromQuery] string lastName)
        => _clientService.RemoveClient(firstName, lastName);

    [HttpGet("Config")]
    [AllowAnonymous]
    public string Config()
    {
        return _options.CurrentValue.DefaultConnection;
    }
}