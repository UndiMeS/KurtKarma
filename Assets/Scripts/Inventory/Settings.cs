﻿using System.Collections;
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
                HintTwo.SetActive(false);
                HintThree.SetActive(false);
                HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                break;
            case 2:
                HintOne.SetActive(false);
                HintTwo.SetActive(true);
                HintThree.SetActive(false);
                HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                break;
            case 3:
            HintOne.SetActive(false);
                HintTwo.SetActive(false);
                HintThree.SetActive(true);
                HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                break;
            case 4:
            HintOne.SetActive(false);
            HintTwo.SetActive(false);
                HintThree.SetActive(false);
                HintFour.SetActive(true);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                break;
            case 5:
            HintOne.SetActive(false);
            HintTwo.SetActive(false);
            HintThree.SetActive(false);
                HintFour.SetActive(false);
                HintFive.SetActive(true);
                HintSix.SetActive(false);
                break;
            case 6:
            HintOne.SetActive(false);
            HintTwo.SetActive(false);
            HintThree.SetActive(false);
            HintFour.SetActive(false);
                HintFive.SetActive(false);
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
