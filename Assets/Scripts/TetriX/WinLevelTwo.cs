using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevelTwo : MonoBehaviour
{
    public GameObject BrickOneWin;
    public GameObject BrickTwoWin;

    public bool OneCorrect;
    public bool TwoCorrect;


     public GameObject Controller;
    public GameObject[] Highlights;

    public float aValue;
    public float aTime;
    public float p;
    public float t;


    public GameObject[] SolutionBackgrounds;

    public float blinktime;

    public bool winning;
    public bool LevelTwoClear;

    public GameObject[] MovePostions;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject Hightlight in Highlights)
        {
            Hightlight.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        OneCorrect = BrickOneWin.GetComponent<WinningArea>().BrickOneInPlace;
        TwoCorrect = BrickTwoWin.GetComponent<WinningArea>().BrickTwoInPlace;

        if(TwoCorrect == true)
        {
            Debug.Log("change to green");
             SolutionBackgrounds[1].transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
             SolutionBackgrounds[2].transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        }


        if(OneCorrect == true && TwoCorrect == true)
        {
            winning = true;
            Debug.Log("Level Two Clear");
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
                
                

                t += Time.deltaTime/aTime;
                float alpha = Highlight.transform.GetComponent<Renderer>().material.color.a;
                p = Mathf.PingPong(t, aValue);

                Color newColor = new Color(1, 1, 1, p);
                Highlight.transform.GetComponent<Renderer>().material.color = newColor;
                }
            }

            yield return new WaitForSeconds(blinktime);
            winning = false;
            LevelTwoClear = true;

            foreach (GameObject SolutionBackground in SolutionBackgrounds)
            {
                SolutionBackground.transform.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            }

            

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
            
        }
    }
}
