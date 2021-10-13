using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBrickTwo : MonoBehaviour
{

    public GameObject Brick;
    public GameObject BrickOne;
    public bool BrickPicked = false;
    public bool SelectFinished;
    // Start is called before the first frame update
    void Start()
    {
        //Brick.GetComponent<BrickMovement>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(BrickPicked == false)
            {

                if(BrickOne != null)
                    {
                        BrickOne.GetComponent<SelectBrickOne>().BrickPicked = true;
                    }
                    
                    
                    Debug.Log("move finally");

                    Brick.transform.localPosition = new Vector3(-100.0f, 363.6f, 0.0f);
                    Brick.GetComponent<BrickMovement>().movePoint.position = Brick.transform.position;
                    Brick.GetComponent<BrickMovement>().OnBottom = false;
                    //Destroy(this.gameObject);
                    Brick.GetComponent<BrickMovement>().enabled = true;
                    Brick.GetComponent<BrickMovement>().Restart = false;
                    this.gameObject.SetActive(false);
                    SelectFinished = true;
            

            // if(Brick.name == "BrickTwo_2" || Brick.name == "BrickTwo_3" || Brick.name == "BrickTwo_3_2")
            // {
            //         if(BrickOne != null)
            //         {
            //             BrickOne.GetComponent<SelectBrickOne>().BrickPicked = true;
            //         }
                    
            //         Brick.GetComponent<BrickMovement>().enabled = true;
                    

            //         Brick.transform.localPosition = new Vector3(-100.0f, 363.6f, 0.0f);
            //         Brick.GetComponent<BrickMovement>().OnBottom = false;
            //         Destroy(this.gameObject);
                
            // }
            }
           

        }
    }
}
