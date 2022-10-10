public class RulesEngine<T>
{
    public List<Func<T, bool>> Rules { get; set; } = new();

    public void ApplyRules(T testObject)
    {

        foreach (var rule in Rules)
        {
            rule(testObject);
        }

    }
}
