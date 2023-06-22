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

    // Start is called before the first frame update
    void Start () {
        StartPosition = this.transform.position;
        x = 1;

        thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount = 1;
    }

    // Update is called once per frame
    void Update () {

        if (selected == true && instance != null) {

            Vector2 cursorPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

            instance.transform.position = new Vector3 (cursorPos.x, cursorPos.y,-1);

            

        }

    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {

            x = thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount;

            selected = true;
            instance = Instantiate (thePrefab, transform.position, transform.rotation);
            InstanceCreated = true;
            //instance.name = thePrefab.name + "_" + x.ToString();
            instance.name = thePrefab.name;
            instance.transform.parent = ParentObject.transform;
            instance.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, -1);
            thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount = thePrefab.GetComponent<MayaSymbolDrop>().InstanceCount +1;


            // punktcount = GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().PunktCount;

            // if(punktcount > 4)
            // {
            //     GameObject.Find("SolutionOne").GetComponent<BoxCollider2D>().enabled = false;
            // }

        }

        if (Input.GetMouseButtonUp (0)) {

            selected = false;
            //transform.position = StartPosition;

        }
    }
}