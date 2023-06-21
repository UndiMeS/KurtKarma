using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButton : MonoBehaviour
{
     public bool selected;

    public long TastenNummer;

    public GameObject Button;

    public Sprite NotPressed;
    public Sprite Pressed;

    public CheatCode PasswortAnalyse;
    public AudioSource ControllerClickDown;
    public AudioSource ControllerClickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp (0)){
            selected = false;
            
            
        }


        if(selected == true)
        {
            if(Button != null)
            {
                Button.GetComponent<SpriteRenderer>().sprite = Pressed;
                
            }
            
        }
        else if(selected == false)
        {
            if(Button != null)
            {
                
                Button.GetComponent<SpriteRenderer>().sprite = NotPressed;
            }
            
        }

        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {
            
            ControllerClickDown.Play();
            selected = true;

            if(this.gameObject.tag == "SNESController")
            {
                PasswortAnalyse.Passwort = PasswortAnalyse.Passwort + TastenNummer;
            }
            



        }
        if(Input.GetMouseButtonUp(0))
        {
            ControllerClickUp.Play();
        }

    }
}
