using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinButton : MonoBehaviour
{
    public bool selected;

    public long TastenNummer;

    public PinCode PasswortAnalyse;

    public Sprite NotPressed;
    public Sprite Pressed;
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

                this.GetComponent<SpriteRenderer>().sprite = Pressed;
            
            
        }
        else if(selected == false)
        {

                this.GetComponent<SpriteRenderer>().sprite = NotPressed;
            
            
        }
        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {
            
            
            selected = true;
            PasswortAnalyse.Passwort = PasswortAnalyse.Passwort + TastenNummer;

        }
    }
}
