using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlsStatisticsController : MonoBehaviour
{
    [SerializeField] private GirlsController _girlsController;

    [SerializeField] private GameObject _elementPrefab;
    [SerializeField] private GameObject _mainMenuUI;
    [SerializeField] private GameObject _statisticsUI;

    [SerializeField] private Transform _contentParent;

    private RectTransform _contentRectTransform;

    private List<Person> _persons = new List<Person>();

    private DatingRepository _datingRepository = new TestDatingRepository(new JwtToken(""));

    private List<GameObject> _objectsOnScene = new List<GameObject>();

    public void Initialize()
    {
        InitializeListAndContent();
        foreach (Person person in _persons) AddContentItem(person);
    }

    public void Back()
    {
        _mainMenuUI.SetActive(true);
        _statisticsUI.SetActive(false);

        foreach (GameObject objectOnScene in _objectsOnScene)
        {
            Destroy(objectOnScene);
        }
        _objectsOnScene.Clear();
    }

    private void InitializeListAndContent()
    {
        _persons = _girlsController.GetGirlsList();
        _contentRectTransform = _contentParent.GetComponent<RectTransform>();
    }

    private void AddContentItem(Person person)
    {
        GameObject newElement = Instantiate(_elementPrefab, _contentParent);
        _objectsOnScene.Add(newElement);
        SetContentTexts(newElement, person);

        SetActionOnButton(newElement, person);

        RefreshSizeContent(1);

    }

    private void SetContentTexts(GameObject newElement, Person person)
    {
        Text[] texts = newElement.GetComponentsInChildren<Text>();
        texts[0].text = person.GetName();
        texts[1].text = person.GetAge().ToString();
        texts[2].text = person.GetContact();
        texts[3].text = person.GetDescription();
    }

    private void SetActionOnButton(GameObject newElement, Person person)
    {
        Button delelingGirlButton = newElement.GetComponentInChildren<Button>();
        delelingGirlButton.onClick.AddListener(() => OnDeleteButtonClicked(newElement, person));
    }

    private void OnDeleteButtonClicked(GameObject newElement, Person person)
    {
        DeletePerson(newElement, person);
        RefreshSizeContent(-1);
    }

    private void DeletePerson(GameObject newElement, Person person)
    {
        Destroy(newElement);
        _persons.Remove(person);
        _datingRepository.Drop(person);
    }

    private void RefreshSizeContent(int increment)
    {
        float elementHeight = _elementPrefab.GetComponent<RectTransform>().rect.height;
        Debug.Log(elementHeight);
        _contentRectTransform.sizeDelta = new Vector2(_contentRectTransform.sizeDelta.x, _contentRectTransform.sizeDelta.y + elementHeight * increment);
        Debug.Log(_contentRectTransform.sizeDelta);
    }


}
