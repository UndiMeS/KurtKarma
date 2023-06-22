using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShake : MonoBehaviour
{
    public Animator ButtonAnimation;
    public GameObject OptionButton;
    // Start is called before the first frame update
    void Start()
    {
        ButtonAnimation.speed = 0;
    }
    void Awake()
    {
        ButtonAnimation.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {

                
            
        }

    
    
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ButtonAnimation.speed = 1;
            if(OptionButton != null)
            {
                OptionButton.GetComponent<Animator>().speed = 0;
            }
    }
        

     }

    void OnMouseExit()
    {
        
            ButtonAnimation.speed = 0;
        
        
    }
}
