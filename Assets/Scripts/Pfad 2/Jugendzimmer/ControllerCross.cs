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

    public AudioSource ClickDown;
    public AudioSource ClickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.name == "TetrixController")
        {

            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                ClickDown.Play();
                UpButton.GetComponent<ControllerClick>().pressed = true;
                UpButton.GetComponent<ControllerClick>().selected = true;
            }
            else if(Input.GetKeyUp(KeyCode.UpArrow))
            {
                ClickUp.Play();
                UpButton.GetComponent<ControllerClick>().pressed = false;
                UpButton.GetComponent<ControllerClick>().selected= false;
            }
            else if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                ClickDown.Play();
                DownButton.GetComponent<ControllerClick>().pressed = true;
                DownButton.GetComponent<ControllerClick>().selected = true;
            }
            else if(Input.GetKeyUp(KeyCode.DownArrow))
            {
                ClickUp.Play();
                DownButton.GetComponent<ControllerClick>().pressed = false;
                DownButton.GetComponent<ControllerClick>().selected = false;
            }
            else if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ClickDown.Play();
                LeftButton.GetComponent<ControllerClick>().pressed = true;
                LeftButton.GetComponent<ControllerClick>().selected = true;
            }
            else if(Input.GetKeyUp(KeyCode.LeftArrow))
            {
                ClickUp.Play();
                LeftButton.GetComponent<ControllerClick>().pressed = false;
                LeftButton.GetComponent<ControllerClick>().selected = false;
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                ClickDown.Play();
                RightButton.GetComponent<ControllerClick>().pressed = true;
                RightButton.GetComponent<ControllerClick>().selected = true;
            }
            else if(Input.GetKeyUp(KeyCode.RightArrow))
            {
                ClickUp.Play();
                RightButton.GetComponent<ControllerClick>().pressed = false;
                RightButton.GetComponent<ControllerClick>().selected = false;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = ButtonNotPressed;
            }




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
