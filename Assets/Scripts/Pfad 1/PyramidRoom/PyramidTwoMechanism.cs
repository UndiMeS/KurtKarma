using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidTwoMechanism : MonoBehaviour
{
    private float angle;
    private Camera myCam;

    public GameObject SpinningWheel;
    public GameObject ReverseSpinningWheel;
    public GameObject GearOne;
    public GameObject GearTwo;
    public GameObject GearThree;

    public GameObject DiscOne;
    public GameObject DiscTwo;

    public bool außen;
    public bool innen;

    public float speed = 50.0f;

    private Vector3 screenPos;
    private float angleOffset;
    private float angleOffsetGearOne;
    private float angleOffsetGearTwo;
    private float angleOffsetGearThree;
    public bool MouseActive;
    public GameObject[] gos;

    public GameObject NearestPoint;

    public GameObject SnapRotation;

    public AudioSource RotationSound;
    //public GameObject DiscSnapRotation;

       public float nowRot;
    public float actualRot;
    //public GameObject DiscSnapRotation;

    void Awake ()
    {
        actualRot = this.gameObject.transform.rotation.eulerAngles.z;
        nowRot = actualRot;
    }

    // Start is called before the first frame update
    void Start () {
        myCam = Camera.main;
        if(RotationSound != null)
        RotationSound.Stop();
        
    }

    // Update is called once per frame
    void Update () {


         if(RotationSound != null)
                    {
                        // Quaternion diffRot = oldRot * Quaternion.Inverse(transform.rotation);
                        // if (oldRot != transform.rotation)
                        // RotationSound.Play();

                        // nowRot = (int) this.gameObject.transform.rotation.z;

                        // if( nowRot % 90 == 5)
                        //     RotationSound.Play();

                        actualRot = this.gameObject.transform.rotation.eulerAngles.z;

                        actualRot = (int) actualRot;
                        if(actualRot == 0)
                        nowRot = 0;

                        if (actualRot - nowRot >= 15 || actualRot - nowRot < -15)
                        {
                            RotationSound.Play();

                            nowRot = this.gameObject.transform.rotation.eulerAngles.z;

                            nowRot = (int) actualRot;
                        }
                            

                    }

        if (this.gameObject == SpinningWheel) {

            if (Input.GetMouseButtonDown (0)) {
                if (MouseActive == true) {
                    screenPos = myCam.WorldToScreenPoint (transform.position);
                    Vector3 v3 = Input.mousePosition - screenPos;
                    angleOffset = (Mathf.Atan2 (transform.right.y, transform.right.x) - Mathf.Atan2 (v3.y, v3.x)) * Mathf.Rad2Deg;

                    angleOffsetGearOne = (Mathf.Atan2 (GearOne.transform.right.y, GearOne.transform.right.x) - Mathf.Atan2 (v3.y, v3.x)) * Mathf.Rad2Deg;
                    angleOffsetGearTwo = (Mathf.Atan2 (GearTwo.transform.right.y, GearTwo.transform.right.x) - Mathf.Atan2 (v3.y, v3.x)) * Mathf.Rad2Deg;
                    angleOffsetGearThree = (Mathf.Atan2 (GearThree.transform.right.y, GearThree.transform.right.x) - Mathf.Atan2 (v3.y, v3.x)) * Mathf.Rad2Deg;
                }
            }
            //This fires while the button is pressed down
            if (Input.GetMouseButton (0)) {
                if (MouseActive == true) {
                    Vector3 v3 = Input.mousePosition - screenPos;
                    float angle = Mathf.Atan2 (v3.y, v3.x) * Mathf.Rad2Deg;
                    transform.eulerAngles = new Vector3 (0, 0, angle + angleOffset);


                    GearOne.transform.eulerAngles = new Vector3 (0, 0, angle + angleOffsetGearOne );
                    GearTwo.transform.eulerAngles = new Vector3 (0, 0, angle + angleOffsetGearTwo);
                    GearThree.transform.eulerAngles = new Vector3 (0, 0, angle + angleOffsetGearThree);


                    ReverseSpinningWheel.transform.eulerAngles = -transform.eulerAngles;


                    if(this.gameObject.name == "Rad Rechts Außen" || this.gameObject.name == "Rad Links Mitte")
                    {
                        // GearOne.transform.rotation =  DiscOne.transform.rotation;
                        // GearTwo.transform.rotation = DiscOne.transform.rotation;
                        // GearThree.transform.rotation = DiscOne.transform.rotation;
                        außen = true;
                        innen = false;
                    }

                    if(this.gameObject.name == "Rad Links Innen" || this.gameObject.name == "Rad Rechts Innen")
                    {
                        // GearOne.transform.rotation = DiscTwo.transform.rotation;
                        // GearTwo.transform.rotation = DiscTwo.transform.rotation;
                        // GearThree.transform.rotation = DiscTwo.transform.rotation;
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



            Vector3 alignedForwardGear = NearestWorldAxis (GearOne.transform.forward);
            Vector3 alignedUpGear = NearestWorldAxis (GearOne.transform.up);
            Quaternion lookRotationGear = Quaternion.LookRotation (alignedForwardGear, alignedUpGear);

            transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);

                    // GearOne.transform.eulerAngles = transform.eulerAngles;
                    // GearTwo.transform.eulerAngles = -transform.eulerAngles;



                    if(außen == true)
                    {
                        //Quaternion lookRotationGear = Quaternion.LookRotation (alignedForward, alignedUp);
                        // GearOne.transform.rotation =  DiscOne.transform.rotation;
                        // GearTwo.transform.rotation = DiscOne.transform.rotation;
                        // GearThree.transform.rotation = DiscOne.transform.rotation;


                        GearOne.transform.rotation =  Quaternion.RotateTowards (GearOne.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (GearTwo.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (GearThree.transform.rotation, lookRotationGear, speed * Time.deltaTime);


                    if(GearOne.transform.rotation == lookRotationGear && GearTwo.transform.rotation == lookRotationGear && GearThree.transform.rotation == lookRotationGear)
                    {
                        außen = false;
                    }
                    }

                    if(innen == true)
                    {
                        //Quaternion lookRotationGear = Quaternion.LookRotation (alignedForward, alignedUp);
                        // GearOne.transform.rotation =  DiscTwo.transform.rotation;
                        // GearTwo.transform.rotation = DiscTwo.transform.rotation;
                        // GearThree.transform.rotation = DiscTwo.transform.rotation;

                        GearOne.transform.rotation =  Quaternion.RotateTowards (GearOne.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (GearTwo.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (GearThree.transform.rotation, lookRotationGear, speed * Time.deltaTime);



                        if(GearOne.transform.rotation == lookRotationGear && GearTwo.transform.rotation == lookRotationGear && GearThree.transform.rotation == lookRotationGear)
                    {
                        innen = false;
                    }
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
