﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameComplete : MonoBehaviour
{ public GameObject BrickOneWin;
    public GameObject BrickTwoWin;

    public GameObject LevelThreeRestartButton;


    public GameObject[] NewBricks;

    public GameObject[] BricksGrey;

    public GameObject BrickOne;
    public GameObject BrickTwo;

    public GameObject CheatCode;

    public bool OneCorrect;
    public bool TwoCorrect;

    public GameObject BrickWindowOne;
    public GameObject BrickWindowTwo;
    public GameObject BrickOne_2;
    public GameObject BrickTwo_2;

     public GameObject Controller;
    public GameObject[] Highlights;

    public float aValue;
    public float aTime;
    public float p;
    public float t;


    public float ScreenTime;

    public bool WindowFinish;
    public GameObject Congrats;


    public GameObject[] SolutionBackgrounds;

    public float blinktime;

    public bool winning;
    public bool LevelThreeClear;

    public GameObject[] MovePostions;

    public GameObject[] CurrentSolutions;

    public Button PauseButton;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject Hightlight in Highlights)
        {
            Hightlight.SetActive(false);
        }

        // foreach(GameObject CurrentSolution in CurrentSolutions)
        // {
        //     CurrentSolution.SetActive(true);
        // }
    }

    // Update is called once per frame
    void Update()
    {

        // if(this.gameObject.active == true)
        // {
            
        //     foreach (GameObject Hightlight in Highlights)
        //     {
        //         Hightlight.SetActive(false);
        //     }

        //     foreach(GameObject CurrentSolution in CurrentSolutions)
        //     {
        //         CurrentSolution.SetActive(true);
        //     }
        // }


        OneCorrect = BrickOneWin.GetComponent<WinningArea>().BrickOneInPlace;
        TwoCorrect = BrickTwoWin.GetComponent<WinningArea>().BrickTwoInPlace;

        // if(TwoCorrect == true)
        // {
        //     Debug.Log("change to green");
        //      SolutionBackgrounds[1].transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        //      SolutionBackgrounds[2].transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        // }


        if(OneCorrect == true)
        {
            winning = true;
            Debug.Log("Level three task one Clear");
            StartCoroutine(LevelClear());
        }


    }

    IEnumerator LevelClear()
    {
        if(winning == true)
        {
            foreach (GameObject Highlight in Highlights)
            {
                if(Highlight != null)
                {
                    Highlight.SetActive(true);

            foreach (GameObject SolutionBackground in SolutionBackgrounds)
            {
                SolutionBackground.transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
            }
                
                

                t += Time.deltaTime/aTime;
                float alpha = Highlight.transform.GetComponent<Renderer>().material.color.a;
                p = Mathf.PingPong(t, aValue);

                Color newColor = new Color(1, 1, 1, p);
                Highlight.transform.GetComponent<Renderer>().material.color = newColor;
                }
            }

            yield return new WaitForSeconds(blinktime);
            winning = false;
            LevelThreeClear = true;

            LevelThreeRestartButton.SetActive(false);


                foreach (GameObject SolutionBackground in SolutionBackgrounds)
                {
                    if(SolutionBackground != null)
                    {
                        SolutionBackground.transform.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                    }
                    
                }
            



            
            foreach (GameObject BrickGrey in BricksGrey)
            {
                Destroy(BrickGrey);
            }
            Destroy(BrickOne);
            Destroy(BrickTwo);
            foreach (GameObject Highlight in Highlights)
            {
                Destroy(Highlight);
            }
            
            foreach (GameObject MovePosition in MovePostions)
            {
                Destroy(MovePosition);
            }

            foreach(GameObject CurrentSolution in CurrentSolutions)
        {
            if(CurrentSolution != null)
            {
                CurrentSolution.SetActive(false);
                Destroy(CurrentSolution);
            }

        }


                // foreach(GameObject NewBrick in NewBricks)
                // {
                // if(NewBrick != null)
                // {
                //     NewBrick.SetActive(true);
                // }
                // }

                if(WindowFinish == false)
                {
                    Congrats.SetActive(true);
                    
                }



            yield return new WaitForSeconds(ScreenTime);

            Congrats.SetActive(false);
            WindowFinish = true;
            

            CheatCode.SetActive(true);
            PauseButton.interactable = false;

            if(BrickWindowOne.GetComponent<SelectBrickOne>().SelectFinished == false && BrickWindowTwo.GetComponent<SelectBrickTwo>().SelectFinished == false)
            {
                if(BrickWindowOne != null)
            {
                BrickWindowOne.SetActive(true);
            }
            
            if(BrickWindowTwo != null)
            {
                BrickWindowTwo.SetActive(true);
            }
            }

            
            
            if(BrickOne_2 != null)
            {
                BrickOne_2.SetActive(true);
            }

            if(BrickTwo_2 != null)
            {
                BrickTwo_2.SetActive(true);
            }

        
            
            
        }
    }
}
