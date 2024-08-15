using System.Collections.Generic;

public class TestDatingRepository : DatingRepository
{
    private List<Person> _persons = new List<Person>();
    public TestDatingRepository(JwtToken requestJwtToken) : base(requestJwtToken)
    {
    }

    public override void Drop(Person person)
    {
        _persons.Remove(person);
    }

    public override void Edit(Person person)
    {
        throw new System.NotImplementedException();
    }

    public override List<Person> FetchAll()
    {
        return _persons;
    }

    public override Person Keep(Person person)
    {
        _persons.Add(person);
        return person;
    }
}
