public class Person
{
    private int _id { get; set; }
    private string _name { get; set; }
    private int _age { get; set; }
    private string _description { get; set; }
    private string _contact { get; set; }

    public Person(string name, int age, string description, string contacnt)
    {
        _name = name;
        _age = age;
        _description = description;
        _contact = contacnt;
    }
    public bool HasContact()
    {
        return !string.IsNullOrEmpty(_contact);
    }
    public string GetName() { return _name; }
    public int GetAge() { return _age;}
    public string GetDescription() { return _description;}
    public string GetContact() { return _contact;}
}
