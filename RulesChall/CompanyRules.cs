using RulesChall;

public class CompanyRules
{
    public static bool CheckForValueInName<T>(T data)
    {
        bool output = false;

        if (data is CompanyModel company)
        {
            if (company.Name.ToLower() != "iamtimcorey" && company.Name.ToLower().Contains("corey"))
            {
                output = true;
                Console.WriteLine("A company owned by a Corey");
            }
        }

        return output;
    }
    public static bool CheckForCompanyName<T>(T data)
    {
        bool output = false;

        if (data is CompanyModel company)
        {
            if (company.Name.ToLower() == "iamtimcorey")
            {
                output = true;
                Console.WriteLine("Tim's Company");
            }
        }

        return output;
    }
    public static bool CheckForCompanyPostalCode<T>(T data)
    {
        bool output = false;

        if (data is CompanyModel company)
        {
            if (company.PostalCode.StartsWith("08"))
            {
                output = true;
                Console.WriteLine("A company in New Jersey");
            }
        }

        return output;
    }
}