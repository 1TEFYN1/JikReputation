public class JwtAuthorizationRepository
{
  protected readonly JwtToken _requestJwtToken;

  public JwtAuthorizationRepository(JwtToken requestJwtToken)
  {
    _requestJwtToken = requestJwtToken;
  }
}
