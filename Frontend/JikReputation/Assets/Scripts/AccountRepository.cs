public interface AccountRepository
{
    public void Register(Account account);
    public JwtToken Login(Account account);
}
