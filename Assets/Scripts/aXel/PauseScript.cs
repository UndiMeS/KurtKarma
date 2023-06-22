using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseScript : MonoBehaviour
{

    public GameObject LevelOne;
    public GameObject PauseMenu;
    public GameObject Controler;
    public GameObject Axel;
    public Transform leftOne;
    public Transform rightOne;
    public Transform leftTwo;
    public Transform rightTwo;
    public Transform leftThree;
    public Transform rightThree;
    public GameObject LeftZeroOne;
    public GameObject RightZeroOne;
    public GameObject LeftZeroTwo;
    public GameObject RightZeroTwo;
    public GameObject LeftZeroThree;
    public GameObject RightZeroThree;
    public GameObject NumberSolution;
    public GameObject SubmitMenu;
    public GameObject StartMenu;
    public GameObject SubmitRestartOne;
    public GameObject LevelOneComplete;
    public GameObject LevelTwo;
    public GameObject Solution;
    public GameObject LevelThree;
    public GameObject TaskOne;
    public GameObject TaskTwo;
    public GameObject TaskThree;

    public GameObject Particle;

    public GameObject _TermLeft;
    public GameObject _TermRight;

    public GameObject FinalScreen;

    public Transform _MovePosition;
    public bool CompleteOne;
    public bool CompleteTwo;
    public bool CompleteThree;

    public GameObject SolutionScript;

    public bool OneFinished;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
        SubmitMenu.SetActive(false);
        SubmitRestartOne.SetActive(false);
        LevelOneComplete.SetActive(false);
        LevelOne.SetActive(false);
        LevelTwo.SetActive(false);
        LevelThree.SetActive(false);
        FinalScreen.SetActive(false);
        StartMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
         OneFinished = SolutionScript.GetComponent<SolutionNumbers>().LevelOneFinished;
         CompleteOne = SolutionScript.GetComponent<SolutionNumbers>().LevelOneFinished;
         CompleteTwo = SolutionScript.GetComponent<SolutionNumbers>().LevelTwoFinished;
         CompleteThree = SolutionScript.GetComponent<SolutionNumbers>().LevelThreeFinished;


    }

    public void StartGame()
    {
        LevelOne.SetActive(true);
        StartMenu.SetActive(false);
    }

    public void Menu()
    {
        LevelOne.SetActive(false);
        PauseMenu.SetActive(true);
        Controler.SetActive(false);
        Axel.SetActive(false);
    }

    public void CloseMenu()
    {
        if(OneFinished == false)
        {
            LevelOne.SetActive(true);
            PauseMenu.SetActive(false);
            Controler.SetActive(true);
            Axel.SetActive(true);
        }

        if(OneFinished == true && CompleteTwo == false)
        {
            LevelTwo.SetActive(true);
            PauseMenu.SetActive(false);
            Controler.SetActive(true);
            Axel.SetActive(true);
        }

        if(OneFinished == true && CompleteTwo == true)
        {
            LevelThree.SetActive(true);
            PauseMenu.SetActive(false);
            Controler.SetActive(true);
            Axel.SetActive(true);
        }



    }

    public void SubmitRestart()
    {
        PauseMenu.SetActive(false);
        SubmitRestartOne.SetActive(true);
    }

    public void RestartOne()
    {



        if(OneFinished == false)
        {
            foreach (Transform child in leftOne)
            {
                child.gameObject.SetActive(true);
                //child.GetComponent<aXelNumber>().value = 0;

            }

            foreach (Transform child in rightOne)
            {
                child.gameObject.SetActive(true);
                //child.GetComponent<aXelNumber>().value = 0;

            }


                LeftZeroOne.SetActive(true);
                RightZeroOne.SetActive(true);

                LevelOne.SetActive(true);
                PauseMenu.SetActive(false);
                Controler.SetActive(true);
                Axel.SetActive(true);
                SubmitRestartOne.SetActive(false);

          

           
            }

            if(OneFinished == true && CompleteTwo == false)
        {
            foreach (Transform child in leftTwo)
            {
                child.gameObject.SetActive(true);
                //child.GetComponent<aXelNumber>().value = 0;

            }

            foreach (Transform child in rightTwo)
            {
                child.gameObject.SetActive(true);
                //child.GetComponent<aXelNumber>().value = 0;

            }
            LeftZeroOne.SetActive(true);
            RightZeroOne.SetActive(true);

            LevelTwo.SetActive(true);
            PauseMenu.SetActive(false);
            Controler.SetActive(true);
            Axel.SetActive(true);
            SubmitRestartOne.SetActive(false);

           
            }
            if(CompleteTwo == true && CompleteThree == false)
        {
            foreach (Transform child in leftThree)
            {
                child.gameObject.SetActive(true);
                //child.GetComponent<aXelNumber>().value = 0;

            }

            foreach (Transform child in rightThree)
            {
                child.gameObject.SetActive(true);
                //child.GetComponent<aXelNumber>().value = 0;

            }
            LeftZeroOne.SetActive(true);
            RightZeroOne.SetActive(true);

            LevelThree.SetActive(true);
            PauseMenu.SetActive(false);
            Controler.SetActive(true);
            Axel.SetActive(true);
            SubmitRestartOne.SetActive(false);

           
            }

            Axel.transform.position = Axel.GetComponent<PlayerMovement>().StartPosition;
            _MovePosition.position = Axel.GetComponent<PlayerMovement>().StartPosition;
            // Axel.GetComponent<PlayerMovement>().targetposition = new Vector3 (-3.0f, -43.0f, 0.0f);
            Axel.transform.rotation = Axel.GetComponent<PlayerMovement>().StartRotation;

             GameObject.Find("Term_Left").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("Term_Right").GetComponent<TMP_Text>().text = " ";




                 NumberSolution.GetComponent<SolutionNumbers>().NumbersSolution = 0;
                 NumberSolution.GetComponent<SolutionNumbers>().VariableSolution = 0;
                NumberSolution.GetComponent<SolutionNumbers>().Solution = 0;
                 NumberSolution.GetComponent<SolutionNumbers>().EatenNumberCounter = 0;
        
    }

    public void Quit()
    {
        PauseMenu.SetActive(false);
        SubmitMenu.SetActive(true);
    }

    public void ReallyQuit()
    {
        Application.Quit();
    }

    public void ReturnToPause()
    {
        PauseMenu.SetActive(true);
        SubmitMenu.SetActive(false);
        SubmitRestartOne.SetActive(false);

    }

    public void StartLevelTwo()
    {

        // CompleteOne = SolutionScript.GetComponent<SolutionNumbers>().LevelOneFinished;
        // CompleteTwo = SolutionScript.GetComponent<SolutionNumbers>().LevelTwoFinished;
        // CompleteThree = SolutionScript.GetComponent<SolutionNumbers>().LevelThreeFinished;
        
        NumberSolution.GetComponent<SolutionNumbers>().Solution = 0;

        Axel.SetActive(true);
        Particle.transform.position = Axel.transform.position;
        Particle.transform.SetParent(Axel.transform);
        LevelOneComplete.SetActive(false);



        if(CompleteOne == true && CompleteTwo == false && CompleteThree == false)
        {
            // TaskOne.SetActive(false);
            // TaskTwo.SetActive(true);
            //TaskThree.SetActive(false);
            
            LevelOne.SetActive(false);
            LevelTwo.SetActive(true);
            LevelThree.SetActive(false);
            PauseMenu.SetActive(false);
            SubmitRestartOne.SetActive(false);
            SubmitMenu.SetActive(false);

            

            

            _TermLeft.GetComponent<TMP_Text>().color = new Color32(46, 63, 77, 255);
            _TermRight.GetComponent<TMP_Text>().color = new Color32(119, 61, 0, 255);

            LeftZeroOne.SetActive(true);
            RightZeroOne.SetActive(true);

            LeftZeroOne.GetComponent<TMP_Text>().color = new Color32(46, 63, 77, 255);
            RightZeroOne.GetComponent<TMP_Text>().color = new Color32(119, 61, 0, 255);
        }

        if(CompleteTwo == true && CompleteThree == false)
        {
            // TaskTwo.SetActive(false);
            // TaskOne.SetActive(false);
            //TaskThree.SetActive(true);
            LevelOneComplete.SetActive(false);
            LevelTwo.SetActive(false);
            LevelThree.SetActive(true);
            PauseMenu.SetActive(false);
            SubmitRestartOne.SetActive(false);
            SubmitMenu.SetActive(false);

            _TermLeft.GetComponent<TMP_Text>().color = new Color32(108, 72, 53, 255);
            _TermRight.GetComponent<TMP_Text>().color = new Color32(91, 91, 91, 255);

            LeftZeroOne.SetActive(true);
            RightZeroOne.SetActive(true);

            LeftZeroOne.GetComponent<TMP_Text>().color = new Color32(108, 72, 53, 255);
            RightZeroOne.GetComponent<TMP_Text>().color = new Color32(91, 91, 91, 255);
        }
        if(CompleteOne == true && CompleteTwo == true && CompleteThree == true)
        {
            Debug.Log("Winner");
            FinalScreen.SetActive(true);
        }




        
            Axel.transform.position = Axel.GetComponent<PlayerMovement>().StartPosition;
            _MovePosition.position = Axel.GetComponent<PlayerMovement>().StartPosition;
            // Axel.GetComponent<PlayerMovement>().targetposition = new Vector3 (-3.0f, -43.0f, 0.0f);
            Axel.transform.rotation = Axel.GetComponent<PlayerMovement>().StartRotation;

         GameObject.Find("Term_Left").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("Term_Right").GetComponent<TMP_Text>().text = " ";
                 NumberSolution.GetComponent<SolutionNumbers>().NumbersSolution = 0;
                 NumberSolution.GetComponent<SolutionNumbers>().VariableSolution = 0;
                
                 NumberSolution.GetComponent<SolutionNumbers>().EatenNumberCounter = 0;
    }
}
