using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelThreeWin : MonoBehaviour
{
     public GameObject BrickOneWin;
    public GameObject BrickTwoWin;

    public GameObject[] NewBricks;

    public GameObject[] BricksGrey;

    public GameObject BrickOne;
    public GameObject BrickTwo;

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

    public bool WindowFinish;


    public GameObject[] SolutionBackgrounds;

    public float blinktime;

    public bool winning;
    public bool LevelThreeClear;

    public GameObject[] MovePostions;

    public GameObject CurrentTask;
    public GameObject NextTask;

    public GameObject[] CurrentSolutions;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject Hightlight in Highlights)
        {
            Hightlight.SetActive(false);
        }

        foreach(GameObject CurrentSolution in CurrentSolutions)
        {
            CurrentSolution.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(this.gameObject.active == true)
        {
            foreach (GameObject Hightlight in Highlights)
            {
                Hightlight.SetActive(false);
            }

            foreach(GameObject CurrentSolution in CurrentSolutions)
            {
                CurrentSolution.SetActive(true);
            }
        }


        OneCorrect = BrickOneWin.GetComponent<WinningArea>().BrickOneInPlace;
        TwoCorrect = BrickTwoWin.GetComponent<WinningArea>().BrickTwoInPlace;

        // if(TwoCorrect == true)
        // {
        //     Debug.Log("change to green");
        //      SolutionBackgrounds[1].transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        //      SolutionBackgrounds[2].transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        // }


        if(OneCorrect == true && TwoCorrect == true)
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

            foreach (GameObject SolutionBackground in SolutionBackgrounds)
            {
                SolutionBackground.transform.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            
            foreach (GameObject BrickGrey in BricksGrey)
            {
                //Destroy(BrickGrey);
                BrickGrey.SetActive(false);
            }
            //Destroy(BrickOne);
            BrickOne.SetActive(false);
            //Destroy(BrickTwo);
            BrickTwo.SetActive(false);
            foreach (GameObject Highlight in Highlights)
            {
                //Destroy(Highlight);
                Highlight.SetActive(false);
            }
            foreach (GameObject MovePosition in MovePostions)
            {
                //Destroy(MovePosition);
                MovePosition.SetActive(false);
            }


                foreach(GameObject NewBrick in NewBricks)
                {
                if(NewBrick != null)
                {
                    NewBrick.SetActive(true);
                }
                }
            

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
            
            
        foreach(GameObject CurrentSolution in CurrentSolutions)
        {
            CurrentSolution.SetActive(false);
        }

        CurrentTask.SetActive(false);
        NextTask.SetActive(true);

        }
    }
}
