using System.Collections.Generic;

public class TestDatingRepository : DatingRepository
{
    private List<Person> _persons = new List<Person>();
    public TestDatingRepository(JwtToken requestJwtToken) : base(requestJwtToken)
    {
    }

    public override void Drop(int id)
    {
        throw new System.NotImplementedException();
    }

    public override void Edit(Person person)
    {
        throw new System.NotImplementedException();
    }

    public override List<Person> FetchAll()
    {
        throw new System.NotImplementedException();
    }

    public override int Keep(Person person)
    {
        _persons.Add(person);
        return person.HasContact() ? 5 : 1;
    }
}
