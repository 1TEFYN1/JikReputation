abstract class DatingRepository : JwtAuthorizationRepository
{
  public abstract int Keep(Person person);
  public abstract void Drop(int id);
  public abstract void Edit(Person person);
  public abstract List<Person> FetchAll();
}
