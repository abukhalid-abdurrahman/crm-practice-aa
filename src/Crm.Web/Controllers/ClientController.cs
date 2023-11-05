using Crm.BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Crm.Web;

[ApiController]
[Route("api/clients")]
[Authorize]
public sealed class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
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
}