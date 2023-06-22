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
    private float angleOffsetGearOne;
    private float angleOffsetGearTwo;
    private float angleOffsetGearThree;
    public bool MouseActive;

    public float speed = 50.0f;

    public Vector3 lookAtTarget;
    public Vector3 aimingDir;
    public float angle;
    public Vector3 newDir;
    static Quaternion lookRotation;
    static Quaternion lookRotationGear;

    public AudioSource RotationSound;
    public Quaternion oldRot;

    public Quaternion soundRot;

    public AudioSource LockAudioSource;
    public float nowRot;
    public float actualRot;

    public bool UnMute;

    void Awake ()
    {
        actualRot = this.gameObject.transform.rotation.eulerAngles.z;
        nowRot = actualRot;
    }

    // Start is called before the first frame update
    void Start () {
        myCam = Camera.main;
        

        Vector3 newDir = Quaternion.Euler (45.0f, 45.0f, 45.0f) * transform.up;

        LockAudioSource = GearTwo.GetComponent<AudioSource>();


    }

    void FixedUpdate()
    {
       
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

                        actualRot = (int) actualRot;
                        if(actualRot == 0)
                        nowRot = 0;

                        if (actualRot - nowRot >= 15 || actualRot - nowRot < -15)
                        {

                            if(UnMute == true)
                            RotationSound.Play();

                            nowRot = this.gameObject.transform.rotation.eulerAngles.z;

                            nowRot = (int) actualRot;

                            UnMute = true;
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

                    // if(RotationSound != null)
                    // {
                    //     // Quaternion diffRot = oldRot * Quaternion.Inverse(transform.rotation);
                    //     // if (oldRot != transform.rotation)
                    //     // RotationSound.Play();

                    //     int nowRot = (int) this.transform.rotation.z;

                    //     if( nowRot % 90 == 0)
                    //         RotationSound.Play();


                    // else
                    //     RotationSound.Stop();
                    // oldRot = transform.rotation;
                    // }
                    


                    // GearOne.transform.eulerAngles = transform.eulerAngles;
                    // GearTwo.transform.eulerAngles = -transform.eulerAngles;
                    // GearThree.transform.eulerAngles = transform.eulerAngles;

            if(this.gameObject.name == "Rad Links Außen" || this.gameObject.name == "Rad Rechts Außen")
            {

                //GearOne.transform.rotation = Quaternion.AngleAxis(angle, transform.up) * GearOne.transform.rotation;




                // GearOne.transform.rotation =  DiscOne.transform.rotation;
                // GearTwo.transform.rotation = DiscOne.transform.rotation;
                // GearThree.transform.rotation =  DiscOne.transform.rotation;
                Debug.Log("Außen");
                außen = true;
                mitte = false;
                innen = false;

            
            }

            if(this.gameObject.name == "Rad Links Mitte" || this.gameObject.name == "Rad Rechts Mitte")
            {
                

                // Vector3 rot = GearOne.transform.rotation.eulerAngles;
                // rot = new Vector3(rot.x,rot.y,DiscTwo.transform.rotation.z);
                // GearOne.transform.rotation = Quaternion.Euler(rot);

                //GearOne.transform.rotation =  Quaternion.Euler(0, 0, GearOne.transform.rotation.z + DiscTwo.transform.rotation.z);


                // GearOne.transform.rotation =  DiscTwo.transform.rotation;
                // GearTwo.transform.rotation = DiscTwo.transform.rotation;
                // GearThree.transform.rotation =  DiscTwo.transform.rotation;
                Debug.Log("Mitte");
                außen = false;
                mitte = true;
                innen = false;
            }

            if(this.gameObject.name == "Rad Links Innen" || this.gameObject.name == "Rad Rechts Innen")
            {
                // GearOne.transform.rotation =  DiscThree.transform.rotation;
                // GearTwo.transform.rotation = DiscThree.transform.rotation;
                // GearThree.transform.rotation =  DiscThree.transform.rotation;
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
                lookRotation = Quaternion.Euler (0, 0, +90.0f);
            }

            if (transform.eulerAngles.z >= 90.0f && transform.eulerAngles.z < 135.0f) {
                lookRotation = Quaternion.Euler (0, 0, +90.0f);
            }

            if (transform.eulerAngles.z >= 135.0f && transform.eulerAngles.z < 180.0f) {
                lookRotation = Quaternion.Euler (0, 0, +180.0f);
            }

            if (transform.eulerAngles.z >= 180.0f && transform.eulerAngles.z < 225.0f) {
                lookRotation = Quaternion.Euler (0, 0, +180.0f);
            }
            if (transform.eulerAngles.z >= 225.0f && transform.eulerAngles.z < 270.0f) {
                lookRotation = Quaternion.Euler (0, 0, +270.0f);
            }

            if (transform.eulerAngles.z >= 270.0f && transform.eulerAngles.z < 315.0f) {
                lookRotation = Quaternion.Euler (0, 0, +270.0f);
            }
            if (transform.eulerAngles.z >= 315.0f && transform.eulerAngles.z < 360.0f) {
                lookRotation = Quaternion.Euler (0, 0, 0.0f);
            }










            if (GearOne.transform.eulerAngles.z < 45.0f && GearOne.transform.eulerAngles.z >= 0.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, 0);
                
            }

            if (GearOne.transform.eulerAngles.z >= 45.0f && GearOne.transform.eulerAngles.z < 90.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, +90.0f);
            }

            if (GearOne.transform.eulerAngles.z >= 90.0f && GearOne.transform.eulerAngles.z < 135.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, +90.0f);
            }

            if (GearOne.transform.eulerAngles.z >= 135.0f && GearOne.transform.eulerAngles.z < 180.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, +180.0f);
            }

            if (GearOne.transform.eulerAngles.z >= 180.0f && GearOne.transform.eulerAngles.z < 225.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, +180.0f);
            }
            if (GearOne.transform.eulerAngles.z >= 225.0f && GearOne.transform.eulerAngles.z < 270.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, +270.0f);
            }

            if (GearOne.transform.eulerAngles.z >= 270.0f && GearOne.transform.eulerAngles.z < 315.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, +270.0f);
            }
            if (GearOne.transform.eulerAngles.z >= 315.0f && GearOne.transform.eulerAngles.z < 360.0f) {
                lookRotationGear = Quaternion.Euler (0, 0, 0.0f);
            }



            transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);

            // GearOne.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
            // GearTwo.transform.rotation = Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);
            // GearThree.transform.rotation =  Quaternion.RotateTowards (transform.rotation, lookRotation, speed * Time.deltaTime);

            if(außen == true)
            {
                GearOne.transform.rotation =  Quaternion.RotateTowards (GearOne.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (GearTwo.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (GearThree.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                Debug.Log("Außen");
                //außen = false;
               

                if(GearOne.transform.rotation == lookRotationGear && GearTwo.transform.rotation == lookRotationGear && GearThree.transform.rotation == lookRotationGear)
                    {
                        außen = false;
                    }
            }


            if(mitte == true)
            {
                GearOne.transform.rotation =  Quaternion.RotateTowards (GearOne.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (GearTwo.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (GearThree.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                Debug.Log("Mitte");
                //mitte = false;
                
                if(GearOne.transform.rotation == lookRotationGear && GearTwo.transform.rotation == lookRotationGear && GearThree.transform.rotation == lookRotationGear)
                    {
                        mitte = false;
                    }
            }

            if(innen == true)
            {
                GearOne.transform.rotation =  Quaternion.RotateTowards (GearOne.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearTwo.transform.rotation = Quaternion.RotateTowards (GearTwo.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                GearThree.transform.rotation =  Quaternion.RotateTowards (GearThree.transform.rotation, lookRotationGear, speed * Time.deltaTime);
                Debug.Log("Innnen");
                //innen = false;
                
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

    // private static Vector3 NearestWorldAxis (Vector3 v) {

    //     Debug.Log (v);

    //     if (Mathf.Abs (v.x) < Mathf.Abs (v.y)) {
    //         v.x = 0;
    //         if (Mathf.Abs (v.y) < Mathf.Abs (v.z))
    //             v.y = 0f;
    //         else
    //             v.z = 0f;
    //     } else {
    //         v.y = 0;
    //         if (Mathf.Abs (v.x) < Mathf.Abs (v.z))
    //             v.x = 0f;
    //         else
    //             v.z = 0f;
    //     }
    //     return v;
    // }

}