using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScreenController : MonoBehaviour
{

    public float startTime;
    public float t;
    public int minutes;

    public Timer timer;

    public GameObject ScoreDone;
    public GameObject ScoreSuper;
    public GameObject ScoreCrazy;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.time - startTime;
        minutes = (int)t/60;



        if((int)timer.finalminutes <= 35)
        {
            ScoreCrazy.SetActive(true);
            ScoreDone.SetActive(false);
            ScoreSuper.SetActive(false);
        }
        else if((int)timer.finalminutes > 35 && (int)timer.finalminutes <= 50)
        {
            ScoreCrazy.SetActive(false);
            ScoreSuper.SetActive(true);
            ScoreDone.SetActive(false);
        }
        else if((int)timer.finalminutes > 50)
        {
            ScoreCrazy.SetActive(false);
            ScoreSuper.SetActive(false);
            ScoreDone.SetActive(true);
        }

    }
}
