using System.Collections.Generic;

public class Iam
{
    private string _name;
    private LevelOfAcquaintance _level;
    private List<Person> _contacts;
    private JwtToken _jwtToken;
    private int _score;

    public Iam(string name, LevelOfAcquaintance level, List<Person> contacts, JwtToken jwtToken, int score)
    {
        _name = name;
        _level = level;
        _contacts = contacts;
        _jwtToken = jwtToken;
        _score = score; 
    }
}
