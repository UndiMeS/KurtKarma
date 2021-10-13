using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventar : MonoBehaviour
{

    public GameObject ArrowUp;
    public GameObject ArrowDown;
    public GameObject ItemBar;
    public Vector3 ItemBarUp;
    public Vector3 ItemBarDown;
    public float ItemBarPositionActive;
    public float ItemBarPositionInactive;
    public float speed = 1.0f;

    public bool ArrowUpClick = false;
    public bool ArrowDownClick = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ArrowUpClick = ArrowUp.GetComponent<InventarArrow>().selected;
        ArrowDownClick = ArrowDown.GetComponent<InventarArrow>().selected;

        ItemBarUp = new Vector3(ItemBar.transform.position.x, ItemBarPositionActive, 0);
        ItemBarDown = new Vector3(ItemBar.transform.position.x, ItemBarPositionInactive, 0);

        if(ArrowUpClick == true && ArrowDownClick == false)
        {
            ItemBar.transform.position = Vector3.Lerp(ItemBar.transform.position, ItemBarUp, Time.deltaTime * speed);
        }

        if(Vector3.Distance (ItemBar.transform.position, ItemBarUp) < 0.02 && ArrowUpClick)
        {
            ArrowUp.GetComponent<InventarArrow>().selected = false;
        }



        if(ArrowDownClick == true && ArrowUpClick == false)
        {
            ItemBar.transform.position = Vector3.Lerp(ItemBar.transform.position, ItemBarDown, Time.deltaTime * speed);
        }

        if(Vector3.Distance (ItemBar.transform.position, ItemBarDown) < 0.02 && ArrowDownClick)
        {
            ArrowDown.GetComponent<InventarArrow>().selected = false;
        }

    }

    public void ArrowUpButton()
    {
        ArrowDownClick = false;
        
            ArrowUp.GetComponent<InventarArrow>().selected = true;
            
        

        

    }

    public void ArrowDownButton()
    {

        ArrowUpClick = false;
        ArrowUp.GetComponent<InventarArrow>().selected = false;
        
            ArrowDownClick = true;

        
        
    }
}
