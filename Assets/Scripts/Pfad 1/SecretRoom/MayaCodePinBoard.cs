using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayaCodePinBoard : MonoBehaviour {

    public bool selected;
    public GameObject thePrefab;
    static GameObject instance;
    public GameObject ParentObject;
    Vector3 StartPosition;
    static int x;
    public bool InstanceCreated;
    public int punktcount;

    public bool DragItem;

    // Start is called before the first frame update
    void Start () {
        StartPosition = this.transform.position;
        x = 1;

        thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount = 1;
    }

    // Update is called once per frame
    void Update () {



        if (selected == true && instance != null && DragItem == false) {

            Vector2 cursorPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

            instance.transform.position = new Vector3 (cursorPos.x, cursorPos.y,-1);
            instance.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, -1);

            DragItem = true;



            //this.transform.position = new Vector3 (cursorPos.x, cursorPos.y,-1);

            

        }
        if(Input.GetMouseButtonUp(0))
        {
            DragItem = false;
        }

    }

    void OnMouseDown () {

        if (Input.GetMouseButtonDown (0)) {


            //Do your thing.
             x = thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount;

            selected = true;
            instance = Instantiate (thePrefab, transform.position, transform.rotation);
            InstanceCreated = true;
            //instance.name = thePrefab.name + "_" + x.ToString();
            instance.name = thePrefab.name;
            instance.transform.parent = ParentObject.transform;
            instance.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, -1);
            thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount = thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount +1;
        

           



        }


    }
    public void OnMouseUp()
    {
        selected = false;
            DragItem = false;
            instance.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, -1);
    }
}