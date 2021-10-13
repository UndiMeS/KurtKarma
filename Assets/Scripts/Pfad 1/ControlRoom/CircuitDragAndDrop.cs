using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitDragAndDrop : MonoBehaviour
{

    public bool ChipColliderEnter;
    public bool ChipColliderExit;

    public int ChipNumber;

    public bool RightInPlace;

    public bool selected;

    public GameObject ChipSlot;
    public GameObject ChipSet;

    public bool Draggable = true;

    void OnMouseDrag(){
        if(Draggable == true)
        {
            transform.position = GetMousePos();
        }
        
    }

    Vector3 GetMousePos(){
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ChipColliderEnter == true && selected == false)
        {
            ChipSlot.GetComponent<ChipSpot>().loaded = true;
            this.transform.position = new Vector3(ChipSlot.transform.position.x, ChipSlot.transform.position.y - 0.05f,ChipSlot.transform.position.z -1.0f);
            if(ChipNumber == ChipSlot.GetComponent<ChipSpot>().SlotNumber)
            {
                RightInPlace = true;
            }
        }

        if(ChipColliderEnter == false && selected == false)
        {
            this.transform.position = new Vector3(ChipSet.transform.position.x, ChipSet.transform.position.y,ChipSet.transform.position.z);
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            selected = true;
        }

        if(Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.tag == "ChipPlace") {
            if(col.gameObject.GetComponent<ChipSpot>().loaded == false)
            {
                ChipColliderEnter = true;
            ChipColliderExit = false;

            ChipSlot = col.gameObject;
            
            }
            
        }
    }

        void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject.tag == "ChipPlace") {
            ChipColliderEnter = false;
            ChipColliderExit = true;

            RightInPlace = false;

            if(col.gameObject.GetComponent<ChipSpot>().loaded == true)
            {
                col.gameObject.GetComponent<ChipSpot>().loaded = false;
            }

            ChipSlot = null;
        }
    }
}
