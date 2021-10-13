using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlace : MonoBehaviour
{

    public bool ItemListStartOne;
    public bool ItemListStartTwo;
    public bool ItemListStartThree;
    public bool ItemListStart;
    public bool fullOne;
    public bool fullTwo;
    public bool fullThree;

    public GameObject ItemOne;
    public GameObject ItemTwo;
    public GameObject ItemThree;

    public bool DragItemOne;
    public bool DragItemTwo;
    public bool DragItemThree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ItemOne)
        {
            DragItemOne = ItemOne.GetComponent<ClickOnKey>().DragOne;
        }
        
        if(ItemTwo)
        {
            DragItemTwo = ItemTwo.GetComponent<ClickOnKey>().DragTwo;
        }
        if(ItemThree)
        {
            DragItemThree = ItemThree.GetComponent<ClickOnKey>().DragThree;
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

        if(this.gameObject.name == "ItemPlace_3")
        {
            ItemListStart = true;
            if(DragItemOne == false)
            {
                
                fullTwo = true;
                ItemListStartTwo = true;
            }

            if(DragItemTwo == false)
            {
                
                fullThree = true;
                ItemListStartThree = true;
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

        if(this.gameObject.name == "ItemPlace_3")
        {
            ItemListStart = true;
            if(DragItemOne == false)
            {
                
                fullTwo = true;
                ItemListStartTwo = true;
            }

            if(DragItemTwo == false)
            {
                
                fullThree = true;
                ItemListStartThree = true;
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

        if(this.gameObject.name == "ItemPlace_3")
        {
            fullThree = false;
        }
    }
}
