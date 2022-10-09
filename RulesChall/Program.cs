using RulesChall;

Console.Write("FirstName: ");
string firstName = Console.ReadLine();

Console.Write("LastName: ");
string lastName = Console.ReadLine();

Console.Write("PostalCode: ");
string postalCode = Console.ReadLine();

PersonModel person = new() { FirstName = firstName, LastName = lastName, PostalCode = postalCode };
person.ApplyRules(PrintToConsole);

void PrintToConsole(string messege)
{
    Console.WriteLine(messege);
}