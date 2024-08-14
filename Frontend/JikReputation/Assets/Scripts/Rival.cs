using System.Collections.Generic;
using System;

public class Rival
{
  private readonly string _nickname;
  private readonly List<RivalPerson> _persons;
  private readonly LevelOfAcquaintance _level;
  private readonly DateTime _dateOfRegistration;
  private readonly int _mutualPersons;

  public Rival(string nickname, List<RivalPerson> persons, LevelOfAcquaintance level, DateTime dateOfRegistration, int mutualPersons)
  {
    _nickname = nickname;
    _persons = persons;
    _level = level;
    _dateOfRegistration = dateOfRegistration;
    _mutualPersons = mutualPersons;
  }
}
