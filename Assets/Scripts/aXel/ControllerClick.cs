using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerClick : MonoBehaviour {

    public bool selected;
    public bool pressed;
    public bool iphone;
    public bool android;
    public AudioSource UpClickSound;
    public AudioSource DownClickSound;
    // Start is called before the first frame update
    void Start () {
        #if UNITY_IOS
            iphone = true;
        #endif
        #if UNITY_ANDROID
            android = true;
        #endif
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonUp (0)) {
            if(pressed == true && UpClickSound != null)
            {
                UpClickSound.Play();
            }
            
            pressed = false;

        }
        if(this.gameObject.name == "ButtonDown")
        {
            if(iphone == false && android == false)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown("s"))
                {
                    pressed = true;
                    selected = true;
                    DownClickSound.Play();
                }

                if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s"))
                {
                    pressed = false;
                    selected = false;
                    UpClickSound.Play();
                }
            }
            
        }
        if(this.gameObject.name == "ButtonUp")
        {

            if(iphone == false && android == false)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown("w"))
                {
                    pressed = true;
                    selected = true;
                    DownClickSound.Play();
                }

                if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp("w"))
                {
                    pressed = false;
                    selected = false;
                    UpClickSound.Play();
                }
            }

            
        }

        if(this.gameObject.name == "ButtonRight")
        {
            if(iphone == false && android == false){
                if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown("d"))
                {
                    pressed = true;
                    selected = true;
                    DownClickSound.Play();
                }

                if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp("d"))
                {
                    pressed = false;
                    selected = false;
                    UpClickSound.Play();
                }
            }
            

        }

        if(this.gameObject.name == "ButtonLeft")
        {
            if(iphone == false && android == false){
                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown("a"))
                {
                    pressed = true;
                    selected = true;
                    DownClickSound.Play();
                }

                if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp("a"))
                {
                    pressed = false;
                    selected = false;
                    UpClickSound.Play();
                }
            }
            
        }

        
        
        
    }

    void OnMouseOver () {

                if (Input.GetMouseButtonDown (0)) {

             selected = true;
             pressed = true;

            if(DownClickSound != null)
            {
                DownClickSound.Play();
            }
             
        

        }
        if (Input.GetMouseButtonUp (0)) {
            
            selected = false;



        }


        
    }

    // IEnumerator waiter () {
    //     selected = true;
    //     yield return new WaitForSeconds (0.0f);
    //     selected = false;
    //     yield return new WaitForSeconds (0.0f);
    // }
}