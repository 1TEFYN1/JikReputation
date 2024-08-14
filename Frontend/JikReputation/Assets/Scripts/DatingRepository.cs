abstract class DatingRepository
{
  private readonly JwtToken _requestJwtToken;

  public DatingRepository(JwtToken requestJwtToken)
  {
    _requestJwtToken = requestJwtToken;
  }
  
  public abstract void keep(Person person);
  public abstract void drop(int id);
  public abstract void edit(Person person);
}
