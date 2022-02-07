using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public TMP_Text[] TimerText;
    public string minutes;
    public float startTime;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.time - startTime;

        minutes = ((int) t / 60).ToString();
        string seconds = ((int)t % 60).ToString();


        foreach(TMP_Text timertext in TimerText)
        {
            timertext.text = minutes + ":" + seconds;
        }
        


    }
}
