using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarArrow : MonoBehaviour
{

    public bool selected;
    public GameObject OppositeArrow;
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
                OppositeArrow.GetComponent<InventarArrow>().selected = false;
                
                    selected = true;
                
                
        }

                
    }
}
