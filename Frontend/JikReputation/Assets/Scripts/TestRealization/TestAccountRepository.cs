using System.Collections.Generic;

public class TestAccountRepository : AccountRepository
{
    public Iam Login(Account account)
    {
        string name = "Test";
        LevelOfAcquaintance level = new LevelOfAcquaintance();
        List<Person> persons = new List<Person>();

        string value = "Test";
        JwtToken jwtToken = new JwtToken(value);
        int score = 0;

        return new Iam(name, level, persons, jwtToken, score);
    }

    public void Register(Account account)
    {
        return;
    }
}
