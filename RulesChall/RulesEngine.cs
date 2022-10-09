public class RulesEngine<T>
{
    public List<Func<T, bool>> Rules { get; set; } = new();

    public void ApplyRules(T testObject, List<Func<T, bool>> rules)
    {

        foreach (var rule in rules)
        {
            rule(testObject);
        }

    }
}
