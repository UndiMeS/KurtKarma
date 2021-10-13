using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningArea : MonoBehaviour
{

   

    public bool BrickOneInPlace;
    public bool BrickTwoInPlace;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    
    void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.tag == "WinningPart")
        {
            Debug.Log("trigger is detecting");
            if(col.name == "WinningPart_2_1" || col.name == "WinningPart_3_1")
            {
                BrickOneInPlace = true;
            }
            if(col.name == "WinningPart_2_2" || col.name == "WinningPart_3_2")
            {
                BrickTwoInPlace = true;
            }
            
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "WinningPart")
        {
            if(col.name == "WinningPart_2_1" || col.name == "WinningPart_3_1")
            {
                BrickOneInPlace = false;
            }
            if(col.name == "WinningPart_2_2" || col.name == "WinningPart_3_2")
            {
                BrickTwoInPlace = false;
            }
            
        }
    }

}
