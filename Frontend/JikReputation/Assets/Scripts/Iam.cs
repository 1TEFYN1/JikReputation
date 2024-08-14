public class Iam
{
  private string _name { get; set; }
  private LevelOfAcquaintance _level { get; set; } 
  private List<Person> _contacts { get; set; }
  private JwtToken _jwtToken;
  
  public Iam(string name, LevelOfAcquaintance level, List<Person> contacts, JwtToken jwtToken)
  {
    _name = name;
    _level = level;
    _contacts = contacts;
    _jwtToken = jwtToken;
  }
}
