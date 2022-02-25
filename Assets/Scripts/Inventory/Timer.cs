using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public TMP_Text[] TimerText;
    public string minutes;
    public string seconds;
    public float startTime;
    public float t;
    public string FinalMinutes;
    public string FinalSeconds;
    public GameObject FinalScreen;
    public bool final;
    public TMP_Text FinalTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.time - startTime;

        minutes = ((int) t / 60).ToString("D2");
        seconds = ((int)t % 60).ToString("D2");


        foreach(TMP_Text timertext in TimerText)
        {
            timertext.text = minutes + ":" + seconds;
        }

        if(FinalScreen != null)
        {
            if(FinalScreen.activeSelf == true && final == false)
            {
                
                final = true;
            }
            
        }

        
        


    }

    public void StopTime()
    {
        FinalMinutes = minutes;
        FinalSeconds = seconds;

        FinalTime.text = FinalMinutes + ":" + FinalSeconds;
    }
}
