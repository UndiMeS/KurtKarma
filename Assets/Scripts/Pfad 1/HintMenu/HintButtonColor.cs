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
    public Image BulbImage;
    public float delay = 2f;

    public float HintNumber;
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
            Settings.BlueBulbCount += 1;
            Penalty.SetTrigger("PenaltyBool");
            BulbImage.sprite = YellowBulb;
            AlreadyPressed = true;
            //Destroy (Penalty.gameObject, Penalty.GetCurrentAnimatorStateInfo(0).length + delay); 

            Settings.Hints.Add(HintNumber);
        }
        
    }

    public void FourPenaltyMinutes()
    {
        if(AlreadyPressed == false)
        {
            Time.startTime = Time.startTime - 240;
            Settings.RedBulbCount += 1;
            Penalty.SetTrigger("PenaltyBool");

            BulbImage.sprite = YellowBulb;
            AlreadyPressed = true;
            //Destroy (Penalty.gameObject, Penalty.GetCurrentAnimatorStateInfo(0).length + delay); 

            Settings.Hints.Add(HintNumber);
        }
        
    }
}
