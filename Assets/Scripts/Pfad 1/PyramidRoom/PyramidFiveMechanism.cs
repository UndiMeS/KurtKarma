using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidFiveMechanism : MonoBehaviour {
    private float angle;
    private Camera myCam;

    public GameObject SpinningWheel;
    public GameObject ReverseSpinningWheel;
    public GameObject GearOne;
    public GameObject GearTwo;

    public GameObject DiscOne;
    public GameObject DiscTwo;

    public bool außen;
    public bool innen;

    public float speed = 50.0f;

    private Vector3 screenPos;
    private float angleOffset;
    public bool MouseActive;
    public GameObject[] gos;

    public GameObject NearestPoint;

    public GameObject SnapRotation;
    //public GameObject DiscSnapRotation;

    // Start is called before the first frame update
    void Start () {
        myCam = Camera.main;
    }

    // Update is called once per frame
    void Update () {

        if (this.gameObject == SpinningWheel) {

            if (Input.GetMouseButtonDown (0)) {
                if (MouseActive == true) {
                    screenPos = myCam.WorldToScreenPoint (transform.position);
                    Vector3 v3 = Input.mousePosition - screenPos;
                    angleOffset = (Mathf.Atan2 (transform.right.y, transform.right.x) - Mathf.Atan2 (v3.y, v3.x)) * Mathf.Rad2Deg;
                }
            }
            //This fires while the button is pressed down
            if (Input.GetMouseButton (0)) {
                if (MouseActive == true) {
                    Vector3 v3 = Input.mousePosition - screenPos;
                    float angle = Mathf.Atan2 (v3.y, v3.x) * Mathf.Rad2Deg;
                    transform.eulerAngles = new Vector3 (0, 0, angle + angleOffset);
                    ReverseSpinningWheel.transform.eulerAngles = -transform.eulerAngles;


                    if(this.gameObject.name == "Rad Links Außen" || this.gameObject.name == "Rad Rechts Mitte")
                    {
                        GearOne.transform.rotation =  DiscOne.transform.rotation;
                        GearTwo.transform.rotation = DiscOne.transform.rotation;
                        außen = true;
                        innen = false;
                    }

                    if(this.gameObject.name == "Rad Links Innen" || this.gameObject.name == "Rad Rechts Innen")
                    {
                        GearOne.transform.rotation = DiscTwo.transform.rotation;
                        GearTwo.transform.rotation = DiscTwo.transform.rotation;
                        außen = false;
                        innen = true;
                    }


                }
            }

        }

        if (MouseActive == false) {

            Vector3 alignedForward = NearestWorldAxis (transform.forward);
            Vector3 alignedUp = NearestWorldAxis (transform.up);
            Quaternion lookRotation = Quaternion.LookRotation (alignedForward, alignedUp);

            transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);

                    // GearOne.transform.eulerAngles = transform.eulerAngles;
                    // GearTwo.transform.eulerAngles = -transform.eulerAngles;



                    if(außen == true)
                    {
                        GearOne.transform.rotation =  DiscOne.transform.rotation;
                        GearTwo.transform.rotation = DiscOne.transform.rotation;
                        außen = false;
                    }

                    if(innen == true)
                    {
                        GearOne.transform.rotation =  DiscTwo.transform.rotation;
                        GearTwo.transform.rotation = DiscTwo.transform.rotation;
                        innen = false;
                    }

        }

    }

    void OnMouseDown () {
        MouseActive = true;
    }

    void OnMouseUp () {
        MouseActive = false;
    }

    private static Vector3 NearestWorldAxis (Vector3 v) {
        if (Mathf.Abs (v.x) < Mathf.Abs (v.y)) {
            v.x = 0;
            if (Mathf.Abs (v.y) < Mathf.Abs (v.z))
                v.y = 0;
            else
                v.z = 0;
        } else {
            v.y = 0;
            if (Mathf.Abs (v.x) < Mathf.Abs (v.z))
                v.x = 0;
            else
                v.z = 0;
        }
        return v;
    }
}