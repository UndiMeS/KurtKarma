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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemOne)
        {
            DragItemOne = ItemOne.GetComponent<ClickOnItem>().DragOne;
        }
        
        if(ItemTwo)
        {
            DragItemTwo = ItemTwo.GetComponent<ClickOnItem>().DragTwo;
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if(this.gameObject.name == "ItemPlace_1")
        {
            ItemListStart = true;
            fullOne = true;
            ItemListStartOne = true;
        }

        if(this.gameObject.name == "ItemPlace_2")
        {
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
