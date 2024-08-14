using System.Collections.Generic;

public abstract class DatingRepository : JwtAuthorizationRepository
{
    public DatingRepository(JwtToken requestJwtToken)
        : base(requestJwtToken) { }
    public abstract int Keep(Person person);
    public abstract void Drop(int id);
    public abstract void Edit(Person person);
    public abstract List<Person> FetchAll();
}
