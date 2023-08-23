namespace Crm.DataAccess;

public sealed class Client
{
    public long Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string PassportNumber { get; set; } = string.Empty;
    public short Age { get; set; }
    public Gender Gender { get; set; }
}