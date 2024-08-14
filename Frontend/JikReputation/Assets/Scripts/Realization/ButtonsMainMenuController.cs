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
    }
    public void Statistics()
    {
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
