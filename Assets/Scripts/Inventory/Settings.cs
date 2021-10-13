using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public GameObject SettingsMenu;
    public GameObject ConfirmMenu;
    public GameObject InventarArrowDown;
    // Start is called before the first frame update
    void Start()
    {
        SettingsMenu.SetActive(false);
        ConfirmMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingsButton()
    {
        SettingsMenu.SetActive(true);
        ConfirmMenu.SetActive(false);
        InventarArrowDown.SetActive(false);
    }

    public void ConfirmButton()
    {
        SettingsMenu.SetActive(false);
        ConfirmMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        SettingsMenu.SetActive(false);
        ConfirmMenu.SetActive(false);
        InventarArrowDown.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
    
}
