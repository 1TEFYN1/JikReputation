using UnityEngine;
using UnityEngine.UI;

public class AccountService : MonoBehaviour
{
    [SerializeField] private Text _nickname;
    [SerializeField] private Text _password;

    private const int NICKNAME_LENGTH = 6;
    private const int PASSWORD_LENGTH = 8;

    private AccountRepository _accountRepository = new TestAccountRepository();
    public Iam Iam { get; set; }

    public void SignUp()
    {
        if (IsValidAccount(_nickname.text, _password.text))
        {
            Account account = new Account(_nickname.text, _password.text);
            _accountRepository.Register(account);
            Debug.Log($"New Account \n Nickname{_nickname.text} Password{_password.text}");
        }
    }
    public void LogIn()
    {
        if (IsValidAccount(_nickname.text, _password.text))
        {
            Account account = new Account(_nickname.text, _password.text);
            Iam = _accountRepository.Login(account);
        }
    }
    private bool IsValidAccount(string nickname, string password)
    {
        return IsValidNick(nickname) && IsValidPassword(password);
    }
    private bool IsValidNick(string nickname)
    {
        return nickname != null && nickname.Length >= NICKNAME_LENGTH;
    }
    private bool IsValidPassword(string password)
    {
        return password != null && password.Length >= PASSWORD_LENGTH;
    }
}
