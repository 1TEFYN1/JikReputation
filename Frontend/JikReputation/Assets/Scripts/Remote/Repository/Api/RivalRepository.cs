using System.Collections.Generic;

public abstract class RivalRepository : JwtAuthorizationRepository
{
    public RivalRepository(JwtToken requestJwtToken)
        : base(requestJwtToken) { }
    public abstract List<Rival> FetchAll();
}
