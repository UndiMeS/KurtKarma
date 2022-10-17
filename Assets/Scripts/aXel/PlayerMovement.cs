using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject Up;
    public GameObject Right;
    public GameObject Down;
    public GameObject Left;

    public bool UpPress;
    public bool RightPress;
    public bool DownPress;
    public bool LeftPress;

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

    public GameObject[] NumbersEatenLeft;
    public GameObject[] NumbersEatenRight;

    public BoxCollider2D UpButton;
    public BoxCollider2D RightButton;
    public BoxCollider2D DownButton;
    public BoxCollider2D LeftButton;

    public Animator animator;

    public float speed;

    public GameObject Solution;
    public bool OneFinished;
    public bool TwoFinished;
    public bool ThreeFinished;
    public float solution;


    public float moveSpeed = 5.0f;
    public Transform movePoint;

    public LayerMask whatStopsMovement;

    public GameObject Pause;



    // Start is called before the first frame update
    void Start () {

        movePoint.SetParent (null);
        movePoint.position = this.transform.position;
        StartPosition = this.transform.position;
        UpButton = Up.GetComponent<BoxCollider2D> ();
        RightButton = Right.GetComponent<BoxCollider2D> ();
        DownButton = Down.GetComponent<BoxCollider2D> ();
        LeftButton = Left.GetComponent<BoxCollider2D> ();

        rb = GetComponent<Rigidbody2D> ();

        

        //targetposition = new Vector3 (-3.0f, -43.0f, 0.0f);

        // this.transform.position = StartPosition;
        // this.transform.rotation = StartRotation;

    }

    // Update is called once per frame

    void Update () {

        OneFinished = Solution.GetComponent<SolutionNumbers>().spinOne;
        TwoFinished = Solution.GetComponent<SolutionNumbers>().spinTwo;
        ThreeFinished = Solution.GetComponent<SolutionNumbers>().spinThree;
        solution = Solution.GetComponent<SolutionNumbers>().Solution;



        NumbersEatenLeft = GameObject.FindGameObjectsWithTag("aXelNumberLeft");

        foreach(GameObject NumberEaten in NumbersEatenLeft)
        {
            if(NumberEaten.GetComponent<aXelNumber>().Eaten == true)
            {
                animator.SetBool("Eat", true);
                animator.SetTrigger("EatTrigger");
                NumberEaten.GetComponent<aXelNumber>().Eaten = false;
                NumberEaten.gameObject.SetActive(false);
            }
            // NumberEaten.GetComponent<aXelNumber>().Eaten = false;
            // animator.SetBool("Eat", false);
        }

        NumbersEatenRight = GameObject.FindGameObjectsWithTag("aXelNumberRight");

        foreach(GameObject NumberEaten in NumbersEatenRight)
        {
            if(NumberEaten.GetComponent<aXelNumber>().Eaten == true)
            {
                animator.SetBool("Eat", true);
                animator.SetTrigger("EatTrigger");
                NumberEaten.GetComponent<aXelNumber>().Eaten = false;
                NumberEaten.gameObject.SetActive(false);
            }
            // NumberEaten.GetComponent<aXelNumber>().Eaten = false;
            // animator.SetBool("Eat", false);
        }



        UpPress = Up.GetComponent<ControllerClick> ().selected;
        RightPress = Right.GetComponent<ControllerClick> ().selected;
        DownPress = Down.GetComponent<ControllerClick> ().selected;
        LeftPress = Left.GetComponent<ControllerClick> ().selected;
        //move ();

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= 0.01f)
        {
            move();
        }

        if(solution >= 10.0f && OneFinished == false)
        {

            foreach(GameObject NumberEaten in NumbersEatenLeft)
        {
            NumberEaten.GetComponent<BoxCollider2D>().enabled = false;
        }
        foreach(GameObject NumberEaten in NumbersEatenRight)
        {
            NumberEaten.GetComponent<BoxCollider2D>().enabled = false;
        }

            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            //rb.transform.rotation = Quaternion.Euler (0, 0, 90.0f);

        }

        if(OneFinished == true && TwoFinished == false && solution <= -10.0f)
        {
            foreach(GameObject NumberEaten in NumbersEatenLeft)
        {
            NumberEaten.GetComponent<BoxCollider2D>().enabled = false;
        }

        foreach(GameObject NumberEaten in NumbersEatenRight)
        {
            NumberEaten.GetComponent<BoxCollider2D>().enabled = false;
        }

            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        }

        if(TwoFinished == true && solution >= 10.0f)
        {
            foreach(GameObject NumberEaten in NumbersEatenLeft)
        {
            NumberEaten.GetComponent<BoxCollider2D>().enabled = false;
        }

        foreach(GameObject NumberEaten in NumbersEatenRight)
        {
            NumberEaten.GetComponent<BoxCollider2D>().enabled = false;
        }

            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        }

    }

    void move () {

        if (UpPress == true) {

            rb.transform.rotation = Quaternion.Euler (0, 0, 90.0f);

            //startPosition = new Vector3 (rb.transform.localPosition.x, rb.transform.localPosition.y, rb.transform.localPosition.z);

            //targetposition = new Vector3 (rb.transform.localPosition.x, rb.transform.localPosition.y + step, rb.transform.localPosition.z);

                if(! Physics2D.OverlapCircle(movePoint.position + new Vector3 (0.0f,step, 0.0f), .2f, whatStopsMovement))
                {
                    movePoint.position += new Vector3 (0.0f,step, 0.0f);
                }

                
            
            
            
            

             UpPress = false;
             Up.GetComponent<ControllerClick> ().selected = false;

        }
        if (RightPress == true) {
            rb.transform.rotation = Quaternion.Euler (0, 0, 0.0f);

            //targetposition = new Vector3 (rb.transform.localPosition.x + step, rb.transform.localPosition.y, rb.transform.localPosition.z);
            
            if(! Physics2D.OverlapCircle(movePoint.position + new Vector3 (step,0.0f, 0.0f), .2f, whatStopsMovement))
            {
                movePoint.position += new Vector3 (step, 0.0f, 0.0f);
            }
            

            RightPress = false;

            Right.GetComponent<ControllerClick> ().selected = false;
        }
        if (LeftPress == true) {
            rb.transform.rotation = Quaternion.Euler (180.0f, 0, -180.0f);

            //targetposition = new Vector3 (rb.transform.localPosition.x + -step, rb.transform.localPosition.y, rb.transform.localPosition.z);
            
            if(! Physics2D.OverlapCircle(movePoint.position + new Vector3 (-step,0.0f, 0.0f), .2f, whatStopsMovement))
            {
                movePoint.position += new Vector3 (-step, 0.0f, 0.0f);
            }
            

            LeftPress = false;
            Left.GetComponent<ControllerClick> ().selected = false;
        }
        if (DownPress == true) {
            rb.transform.rotation = Quaternion.Euler (0, 0, -90.0f);

            //targetposition = new Vector3 (rb.transform.localPosition.x, rb.transform.localPosition.y + -step, rb.transform.localPosition.z);
            
            if(! Physics2D.OverlapCircle(movePoint.position + new Vector3 (0.0f,-step, 0.0f), .2f, whatStopsMovement))
            {
                movePoint.position += new Vector3 (0.0f,-step, 0.0f);
            }
            

            DownPress = false;
            Down.GetComponent<ControllerClick> ().selected = false;
        }

    }

}