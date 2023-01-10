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
    public string penaltiminutes;
    public string neededminutes;
    public string NeededMinutes;
    public float startTime;
    public float t;
    public string FinalMinutes;
    public string FinalSeconds;
    public GameObject FinalScreen;
    public bool final;
    public float finalminutes;
    public TMP_Text FinalTime;
    public TMP_Text InventoryTime;
    public TMP_Text FinalTimer;
    public TMP_Text PenaltiTimer;
    public TMP_Text NeededTime;
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

        penaltiminutes = ((int)Settings.BlueBulbCount * 2 + Settings.RedBulbCount * 4).ToString("D2");

        neededminutes = ((int) (t / 60) - (Settings.BlueBulbCount * 2 + Settings.RedBulbCount * 4)).ToString("D2");


       
        InventoryTime.text = minutes + ":" + seconds;
        FinalTime.text = minutes + ":" + seconds;
        FinalTimer.text = FinalMinutes + ":" + FinalSeconds;
        PenaltiTimer.text = penaltiminutes + ":00";
        NeededTime.text = NeededMinutes + ":" + FinalSeconds;
        

       
    }

    public void StopTime()
    {
        FinalMinutes = minutes;
        FinalSeconds = seconds;

        NeededMinutes = neededminutes;

        finalminutes = ( t / 60);

        

        FinalTime.text = FinalMinutes + ":" + FinalSeconds;
    }
}
