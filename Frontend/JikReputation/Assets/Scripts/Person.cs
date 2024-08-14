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
}
