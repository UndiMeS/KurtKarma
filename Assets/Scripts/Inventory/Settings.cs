using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public GameObject SettingsMenu;
    public GameObject ConfirmMenu;
    public GameObject InventarArrowDown;
    public GameObject GameScreen;
    public GameObject HintBackground;
    public GameObject HintOne;
    public GameObject HintTwo;
    public GameObject HintThree;
    public GameObject HintFour;
    public GameObject HintFive;
    public GameObject HintSix;

    public int HintNumber = 1;
    

    
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

    public void HintButton()
    {
        GameScreen.SetActive(false);
        HintBackground.SetActive(true);
        switch (HintNumber)
        {
            case 1:
                HintOne.SetActive(true);
                break;
            case 2:
                HintTwo.SetActive(true);
                break;
            case 3:
                HintThree.SetActive(true);
                break;
            case 4:
                HintFour.SetActive(true);
                break;
            case 5:
                HintFive.SetActive(true);
                break;
            case 6:
                HintSix.SetActive(true);
                break;
        }
        
    }
    public void CloseHint()
    {
        GameScreen.SetActive(true);
        HintBackground.SetActive(false);
    }

    
    
}
