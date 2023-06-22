using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCross : MonoBehaviour
{
    public Sprite UpButtonPressed;

    public Sprite DownButtonPressed;

    public Sprite RightButtonPressed;

    public Sprite LeftButtonPressed;

    public Sprite ButtonNotPressed;

    public GameObject UpButton;
    public GameObject DownButton;
    public GameObject RightButton;
    public GameObject LeftButton;

    public bool UpPress;
    public bool DownPress;
    public bool RightPress;
    public bool LeftPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name == "TetrixController")
        {
            UpPress = UpButton.GetComponent<ControllerClick>().pressed;
            DownPress = DownButton.GetComponent<ControllerClick>().pressed;
            RightPress = RightButton.GetComponent<ControllerClick>().pressed;
            LeftPress = LeftButton.GetComponent<ControllerClick>().pressed;
        }
        else{
            UpPress = UpButton.GetComponent<ControllerButton>().selected;
            DownPress = DownButton.GetComponent<ControllerButton>().selected;
            RightPress = RightButton.GetComponent<ControllerButton>().selected;
            LeftPress = LeftButton.GetComponent<ControllerButton>().selected;
        }

        

        if(UpPress == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = UpButtonPressed;
        }
        else if(DownPress == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = DownButtonPressed;
        }
        else if(RightPress == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = RightButtonPressed;
        }
        else if(LeftPress == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = LeftButtonPressed;
        }
        else{
            this.GetComponent<SpriteRenderer>().sprite = ButtonNotPressed;
        }


        
    }
}
