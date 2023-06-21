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

        if(NumberOfSelections >4)
            {
                foreach(GameObject classobject in ClassObjects)
                {
                    classobject.GetComponent<OnClickOutline>().selected = false;

                    classobject.GetComponent<OnClickOutline>().M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));
                    classobject.GetComponent<OnClickOutline>().SelectionCount = 0;
                }

                StartCoroutine(FalseSelections());
                
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
        yield return new WaitForSeconds(1.0f);
        RedFrame.SetActive(false);
    }

    IEnumerator RightSelections()
    {
        ClassRoomButtons classroombuttons = Room_4_Handler.GetComponent<ClassRoomButtons>();
        GreenFrame.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        GreenFrame.SetActive(false);
        classroombuttons.OpenCloset();
    }


}
