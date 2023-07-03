using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlace : MonoBehaviour
{

    public bool ItemListStartOne;
    public bool ItemListStartTwo;
    public bool ItemListStart;
    public bool fullOne;
    public bool fullTwo;

    public GameObject ItemOne;
    public GameObject ItemTwo;

    public bool DragItemOne;
    public bool DragItemTwo;

    public bool ItemOneEmpty;
    public bool ItemTwoEmpty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(ItemOne != null && fullOne == false)
        {
            DragItemOne = true;
        }
        else
        {
            DragItemOne = false;
        }

        if(ItemTwo != null && fullTwo == false)
        {
            DragItemTwo = true;
        }
        else
        {
            DragItemTwo = false;
        }

        if(ItemOne == null && DragItemOne == false && fullOne == false)
        {
            ItemOneEmpty = true;
        }
        else
        {
            ItemOneEmpty = false;
        }

        if(ItemTwo == null && DragItemTwo == false && fullTwo == false)
        {
            ItemTwoEmpty = true;
        }
        else
        {
            ItemTwoEmpty = false;
        }

        // if(ItemOne && ItemOne.name == "Schlüssel" || ItemOne && ItemOne.name == "Maya Teller")
        // {
        //     DragItemOne = ItemOne.GetComponent<ClickOnKey>().DragOne;
        // }
        // else if(ItemOne && ItemOne.name == "Münze")
        // {
        //     DragItemOne = ItemOne.GetComponent<ClickOnCoin>().DragOne;
        // }
        // else
        // {
        //     DragItemOne = false;
        // }
        
        // if(ItemTwo && ItemTwo.name == "Schlüssel" || ItemTwo && ItemTwo.name == "Maya Teller")
        // {
        //     DragItemTwo = ItemTwo.GetComponent<ClickOnKey>().DragTwo;
        // }

        // else if(ItemTwo && ItemTwo.name == "Münze")
        // {
        //     DragItemTwo = ItemTwo.GetComponent<ClickOnCoin>().DragTwo;
        // }
        // else
        // {
        //     DragItemTwo = false;
        // }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if(this.gameObject.name == "ItemPlace_1")
        {
            ItemOne = col.gameObject;
            ItemListStart = true;
            fullOne = true;
            ItemListStartOne = true;
        }

        if(this.gameObject.name == "ItemPlace_2")
        {
            ItemTwo = col.gameObject;
            ItemListStart = true;
            if(DragItemOne == false)
            {
                
                fullTwo = true;
                ItemListStartTwo = true;
            }

        }

        
        
    }

        void OnTriggerStay2D(Collider2D col)
    {
        if(this.gameObject.name == "ItemPlace_1")
        {
            ItemListStart = true;
            fullOne = true;
        }

        if(this.gameObject.name == "ItemPlace_2")
        {
            ItemListStart = true;
            if(DragItemOne == false)
            {
                
                fullTwo = true;
            }
            
        }

        
    }

        void OnTriggerExit2D(Collider2D col)
    {
        if(this.gameObject.name == "ItemPlace_1")
        {
            fullOne = false;
        }

        if(this.gameObject.name == "ItemPlace_2")
        {
            fullTwo = false;
        }

       
    }
}
