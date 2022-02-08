using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HintButtonColor : MonoBehaviour
{

    public Sprite YellowBulb;
    public Timer Time;
    public bool AlreadyPressed = false;
    public Animator Penalty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TwoPenaltyMinutes()
    {
        if(AlreadyPressed == false)
        {
            Time.startTime = Time.startTime - 120;
            Penalty.SetTrigger("PenaltyBool");
            this.gameObject.GetComponent<Image>().sprite = YellowBulb;
            AlreadyPressed = true;
        }
        
    }

    public void FourPenaltyMinutes()
    {
        if(AlreadyPressed == false)
        {
            Time.startTime = Time.startTime - 240;
            Penalty.SetTrigger("PenaltyBool");
            this.gameObject.GetComponent<Image>().sprite = YellowBulb;
            AlreadyPressed = true;
        }
        
    }
}
