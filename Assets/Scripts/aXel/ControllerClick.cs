using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerClick : MonoBehaviour {

    public bool left;
    public bool right;
    public bool up;
    public bool down;

    public bool selected;
    public bool pressed;

    public AudioSource ClickDown;
    public AudioSource ClickUp;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonUp (0)) {
            
            pressed = false;

        }
    }

    void OnMouseOver () {

                if (Input.GetMouseButtonDown (0)) {
                    if(ClickDown!=null)
                {
                    ClickDown.Play();
                }
                    
             selected = true;
             pressed = true;
        

        }
        if (Input.GetMouseButtonUp (0)) {
            if(ClickUp!=null)
                {
                    ClickUp.Play();
                }
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