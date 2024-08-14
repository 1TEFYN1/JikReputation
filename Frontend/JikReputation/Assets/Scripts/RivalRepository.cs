abstract class RivalRepository 
{
  private readonly JwtToken _requestJwtToken;

  public RivalRepository(JwtToken requestJwtToken)
  {
    _requestJwtToken = requestJwtToken;
  }

  abstract List<Rival> fetchAll();
}
