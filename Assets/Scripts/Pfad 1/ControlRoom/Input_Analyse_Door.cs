using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Input_Analyse_Door : MonoBehaviour
{
    public GameObject Input_1;
    public GameObject Input_2;
    public GameObject Input_3;

    TMP_InputField Inputfield1;
    TMP_InputField Inputfield2;
    TMP_InputField Inputfield3;

    public GameObject PyramidRoom;
    public GameObject ControlRoom;
    public GameObject GreenCodeDoor;
    public GameObject RedCodeDoor;
    public GameObject DoorCode;
    public GameObject ControlRoomPic;

    public GameObject ErrorButton;
    public GameObject CorrectButton;

    public GameObject TextObject;

    public float WaitTime = 1.0f;

    public bool CorrectPw = false;

    public bool DoorOpen;

    public GameObject BackButton;
    public Settings SettingScript;

    public Button ConfirmButton;

    public GameObject DevilButton;
    public GameObject HellExitLeft;
    public GameObject HellExitRight;
    public GameObject PartyButton;
    public GameObject Konfetti;

    public bool hell;
    public bool party;


    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;

    //public AudioSource RichtigSound;
    // Start is called before the first frame update
    void Start()
    {
        DoorOpen = false;
        ErrorButton.SetActive(false);
        CorrectButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        string code1 = Input_1.GetComponent<TMP_InputField>().text;
        string code2 = Input_2.GetComponent<TMP_InputField>().text;
        string code3 = Input_3.GetComponent<TMP_InputField>().text;

        TextMeshProUGUI TMPtext = TextObject.GetComponent<TextMeshProUGUI>();


        Inputfield1 = Input_1.GetComponent<TMP_InputField>();
        //Inputfield1.alignment = TextAlignment.Left;

        // if(code1.Length > 2)
        // {
            //TMPtext.SetText("<mspace = 200.0em>" + code1 + "</mspace>");
            if(code1 != null && code2 != null && code3 != null)
            {
                if(code1 == "2" && code2 == "5" && code3 == "1")
                {
                    CorrectPw = true;
                    DoorOpen = false;

                    }
                    else if(code1 == "6" && code2 == "6" && code3 == "6")
                    {
                        hell = true;
                    }
                    else if(code1 == "0" && code2 == "4" && code3 == "2")
                    {
                        party = true;
                    }
                else
                {
                    CorrectPw = false;
                    hell = false;
                    party = false;
                }
            }
            

    }

    public void confirm()
    {
        if(CorrectPw == true)
        {


            CorrectButton.SetActive(true);
            //RichtigSound.Play();
            BackButton.GetComponent<Button>().interactable = false;
            ConfirmButton.interactable = false;
            StartCoroutine(WaitAndConfirm(WaitTime));

            
        }
        else if(CorrectPw == false && hell == false && party == false)
        {

            ErrorButton.SetActive(true);
            StartCoroutine(ErrorWait(WaitTime));
            

        }
        else if(CorrectPw == false && hell == true && party == false)
        {
            DevilButton.SetActive(true);
            hell = false;
            StartCoroutine(HellWait(WaitTime));
        }
        else if(CorrectPw == false && party == true && hell == false)
        {
            PartyButton.SetActive(true);
            party = false;
            StartCoroutine(PartyWait(WaitTime));
        }
    }



    IEnumerator WaitAndConfirm(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        // ComputerScreen_1.SetActive(false);
        // ComputerScreen_1_2.SetActive(true);
        //Debug.Log("confirm");

        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        RedCodeDoor.SetActive(false);
            GreenCodeDoor.SetActive(true);
            DoorCode.SetActive(false);
            ControlRoomPic.SetActive(true);
            //ControlRoom.SetActive(true);

            SettingScript.HintNumber = 4;

            CorrectPw = false;
            DoorOpen = true;


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

        
            //PyramidRoom.SetActive(true);
            
    }

    IEnumerator ErrorWait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ErrorButton.SetActive(false);
        // ConfirmButton.SetActive(true);
        // ErrorButton.SetActive(false);
    }

    IEnumerator HellWait(float waitTime)
    {
        HellExitLeft.SetActive(true);
        HellExitRight.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        //hell = false;
        DevilButton.SetActive(false);
        
    }

    IEnumerator PartyWait(float waitTime)
    {
        Konfetti.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        //party = false;
        PartyButton.SetActive(false);
        
    }


}
