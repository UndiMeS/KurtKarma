using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour
{

    public bool selected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
                //cursorStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                selected = true;
                
        }

        
    }
}
