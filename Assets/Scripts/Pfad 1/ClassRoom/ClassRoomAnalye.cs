using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassRoomAnalye : MonoBehaviour
{


    public GameObject[] ClassObjects;
    public bool IsSelected;
    public int SelectionCount;
    public int NumberOfSelections;
    public GameObject Uhr;
    public GameObject Kreide;
    public GameObject Schwamm;
    public GameObject Mülleimer;

    public GameObject RedFrame;
    public GameObject GreenFrame;

    public GameObject Room_4_Handler;

    public AudioSource ClosetSound;

    public GameObject PyramidDoorButton;
    public GameObject PortalButton;
    public Settings SettingScript;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ClassRoomButtons classroombuttons = Room_4_Handler.GetComponent<ClassRoomButtons>();

        NumberOfSelections = 0;

        ClassObjects = GameObject.FindGameObjectsWithTag("ClassRoomSelection");

        foreach(GameObject classobject in ClassObjects)
        {
            IsSelected = classobject.GetComponent<OnClickOutline>().selected;
            SelectionCount = classobject.GetComponent<OnClickOutline>().SelectionCount;

            if(IsSelected == true)
            {
               NumberOfSelections = NumberOfSelections + SelectionCount;

            }

            
        }

        if(NumberOfSelections == 4)
            {
                if( Uhr.GetComponent<OnClickOutline>().selected == true &&
                    Kreide.GetComponent<OnClickOutline>().selected == true &&
                    Schwamm.GetComponent<OnClickOutline>().selected == true &&
                    Mülleimer.GetComponent<OnClickOutline>().selected == true)
                    {
                        

                        StartCoroutine(RightSelections());

                        foreach(GameObject classobject in ClassObjects)
                        {
                            classobject.GetComponent<OnClickOutline>().selected = false;

                            classobject.GetComponent<OnClickOutline>().M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));
                            classobject.GetComponent<OnClickOutline>().SelectionCount = 0;


                            classobject.GetComponent<OnClickOutline>().enabled = false;
                        }

                    }
                    else
                    {
                                        foreach(GameObject classobject in ClassObjects)
                {
                    classobject.GetComponent<OnClickOutline>().selected = false;

                    classobject.GetComponent<OnClickOutline>().M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));
                    classobject.GetComponent<OnClickOutline>().SelectionCount = 0;
                }

                StartCoroutine(FalseSelections());
                    }

                
            }

            if( Uhr.GetComponent<OnClickOutline>().selected == true &&
                Kreide.GetComponent<OnClickOutline>().selected == true &&
                Schwamm.GetComponent<OnClickOutline>().selected == true &&
                Mülleimer.GetComponent<OnClickOutline>().selected == true)
                {
                    

                    StartCoroutine(RightSelections());

                    foreach(GameObject classobject in ClassObjects)
                    {
                        classobject.GetComponent<OnClickOutline>().selected = false;

                        classobject.GetComponent<OnClickOutline>().M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));
                        classobject.GetComponent<OnClickOutline>().SelectionCount = 0;


                        classobject.GetComponent<OnClickOutline>().enabled = false;
                    }

                }


        
    }


    IEnumerator FalseSelections()
    {
        RedFrame.SetActive(true);
        PyramidDoorButton.SetActive(false);
        PortalButton.SetActive(false);


        foreach(GameObject classobject in ClassObjects)
        {
            classobject.GetComponent<OnClickOutline>().enabled = false;
        }



        yield return new WaitForSeconds(2.0f);
        PyramidDoorButton.SetActive(true);
        PortalButton.SetActive(true);
        RedFrame.SetActive(false);

        foreach(GameObject classobject in ClassObjects)
        {
            classobject.GetComponent<OnClickOutline>().enabled = true;
        }
    }

    IEnumerator RightSelections()
    {
        ClassRoomButtons classroombuttons = Room_4_Handler.GetComponent<ClassRoomButtons>();
        GreenFrame.SetActive(true);
        PyramidDoorButton.SetActive(false);
        PortalButton.SetActive(false);

        foreach(GameObject classobject in ClassObjects)
        {
            classobject.GetComponent<OnClickOutline>().enabled = false;
        }


        yield return new WaitForSeconds(1.0f);
        ClosetSound.Play();
        SettingScript.HintNumber = 5;
        yield return new WaitForSeconds(1.0f);
        PyramidDoorButton.SetActive(true);
        PortalButton.SetActive(true);
        GreenFrame.SetActive(false);
        classroombuttons.OpenCloset();
    }


}
