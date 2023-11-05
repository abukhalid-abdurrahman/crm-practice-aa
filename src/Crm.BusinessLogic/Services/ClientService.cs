using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class ClientService : IClientService
{
    private readonly List<Client> _clients;

    private long _id = 0;

    public ClientService()
    {
        _clients = new();
    }

    public ClientInfo CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new()
        {
            Id = _id++,
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender.ToGenderEnum(),
        };

        _clients.Add(newClient);

        return clientInfo with { Id = newClient.Id };
    }

    public bool RemoveClient(string firstName, string lastName)
    {
        if (firstName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(firstName));

        if (lastName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(lastName));

        int clientIndex = _clients.FindIndex(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));
        if (clientIndex < 0)
            return false;

        _clients.RemoveAt(clientIndex);

        return true;
    }

    public bool EditClient(long clientId, string newFirstName, string newLastName)
    {
        Client? client = _clients.Find(c => c.Id == clientId);
        if (client is null) return false;

        client.FirstName = newFirstName;
        client.LastName = newLastName;

        return true;
    }

    public ClientInfo GetClient(string firstName, string lastName)
    {
        if (firstName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(firstName));

        if (lastName is not { Length: > 0 })
            throw new ArgumentNullException(nameof(lastName));

        Client? client = _clients.Find(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName))
            ?? throw new NotFoundException();
        return client.ToClientInfo();
    }
}
