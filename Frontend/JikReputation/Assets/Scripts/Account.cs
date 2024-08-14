public class Account
{
    private string _nickname { get; set; }
    private string _password { get; set; }

    public Account(string nickname, string password)
    {
        _nickname = nickname;
        _password = password;
    }
}
