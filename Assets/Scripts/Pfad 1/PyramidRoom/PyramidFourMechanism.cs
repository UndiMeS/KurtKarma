using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidFourMechanism : MonoBehaviour {

    private float angleTwo;
    private Camera myCam;

    public GameObject SpinningWheel;
    public GameObject ReverseSpinningWheel;
    public GameObject GearOne;
    public GameObject GearTwo;
    public GameObject GearThree;

    public GameObject DiscOne;
    public GameObject DiscTwo;
    public GameObject DiscThree;

    public bool außen;
    public bool mitte;
    public bool innen;

    private Vector3 screenPos;
    private Vector3 screenPosTwo;
    private float angleOffset;
    private float angleOffsetTwo;
    public bool MouseActive;

    public float speed = 50.0f;

    public Vector3 lookAtTarget;
    public Vector3 aimingDir;
    public float angle;
    public Vector3 newDir;
    static Quaternion lookRotation;

    // Start is called before the first frame update
    void Start () {
        myCam = Camera.main;

        Vector3 newDir = Quaternion.Euler (45.0f, 45.0f, 45.0f) * transform.up;

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
                    // GearOne.transform.eulerAngles = transform.eulerAngles;
                    // GearTwo.transform.eulerAngles = -transform.eulerAngles;
                    // GearThree.transform.eulerAngles = transform.eulerAngles;

            if(this.gameObject.name == "Rad Links Außen" || this.gameObject.name == "Rad Rechts Außen")
            {
                GearOne.transform.rotation =  DiscOne.transform.rotation;
                GearTwo.transform.rotation = DiscOne.transform.rotation;
                GearThree.transform.rotation =  DiscOne.transform.rotation;
                Debug.Log("Außen");
                außen = true;
                mitte = false;
                innen = false;
            
            }

            if(this.gameObject.name == "Rad Links Mitte" || this.gameObject.name == "Rad Rechts Mitte")
            {
                GearOne.transform.rotation =  DiscTwo.transform.rotation;
                GearTwo.transform.rotation = DiscTwo.transform.rotation;
                GearThree.transform.rotation =  DiscTwo.transform.rotation;
                Debug.Log("Mitte");
                außen = false;
                mitte = true;
                innen = false;
            }

            if(this.gameObject.name == "Rad Links Innen" || this.gameObject.name == "Rad Rechts Innen")
            {
                GearOne.transform.rotation =  DiscThree.transform.rotation;
                GearTwo.transform.rotation = DiscThree.transform.rotation;
                GearThree.transform.rotation =  DiscThree.transform.rotation;
                Debug.Log("Innnen");
                außen = false;
                mitte = false;
                innen = true;
            }

                }
            }

        }

        if (MouseActive == false) {

            // if (transform.eulerAngles.z < 22.5f && transform.eulerAngles.z >= 0.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 0);
            //     Debug.Log ("kleine drehung");
            // }
            // if (transform.eulerAngles.z >= 22.5f && transform.eulerAngles.z < 45.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 45.0f);
            // }
            // if (transform.eulerAngles.z >= 45.0f && transform.eulerAngles.z < 67.5f) {
            //     lookRotation = Quaternion.Euler (0, 0, 45.0f);
            // }
            // if (transform.eulerAngles.z >= 67.5f && transform.eulerAngles.z < 90.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 90.0f);
            // }
            // if (transform.eulerAngles.z >= 90.0f && transform.eulerAngles.z < 112.5f) {
            //     lookRotation = Quaternion.Euler (0, 0, 90.0f);
            // }
            // if (transform.eulerAngles.z >= 112.5 && transform.eulerAngles.z < 135.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 135.0f);
            // }
            // if (transform.eulerAngles.z >= 135.0f && transform.eulerAngles.z < 157.5f) {
            //     lookRotation = Quaternion.Euler (0, 0, 135.0f);
            // }
            // if (transform.eulerAngles.z >= 157.5f && transform.eulerAngles.z < 180.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 180.0f);
            // }
            // if (transform.eulerAngles.z >= 180.0f && transform.eulerAngles.z < 202.5f) {
            //     lookRotation = Quaternion.Euler (0, 0, 180.0f);
            // }
            // if (transform.eulerAngles.z >= 202.5f && transform.eulerAngles.z < 225.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 225.0f);
            // }
            // if (transform.eulerAngles.z >= 225.0f && transform.eulerAngles.z < 247.5f) {
            //     lookRotation = Quaternion.Euler (0, 0, 225.0f);
            // }
            // if (transform.eulerAngles.z >= 247.5f && transform.eulerAngles.z < 270.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 270.0f);
            // }
            // if (transform.eulerAngles.z >= 270.0f && transform.eulerAngles.z < 292.5f) {
            //     lookRotation = Quaternion.Euler (0, 0, 270.0f);
            // }
            // if (transform.eulerAngles.z >= 292.5f && transform.eulerAngles.z < 315.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 315.0f);
            // }
            // if (transform.eulerAngles.z >= 315.0f && transform.eulerAngles.z < 337.5f) {
            //     lookRotation = Quaternion.Euler (0, 0, 315.0f);
            // }
            // if (transform.eulerAngles.z >= 337.5f && transform.eulerAngles.z < 360.0f) {
            //     lookRotation = Quaternion.Euler (0, 0, 0.0f);
            // }


             if (transform.eulerAngles.z < 45.0f && transform.eulerAngles.z >= 0.0f) {
                lookRotation = Quaternion.Euler (0, 0, 0);
            }

            if (transform.eulerAngles.z >= 45.0f && transform.eulerAngles.z < 90.0f) {
                lookRotation = Quaternion.Euler (0, 0, 90.0f);
            }

            if (transform.eulerAngles.z >= 90.0f && transform.eulerAngles.z < 135.0f) {
                lookRotation = Quaternion.Euler (0, 0, 90.0f);
            }

            if (transform.eulerAngles.z >= 135.0f && transform.eulerAngles.z < 180.0f) {
                lookRotation = Quaternion.Euler (0, 0, 180.0f);
            }

            if (transform.eulerAngles.z >= 180.0f && transform.eulerAngles.z < 225.0f) {
                lookRotation = Quaternion.Euler (0, 0, 180.0f);
            }
            if (transform.eulerAngles.z >= 225.0f && transform.eulerAngles.z < 270.0f) {
                lookRotation = Quaternion.Euler (0, 0, 270.0f);
            }

            if (transform.eulerAngles.z >= 270.0f && transform.eulerAngles.z < 315.0f) {
                lookRotation = Quaternion.Euler (0, 0, 270.0f);
            }
            if (transform.eulerAngles.z >= 315.0f && transform.eulerAngles.z < 360.0f) {
                lookRotation = Quaternion.Euler (0, 0, 0.0f);
            }



            transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);

            if(außen == true)
            {
                GearOne.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                Debug.Log("Außen");
                außen = false;
            }

            if(mitte == true)
            {
                GearOne.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                Debug.Log("Mitte");
                mitte = false;
            }

            if(innen == true)
            {
                GearOne.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
                Debug.Log("Innnen");
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

        Debug.Log (v);

        if (Mathf.Abs (v.x) < Mathf.Abs (v.y)) {
            v.x = 0;
            if (Mathf.Abs (v.y) < Mathf.Abs (v.z))
                v.y = 0f;
            else
                v.z = 0f;
        } else {
            v.y = 0;
            if (Mathf.Abs (v.x) < Mathf.Abs (v.z))
                v.x = 0f;
            else
                v.z = 0f;
        }
        return v;
    }

}