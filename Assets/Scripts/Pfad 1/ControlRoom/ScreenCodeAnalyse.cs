using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenCodeAnalyse : MonoBehaviour
{

    public TMP_InputField[] Code;

    public GameObject Lock;
    public GameObject OpenLock;

    public GameObject CloseSign;
    public GameObject JunkDoorOpen;

    public GameObject GreenFrame;

    public bool Correct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Code[0].text == "4" && Code[1].text == "3" && Code[2].text == "4" && Code[3].text == "3" && Code[4].text == "5")
        {
            Correct = true;

            //RichtigSound.Play();

            Lock.SetActive(false);
            OpenLock.SetActive(true);
            CloseSign.SetActive(false);
            JunkDoorOpen.SetActive(true);

            GreenFrame.SetActive(true);

            for(int x=0; x <5; x++)
            {
                Code[x].readOnly = true;
            }
        }
        else
        {
            Correct = false;
        }
    }
}
