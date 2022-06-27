using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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
    public GameObject HintSeven;
    public GameObject InventoryArrowDown;
    public GameObject InventoryArrowUp;
    public InventarArrow InventoryArrowScript;
    public GameObject HintIntro;
    public bool HintIntroBool;

    public static int BlueBulbCount;
    public static int RedBulbCount;
    public static List<float> Hints = new List<float>();

    public List<float> ShowHints = new List<float>();
    

    public int HintNumber = 1;
    

    
    // Start is called before the first frame update
    void Start()
    {
        SettingsMenu.SetActive(false);
        ConfirmMenu.SetActive(false);
        InventoryArrowScript = InventoryArrowDown.GetComponent<InventarArrow>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowHints = Hints;
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
        SceneManager.LoadScene("StartMenu");
        //Application.Quit();
    }

    public void HintButton()
    {
        GameScreen.SetActive(false);
        HintBackground.SetActive(true);
        InventoryArrowScript.OppositeArrow.GetComponent<InventarArrow>().selected = false;
        InventoryArrowScript.selected = true;
        InventoryArrowUp.SetActive(false);

        if(HintIntroBool == false)
        {
            HintIntro.SetActive(true);
            HintIntroBool = true;
        }
        else
        {
            switch (HintNumber)
        {
            case 1:
                HintOne.SetActive(true);
                HintTwo.SetActive(false);
                HintThree.SetActive(false);
                HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                HintSeven.SetActive(false);
                break;
            case 2:
                HintOne.SetActive(false);
                HintTwo.SetActive(true);
                HintThree.SetActive(false);
                HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                HintSeven.SetActive(false);
                break;
            case 3:
            HintOne.SetActive(false);
                HintTwo.SetActive(false);
                HintThree.SetActive(true);
                HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                HintSeven.SetActive(false);
                break;
            case 4:
            HintOne.SetActive(false);
            HintTwo.SetActive(false);
                HintThree.SetActive(false);
                HintFour.SetActive(true);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                HintSeven.SetActive(false);
                break;
            case 5:
            HintOne.SetActive(false);
            HintTwo.SetActive(false);
            HintThree.SetActive(false);
                HintFour.SetActive(false);
                HintFive.SetActive(true);
                HintSix.SetActive(false);
                HintSeven.SetActive(false);
                break;
            case 6:
            HintOne.SetActive(false);
            HintTwo.SetActive(false);
            HintThree.SetActive(false);
            HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(true);
                HintSeven.SetActive(false);
                break;
            case 7:
            HintOne.SetActive(false);
            HintTwo.SetActive(false);
            HintThree.SetActive(false);
            HintFour.SetActive(false);
                HintFive.SetActive(false);
                HintSix.SetActive(false);
                HintSeven.SetActive(true);
                break;
        }
        }
        
        
    }
    public void CloseHint()
    {
        GameScreen.SetActive(true);
        InventoryArrowUp.SetActive(true);
        HintBackground.SetActive(false);
    }

    public void CloseHintIntro()
    {
        HintIntroBool = false;
        GameScreen.SetActive(true);
        InventoryArrowUp.SetActive(true);
        HintBackground.SetActive(false);
    }

    
    
}
