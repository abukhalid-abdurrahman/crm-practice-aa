namespace Crm.BusinessLogic;

public interface IClientService
{
    public ClientInfo CreateClient(ClientInfo clientInfo);
    public ClientInfo GetClient(string firstName, string lastName);
    public bool RemoveClient(string firstName, string lastName);
}
