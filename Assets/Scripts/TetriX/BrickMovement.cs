using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMovement : MonoBehaviour {

    public GameObject Up;
    public GameObject Right;
    public GameObject Down;
    public GameObject Left;

    public GameObject TurnLeft;
    public GameObject TurnRight;

    public GameObject BrickWindowOne;
    public GameObject BrickWindowTwo;

    public bool UpPress;
    public bool RightPress;
    public bool DownPress;
    public bool LeftPress;

    public bool TurnRightPress;
    public bool TurnLeftPress;

    public Rigidbody2D rb;

    public float movementStep;
    public float step;

    public Vector3 targetposition;

    private CharacterController controller;

    public Vector3 startPosition;

    //public float dashSpeed;
    //private float dashTime;
    //public float startDashTime;

    public bool ButtonOff;

    public float timeElapsed;

    public Vector3 savedPosition;

    public Vector3 StartPosition;
    public Quaternion StartRotation;

    public GameObject[] NumbersEaten;

    public BoxCollider2D UpButton;
    public BoxCollider2D RightButton;
    public BoxCollider2D DownButton;
    public BoxCollider2D LeftButton;

    public CircleCollider2D TurnRightButton;
    public CircleCollider2D TurnLeftButton;

    public Animator animator;


    public float moveSpeed = 5.0f;
    public Transform movePoint;
    public Transform[] MovePositions;
    public int ReadyToMoveUP = 0;
    public int ReadyToMoveRight = 0;
    public int ReadyToMoveLeft = 0;
    public int ReadyToMove = 0;

    public bool BrickReadyToPick;

    public int ReadyToTurn = 0;

    public Quaternion spin;

    public float smooth = 5.0f;

    public LayerMask whatStopsMovement;
    public LayerMask WinningArea;

    public GameObject movePosition;

    public bool OnBottom = false;

    public BoxCollider2D[] myColliders;

    public bool lost;

    public bool Restart = false;

    public GameObject WinningPlace;

    public Transform DefaultPosition;


    // Start is called before the first frame update
    void OnEnable () {

        movePoint.SetParent (null);
        movePoint.position = this.transform.position;
        StartPosition = this.transform.position;
        UpButton = Up.GetComponent<BoxCollider2D> ();
        RightButton = Right.GetComponent<BoxCollider2D> ();
        DownButton = Down.GetComponent<BoxCollider2D> ();
        LeftButton = Left.GetComponent<BoxCollider2D> ();

        rb = GetComponent<Rigidbody2D> ();

        myColliders = this.gameObject.GetComponents<BoxCollider2D>();

        //step = (float)Screen.height / step;

        

        //targetposition = new Vector3 (-3.0f, -43.0f, 0.0f);

        // this.transform.position = StartPosition;
        // this.transform.rotation = StartRotation;

    }

    // Update is called once per frame

    void Update () {




        UpPress = Up.GetComponent<ControllerClick> ().selected;
        RightPress = Right.GetComponent<ControllerClick> ().selected;
        DownPress = Down.GetComponent<ControllerClick> ().selected;
        LeftPress = Left.GetComponent<ControllerClick> ().selected;

        TurnRightPress = TurnRight.GetComponent<ControllerClick>().selected;
        TurnLeftPress = TurnLeft.GetComponent<ControllerClick>().selected;
        
        //move ();

        if(ReadyToMove == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

            StartCoroutine(Lost());
            
        }
        else
        {
            if(movePoint != null)
            {
                movePoint.position = this.transform.position;
            }
            
        }





        if(Restart == true)
        {
            // movePoint.position = DefaultPosition.position;
            
            
            // DefaultPosition.position = StartPosition;
            // movePoint.SetParent(this.gameObject.transform);
            // movePoint.position = new Vector3(0.0f,0.0f,0.0f);




            foreach(BoxCollider2D bc in myColliders)
            {
                bc.enabled = false;
                Debug.Log("bc disable");
            }
            this.gameObject.layer = LayerMask.NameToLayer("Default");

            OnBottom = false;
            Restart = false;
            if(BrickWindowOne != null)
            {
                BrickWindowOne.GetComponent<SelectBrickOne>().SelectFinished = false;
            }
            
            if(BrickWindowTwo != null)
            {
                BrickWindowTwo.GetComponent<SelectBrickTwo>().SelectFinished = false;
                
            }

            this.enabled = false;


            
        }

        if(ReadyToTurn == 4)
        {
            //rb.transform.rotation = spin;
            rb.transform.rotation = spin;
        }

        


        

        //transform.position = new Vector3(movePoint.position.x, movePoint.position.y, movePoint.position.z);

        if(Vector3.Distance(transform.position, movePoint.position) <= 0.0001f && OnBottom == false)
        {
            ReadyToTurn = 0;
            ReadyToMove = 0;
            move();

            
        }
        


    }

    void move () {

        if(TurnRightPress == true)
        {

            movePoint.rotation *= Quaternion.Euler (0, 0,  + 90.0f);

            foreach (Transform MovePosition in MovePositions)
            {
                if(! Physics2D.OverlapCircle(MovePosition.position, .1f, whatStopsMovement))
                {
                    
                    //MovePosition.position += new Vector3 (0.0f,-step, 0.0f);
                     //movePoint.rotation = this.transform.rotation;
                    spin = movePoint.rotation;
                    Debug.Log("spinning outside of wall");
                    TurnRight.GetComponent<ControllerClick>().selected = false;
                    ReadyToTurn += 1;
                    
                    
                }
                else
                {
                    Debug.Log("spinning in wall");
                    movePoint.rotation *= Quaternion.Euler (0, 0,  - 90.0f);
                    //movePoint.position += new Vector3 (0.0f,0.0f, 0.0f);

                    //Quaternion spin = Quaternion.Euler (0, 0, 0.0f);
                   
                    ReadyToTurn += 0;
                }

                

            }

        }

        if(TurnLeftPress == true)
        {
            movePoint.rotation *= Quaternion.Euler (0, 0,  - 90.0f);

            foreach (Transform MovePosition in MovePositions)
            {
                if(! Physics2D.OverlapCircle(MovePosition.position, .1f, whatStopsMovement))
                {
                    
                    //MovePosition.position += new Vector3 (0.0f,-step, 0.0f);
                     //movePoint.rotation = this.transform.rotation;
                    spin = movePoint.rotation;
                    Debug.Log("spinning left outside of wall");
                    TurnLeft.GetComponent<ControllerClick>().selected = false;
                    ReadyToTurn += 1;
                    
                    
                }
                else
                {
                    Debug.Log("spinning in wall");
                    movePoint.rotation *= Quaternion.Euler (0, 0,  + 90.0f);
                    //movePoint.position += new Vector3 (0.0f,0.0f, 0.0f);

                    //Quaternion spin = Quaternion.Euler (0, 0, 0.0f);
                   
                    ReadyToTurn += 0;
                }

                

            }

        }

        if (UpPress == true) {

            foreach (Transform MovePosition in MovePositions)
            {
                if(! Physics2D.OverlapCircle(MovePosition.position + new Vector3 (0.0f,step, 0.0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3 (0.0f,step, 0.0f);
                    
                ReadyToMove += 1;
                    
                    
                }
                else
                {
                    Debug.Log("going in wall");
                    //movePoint.position = this.transform.position;
                    ReadyToMove += 0;
                }
            }

            
            

             UpPress = false;
             Up.GetComponent<ControllerClick> ().selected = false;

        }
        if (RightPress == true) {

            foreach (Transform MovePosition in MovePositions)
            {
                if(! Physics2D.OverlapCircle(MovePosition.position + new Vector3 (step,0.0f, 0.0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3 (step,0.0f, 0.0f);
                ReadyToMove += 1;
                    
                    
                }
                else
                {
                    Debug.Log("going in wall");
                  //  movePoint.position = this.transform.position;
                    ReadyToMove += 0;
                }
                
            }


            RightPress = false;

            Right.GetComponent<ControllerClick> ().selected = false;
        }
        if (LeftPress == true) {


            foreach (Transform MovePosition in MovePositions)
            {
                if(! Physics2D.OverlapCircle(MovePosition.position + new Vector3 (-step,0.0f, 0.0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3 (-step,0.0f, 0.0f);
                    ReadyToMove += 1;
                }
                
                    
                    
            
                else
                {
                    Debug.Log("going in wall One");
                //   movePoint.position = this.transform.position;
                    ReadyToMove += 0;
                }
            }

                
            

            LeftPress = false;
            Left.GetComponent<ControllerClick> ().selected = false;
        }
        if (DownPress == true) {
           

            foreach (Transform MovePosition in MovePositions)
            {
                if(! Physics2D.OverlapCircle(MovePosition.position + new Vector3 (0.0f,-step, 0.0f), .15f, whatStopsMovement))
                {
                    movePoint.position += new Vector3 (0.0f,-step, 0.0f);
                    ReadyToMove += 1;
                    
                    
                }
                else
                {
                    Debug.Log("going in wall");
                //    movePoint.position = this.transform.position;
                    ReadyToMove += 0;

                }

            }
            
            DownPress = false;
            Down.GetComponent<ControllerClick> ().selected = false;
        }

    }

    public IEnumerator Lost()
    {
        

        foreach (Transform MovePosition in MovePositions)
            {

        if(Physics2D.OverlapCircle(MovePosition.position + new Vector3 (0.0f,-step, 0.0f), .15f, whatStopsMovement))
                {
                    DownPress=false;

                    OnBottom = true;
                    
                    
                    //Debug.Log("open Window One");

                                        foreach(BoxCollider2D bc in myColliders)
                    {
                        bc.enabled = true;
                    }
                    this.gameObject.layer = LayerMask.NameToLayer("StopMovement");

                    



                    if(BrickWindowOne != null)
                    {
                        
                    if(BrickWindowOne.GetComponent<SelectBrickOne>().BrickPicked == true)
                    {
                        BrickWindowOne.GetComponent<SelectBrickOne>().BrickPicked = false;
                    }
                    }

                    if(BrickWindowTwo != null)
                    {

                    if(BrickWindowTwo.GetComponent<SelectBrickTwo>().BrickPicked == true)
                    {
                        BrickWindowTwo.GetComponent<SelectBrickTwo>().BrickPicked = false;
                    }
                    }



                    yield return new WaitForSeconds(0.75f);

                    if(BrickWindowTwo)
                    {
                        
                        if(BrickWindowOne.activeSelf == false || BrickWindowTwo.activeSelf == false)
                        {
                            lost = true;
                            Debug.Log("Lost true");
                        }
                        else{
                            lost = false;
                            Debug.Log("Lost false");
                        }
                    }
                    else{
                        if(BrickWindowOne.activeSelf == false)
                        {
                            lost = true;
                            Debug.Log("Lost true");
                        }
                        else{
                            lost = false;
                            Debug.Log("Lost false");
                        }
                    }


                    





                   



                }
            }
    }

}