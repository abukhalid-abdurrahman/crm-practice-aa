using Crm.BusinessLogic;

IClientService clientService = new ClientService();
IOrderService orderService = new OrderService();

CreateClient();

void CreateClient()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    string ageInputStr = Console.ReadLine();
    string passportNumber = Console.ReadLine();
    string genderInputStr = Console.ReadLine();

    if(!ValidateClient(
        firstName,
        lastName,
        middleName,
        ageInputStr,
        passportNumber,
        genderInputStr
    )) return;

    short age = short.Parse(ageInputStr);

    ClientInfo newClient = clientService.CreateClient(new ClientInfo()
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        PassportNumber = passportNumber
    });
    Console.WriteLine(newClient);

    Console.WriteLine("Client Name: {0}",
        string.Join(' ', newClient.FirstName, newClient.MiddleName, newClient.LastName));

    Console.WriteLine("Client Age: {0}", newClient.Age);
    Console.WriteLine("Client Passport Number: {0}", newClient.PassportNumber);
}

static bool ValidateClient(
    string firstName,
    string lastName,
    string middleName,
    string ageStr,
    string passportNumber,
    string genderStr)
{
    List<string> errors = new();

    if (firstName is { Length: 0 })
        errors.Add("First Name field is required!");

    if (lastName is { Length: 0 })
        errors.Add("Last Name field is required!");

    if (middleName is { Length: 0 })
        errors.Add("Middle Name field is required!");

    bool isAgeCorrect = short.TryParse(ageStr, out short age);
    if (!isAgeCorrect)
        errors.Add("Please input correct value for age field!");

    if (passportNumber is { Length: 0 })
        errors.Add("Passport Number field is required!");

    if (genderStr != "Female" || genderStr != "Male")
        errors.Add("Gender is not correct! Please use next valid values: Female and Male!"); 

    if (errors is { Count: > 0 })
    {
        foreach(string errorMessage in errors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
        }

        Console.ForegroundColor = ConsoleColor.White;
        return false;
    }

    return true;
}
