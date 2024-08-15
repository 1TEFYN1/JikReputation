using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlsController : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuUI;
    [SerializeField] private GameObject _addingGirlsUI;

    [SerializeField] private InputField _name;
    [SerializeField] private InputField _age;
    [SerializeField] private InputField _description;
    [SerializeField] private InputField _contact;
    [SerializeField] private Text _scoreText;

    private int _score;

    private List<Person> _persons = new List<Person>();

    DatingRepository _repository = new TestDatingRepository(new JwtToken(""));

    public void AddGirl()
    {
        if (IsValidGirlInfo(_name.text, _age.text, _description.text))
        {
            AddGirlToList();
            UpdateScore();
            
            Debug.Log($"{_name.text} \n {_age.text} \n {_description.text} \n {_contact.text}");

            ClearFields();
            BackMenu();
        }
        else
        {
            Debug.LogWarning("Invalid girl information.");
        }
    }

    public List<Person> GetGirlsList()
    {
        return _persons;
    }

    private bool IsValidGirlInfo(string name, string age, string description)
    {
        return IsValidName(name) && IsValidAge(age) && IsValidDescription(description);
    }

    private bool IsValidName(string name)
    {
        return !string.IsNullOrEmpty(name);
    }

    private bool IsValidAge(string age)
    {
        return !string.IsNullOrEmpty(age) && int.TryParse(age, out _);
    }

    private bool IsValidDescription(string description)
    {
        return !string.IsNullOrEmpty(description);
    }

    private void AddGirlToList()
    {
        int age;
        int.TryParse(_age.text, out age);
        Person person = new Person(_name.text, age, _description.text, _contact.text);
        _persons.Add(_repository.Keep(person));
    }

    private void UpdateScore()
    {
        _scoreText.text = _score.ToString();
    }

    private void ClearFields()
    {
        _name.text = null;
        _age.text = null;
        _description.text = null;
        _contact.text = null;
    }
    private void BackMenu()
    {
        _addingGirlsUI.SetActive(false);
        _mainMenuUI.SetActive(true);
    }
}
