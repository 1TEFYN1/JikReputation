class JwtAuthorizationRepositry
{
  protected readonly JwtToken _requestJwtToken;

  public JwtAuthorizationRepositry(JwtToken requestJwtToken)
  {
    _requestJwtToken = requestJwtToken;
  }
}
