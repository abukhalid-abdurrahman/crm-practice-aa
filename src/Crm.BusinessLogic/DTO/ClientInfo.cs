namespace Crm.BusinessLogic;

public readonly record struct ClientInfo(long Id, string FirstName, string LastName, string Phone, string PassportNumber, short Age, string Gender);