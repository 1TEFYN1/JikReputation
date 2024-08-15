using System.Collections.Generic;

public abstract class DatingRepository : JwtAuthorizationRepository
{
    public DatingRepository(JwtToken requestJwtToken)
        : base(requestJwtToken) { }
    public abstract Person Keep(Person person);
    public abstract void Drop(Person person);
    public abstract void Edit(Person person);
    public abstract List<Person> FetchAll();
}
