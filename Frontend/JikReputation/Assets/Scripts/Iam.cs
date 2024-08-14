public class Iam
{
  private string _name { get; set; }
  private LevelOfAcquaintance _level { get; set; } 
  private List<Person> _contacts { get; set; }

  public Iam(string name, LevelOfAcquaintance level, List<Person> contacts)
  {
    _name = name;
    _level = level;
    _contacts = contacts
  }
}
