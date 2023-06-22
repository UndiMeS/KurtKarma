using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayaSymbolDrop : MonoBehaviour
{

    private MayaCodePinBoard BreadDrag;
    private MayaCodePinBoard PointDrag;
    private MayaCodePinBoard LineDrag;

    public GameObject Point;
    public GameObject Line;
    public GameObject Bread;

    public int InstanceCount;
    public bool InstanceCreated;

    public bool ColliderOneEnter = false;
    public bool ColliderTwoEnter = false;
    //public bool ColliderThreeEnter = false;

    public bool selected;
    public bool startselection;
    // Start is called before the first frame update
    void Start()
    {
        InstanceCount = 1;
        startselection = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        GameObject SolutionOneCollider = GameObject.Find("SolutionOne");

        SecretSolutionDetection SolutionOneDetection = SolutionOneCollider.GetComponent<SecretSolutionDetection>();

        // GameObject SolutionTwoCollider = GameObject.Find("SolutionTwo");

        // ScaleRightDetection RightScript = RightCollider.GetComponent<ScaleRightDetection>();

        // GameObject SolutionThreeCollider = GameObject.Find("SolutionThree");

        // ScaleRightDetection RightScript = RightCollider.GetComponent<ScaleRightDetection>();






        BreadDrag = GameObject.Find("BreadSymbol").GetComponent<MayaCodePinBoard>();
        PointDrag = GameObject.Find("Punkt").GetComponent<MayaCodePinBoard>();
        LineDrag = GameObject.Find("Strich").GetComponent<MayaCodePinBoard>();



        if(selected == true){
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(cursorPos.x, cursorPos.y, -1);

            

        }

        // if(selected == false)
        // {
        //     this.GetComponent<CircleCollider2D>().enabled = true;
        // }




                if(ColliderOneEnter == false && ColliderTwoEnter == false && selected == false && startselection == false)
        {
                Destroy(this.gameObject);
        }




    }

    void OnMouseOver(){


        if(Input.GetMouseButton(0)){

            GameObject SolutionOneCollider = GameObject.Find("SolutionOne");
            SecretSolutionDetection SolutionOneDetection = SolutionOneCollider.GetComponent<SecretSolutionDetection>();

            

            selected = true;

            //SolutionOneCollider.GetComponent<BoxCollider2D>().enabled = false;

            // BreadDrag.selected = true;
            // PointDrag.selected = true;
            // LineDrag.selected = true;
            // BreadDrag.InstanceCreated = false;
            // LineDrag.InstanceCreated = false;
            // PointDrag.InstanceCreated = false;

           

            


        }


        else{

            BreadDrag.selected = false;
            PointDrag.selected = false;
            LineDrag.selected = false;

            

            selected = false;
            startselection = false;

            GameObject SolutionOneCollider = GameObject.Find("SolutionOne");

            SolutionOneCollider.GetComponent<SecretSolutionDetection>().PointSelected = false;

            SolutionOneCollider.GetComponent<BoxCollider2D>().enabled = true;

            if(GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().PunktDestroy == true || GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().StrichDestroy == true || GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().BreadDestroy == true)
            {
                Destroy(this.gameObject);
                GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().PunktDestroy = false;
                GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().StrichDestroy = false;
                GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().BreadDestroy = false;

            }

             if(GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().PunktDestroy == true || GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().StrichDestroy == true || GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().BreadDestroy == true)
            {
                Destroy(this.gameObject);
                GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().PunktDestroy = false;
                GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().StrichDestroy = false;
                GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().BreadDestroy = false;
            }

            //  if(GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().PunktDestroy == true || GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().StrichDestroy == true || GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().BreadDestroy == true)
            // {
            //     Destroy(this.gameObject);
            //     GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().PunktDestroy = false;
            //     GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().StrichDestroy = false;
            //     GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().BreadDestroy = false;
            // }
            


           

            

        }

        // if(BreadDrag.InstanceCreated == true || LineDrag.InstanceCreated == true || PointDrag.InstanceCreated == true)
        // {
            
    //}
        }



         void OnTriggerEnter2D(Collider2D col)
    {

        if(col.gameObject.name == "SolutionOne")
        {
            ColliderOneEnter = true;
        }
        if(col.gameObject.name == "SolutionTwo")
        {
            ColliderTwoEnter = true;
        }
        // if(col.gameObject.name == "SolutionThree")
        // {
        //     ColliderThreeEnter = true;
        // }
        
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.name == "SolutionOne")
        {
            ColliderOneEnter = false;
        }
        if(col.gameObject.name == "SolutionTwo")
        {
            ColliderTwoEnter = false;
        }
        // if(col.gameObject.name == "SolutionThree")
        // {
        //     ColliderThreeEnter = false;
        // }
    }

        

   
}
