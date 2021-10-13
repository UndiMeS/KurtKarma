using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBrickOne : MonoBehaviour
{

    public GameObject Brick;
    public GameObject BrickTwo;
    public bool BrickPicked = false;
    public bool SelectFinished;
    // Start is called before the first frame update
    void Start()
    {
        Brick.GetComponent<BrickMovement>().enabled = false;
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
            if(Brick.name == "BrickOne")
            {

                    
                    Brick.transform.localPosition = new Vector3(-20.6f, 365.9f, 0.0f);
                    Brick.GetComponent<BrickMovement>().enabled = true;
                    Brick.GetComponent<BrickMovement>().movePoint.localScale = Brick.transform.localScale;
                    //Destroy(this.gameObject);
                    this.gameObject.SetActive(false);
                
            }
            else if(Brick.name == "BrickOne_3_3" || Brick.name == "BrickOne_3_4")
            {
                if(BrickTwo != null)
                {
                    BrickTwo.GetComponent<SelectBrickTwo>().BrickPicked = true;
                }
                else{
                    BrickTwo.GetComponent<SelectBrickTwo>().BrickPicked = false;
                }

                


                    Brick.transform.localPosition = new Vector3(-60.6f, 402.5f, 0.0f);
                    Brick.GetComponent<BrickMovement>().movePoint.position = Brick.transform.position;
                    Brick.GetComponent<BrickMovement>().movePoint.localScale = Brick.transform.localScale;
                    //Destroy(this.gameObject);
                    Brick.GetComponent<BrickMovement>().enabled = true;
                    Brick.GetComponent<BrickMovement>().OnBottom = false;
                    Brick.GetComponent<BrickMovement>().Restart = false;
                    this.gameObject.SetActive(false);
                    SelectFinished = true;
            }
            else{
                if(BrickTwo != null)
                {
                    BrickTwo.GetComponent<SelectBrickTwo>().BrickPicked = true;
                }
                else{
                    BrickTwo.GetComponent<SelectBrickTwo>().BrickPicked = false;
                }

                
                Brick.GetComponent<BrickMovement>().enabled = true;
                Brick.GetComponent<BrickMovement>().OnBottom = false;
                Brick.GetComponent<BrickMovement>().Restart = false;

                    Brick.transform.localPosition = new Vector3(-19.3f, 363.2f, 0.0f);
                    Brick.GetComponent<BrickMovement>().movePoint.position = Brick.transform.position;
                    //Destroy(this.gameObject);
                    this.gameObject.SetActive(false);
                    SelectFinished = true;
            }

            // if(Brick.name == "BrickOne_2" || Brick.name == "BrickOne_3" || Brick.name == "BrickOne_3_2")
            // {

            //     if(BrickTwo != null)
            //     {
            //         BrickTwo.GetComponent<SelectBrickTwo>().BrickPicked = true;
            //     }

                
            //     Brick.GetComponent<BrickMovement>().enabled = true;
            //     Brick.GetComponent<BrickMovement>().OnBottom = false;

            //         Brick.transform.localPosition = new Vector3(-19.3f, 363.2f, 0.0f);
            //         Destroy(this.gameObject);
                
            // }

            
            }
           

        }
    }
}
