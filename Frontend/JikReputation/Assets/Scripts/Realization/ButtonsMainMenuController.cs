using UnityEngine;

public class ButtonsMainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuUI;
    [SerializeField] private GameObject _addingGirlsUI;
    [SerializeField] private GameObject _statisticsUI;
    [SerializeField] private GameObject _friendsUI;

    public void AddGirl()
    {
        _addingGirlsUI.SetActive(true);
        _mainMenuUI.SetActive(false);
    }
    public void Statistics()
    {
        _mainMenuUI.SetActive(false);
        _statisticsUI.SetActive(true);
    }
    public void Friends()
    {
        _friendsUI.SetActive(true);
    }
    private void CloseBackUI()
    {
        _mainMenuUI.SetActive(false);   
    }
}
