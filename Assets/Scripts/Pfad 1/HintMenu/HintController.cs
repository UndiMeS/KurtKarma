using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintController : MonoBehaviour
{

    public GameObject IntroScreenOne;
    public GameObject IntroScreenTwo;
    public GameObject IntroScreenThree;
    public GameObject TabletIntro;
    public GameObject HintScreenOne;
    public GameObject TabletBackground;
    public GameObject GameScreen;
    public GameObject InventoryArrowUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonIntroOne()
    {
        IntroScreenOne.SetActive(false);
        IntroScreenTwo.SetActive(true);
    }

    public void ButtonIntroTwo()
    {
        IntroScreenTwo.SetActive(false);
        IntroScreenThree.SetActive(true);
    }

    public void ButtonIntroThree()
    {
        IntroScreenTwo.SetActive(false);
        IntroScreenThree.SetActive(false);
        TabletIntro.SetActive(false);
        HintScreenOne.SetActive(true);
        GameScreen.SetActive(true);
        InventoryArrowUp.SetActive(true);
        TabletBackground.SetActive(false);
        
    }
}
