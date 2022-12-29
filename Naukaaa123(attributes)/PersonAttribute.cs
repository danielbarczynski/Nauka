// [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class PersonAttribute : Attribute
{
    public string DisplayName { get; set; }
    public PersonAttribute(string name)
    {
        DisplayName = name;
    }
}