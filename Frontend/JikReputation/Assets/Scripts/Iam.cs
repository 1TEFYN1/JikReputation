using System.Collections.Generic;

public class Iam
{
    private string _name;
    private LevelOfAcquaintance _level;
    private List<Person> _contacts;
    private JwtToken _jwtToken;

    public Iam(string name, LevelOfAcquaintance level, List<Person> contacts, JwtToken jwtToken)
    {
        _name = name;
        _level = level;
        _contacts = contacts;
        _jwtToken = jwtToken;
    }
}
