using UnityEngine;
using UnityEngine.UI;

public class GirlsController : MonoBehaviour
{
    [SerializeField] private Text _name;
    [SerializeField] private Text _age;
    [SerializeField] private Text _description;
    [SerializeField] private Text _contact;

    public void Add()
    {
        if (IsValidGirlInfo(_name.text, _age.text, _description.text))
        {
            int age;
            int.TryParse(_age.text, out age);
            Person person = new Person(_name.text, age, _description.text, _contact.text);
            Debug.Log($"{_name.text} \n {_age.text} \n {_description.text} \n {_contact.text}");
        }
        else
        {
            Debug.LogWarning("Invalid girl information.");
        }
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
}
