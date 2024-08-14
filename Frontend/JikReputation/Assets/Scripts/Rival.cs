public class Rival
{
  private readonly string _nickname;
  private readonly List<RivalPerson> _persons;
  private readonly LevelOfAcquaintance _level;
  private readonly DateTime _dateOfRegistration;

  public Rival(string nickname, List<RivalPerson> persons, LevelOfAcquaintance level, DateTime dateOfRegistration)
  {
    _nickname = nickname;
    _persons = persons;
    _level = level;
    _dateOfRegistration = dateOfRegistration;
  }
}
