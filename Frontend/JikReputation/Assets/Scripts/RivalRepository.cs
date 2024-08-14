abstract class RivalRepository : JwtAuthorizationRepositry
{
  abstract List<Rival> FetchAll();
}
