using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject Controller;
    public GameObject[] Highlights;
    public GameObject LevelTwo;
    public GameObject LevelOne;
    public GameObject WinningScreen;
    public GameObject MovePostionOne;
    public bool BrickOneWin = false;
    public bool BrickTwoWin = false;

    public float aValue;
    public float aTime;
    public float p;
    public float t;
    public bool winning;
    public bool LevelOneClear;

    public bool LevelOneLost;

    public GameObject Brick;


    public GameObject[] SolutionBackgrounds;

    public float blinktime;
    // Start is called before the first frame update
    void Start()
    {
        LevelTwo.SetActive(false);
        WinningScreen.SetActive(false);
        foreach (GameObject Hightlight in Highlights)
        {
            Hightlight.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        LevelOneLost = Brick.GetComponent<BrickMovement>().lost;

         StartCoroutine(LevelClear());

        // if(BrickOneWin == true && BrickTwoWin == true)
        // {
        //     Debug.Log("Level Two Clear");
        // }
    }


    IEnumerator LevelClear()
    {
        if(winning == true)
        {
            foreach (GameObject Highlight in Highlights)
            {
                Highlight.SetActive(true);

                t += Time.deltaTime/aTime;
                float alpha = Highlight.transform.GetComponent<Renderer>().material.color.a;
                p = Mathf.PingPong(t, aValue);

                Color newColor = new Color(1, 1, 1, p);
                Highlight.transform.GetComponent<Renderer>().material.color = newColor;
            }

            yield return new WaitForSeconds(blinktime);
            winning = false;
            LevelOneClear = true;

            // foreach (GameObject SolutionBackground in SolutionBackgrounds)
            // {
            //     SolutionBackground.transform.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            // }

            

            foreach (GameObject Highlight in Highlights)
            {
                //Destroy(Highlight);
                if(Highlight != null)
                {
                    Highlight.SetActive(false);
                }
            }
            //Destroy(MovePostionOne);
            if(MovePostionOne != null)
            {
                MovePostionOne.SetActive(false);
            }
        
    }

    if(LevelOneLost == true && winning == false)
    {
        Debug.Log("verloren");
    }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "WinningPart")
        {
            Debug.Log("Level One Clear");
            Controller.SetActive(false);

            foreach (GameObject SolutionBackground in SolutionBackgrounds)
            {
                SolutionBackground.transform.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
            }

            LevelOneLost = false;

            winning = true;

            

        }

    }
}
