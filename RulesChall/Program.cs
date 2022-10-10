using RulesChall.Models;
using RulesChall.Rules;


RulesEngine<CompanyModel> companyRulesEngine = new();
companyRulesEngine.Rules.Add(CompanyRules.CheckForCompanyName);
companyRulesEngine.Rules.Add(CompanyRules.CheckForCompanyPostalCode);
companyRulesEngine.Rules.Add(CompanyRules.CheckForValueInName);

RulesEngine<PersonModel> personRulesEngine = new();
personRulesEngine.Rules.Add(PersonRules.CheckForFullName);
personRulesEngine.Rules.Add(PersonRules.CheckForInitials);
personRulesEngine.Rules.Add(PersonRules.CheckForPostalCode);


Console.Write("FirstName: ");
string firstName = Console.ReadLine();

Console.Write("LastName: ");
string lastName = Console.ReadLine();

Console.Write("PostalCode: ");
string postalCode = Console.ReadLine();

PersonModel person = new() { FirstName = firstName, LastName = lastName, PostalCode = postalCode };

Console.Write("CompanyName: ");
string companyName = Console.ReadLine();

Console.Write("CompanyPostalCode: ");
string companyPostalCode = Console.ReadLine();

CompanyModel company = new() { Name = companyName, PostalCode = companyPostalCode };


Console.WriteLine("Person: ");
personRulesEngine.ApplyRules(person);
Console.WriteLine("Company: ");
companyRulesEngine.ApplyRules(company);

