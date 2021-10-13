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
            else
            {
                CorrectPw = false;
            }
            }
            
        //}

        
            //confirm();
        


        

        // if(code1.Length == 1)
        // {
        //     Inputfield2.Select();
        //     Inputfield2.ActivateInputField();
        // }

        // if(code2.Length == 1)
        // {
        //     Inputfield3.Select();
        //     Inputfield3.ActivateInputField();
        // }

        // if(code3.Length == 1)
        // {
        //     Inputfield1.Select();
        //     Inputfield1.ActivateInputField();
        // }


            // if(code1 == "2" && code2 == "5" && code3 == "1" && DoorOpen == false)
            // {
            //     CorrectPw = true;
            //     DoorOpen = false;

            // }
            // else
            // {
            //     CorrectPw = false;
            // }
            // //confirm();

        
    }

    public void confirm()
    {
        if(CorrectPw == true)
        {


            CorrectButton.SetActive(true);
            //RichtigSound.Play();
            BackButton.GetComponent<Button>().interactable = false;
            StartCoroutine(WaitAndConfirm(WaitTime));

            
        }
        else if(CorrectPw == false)
        {

            ErrorButton.SetActive(true);
            StartCoroutine(ErrorWait(WaitTime));
            

        }
    }

    // IEnumerator WaitAndConfirm(float waitTime)
    // {
    //     yield return new WaitForSeconds(waitTime);
    //     ComputerScreen_1.SetActive(false);
    //     ComputerScreen_1_2.SetActive(true);
    //     Debug.Log("confirm");
    // }

    // IEnumerator ErrorWait(float waitTime)
    // {
    //     yield return new WaitForSeconds(waitTime);
    //     ConfirmButton.SetActive(true);
    //     ErrorButton.SetActive(false);
    // }


    IEnumerator WaitAndConfirm(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        // ComputerScreen_1.SetActive(false);
        // ComputerScreen_1_2.SetActive(true);
        //Debug.Log("confirm");

        
            //PyramidRoom.SetActive(true);
            RedCodeDoor.SetActive(false);
            GreenCodeDoor.SetActive(true);
            DoorCode.SetActive(false);
            ControlRoomPic.SetActive(true);
            //ControlRoom.SetActive(true);

            CorrectPw = false;
            DoorOpen = true;
    }

    IEnumerator ErrorWait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ErrorButton.SetActive(false);
        // ConfirmButton.SetActive(true);
        // ErrorButton.SetActive(false);
    }

    // public void FieldOneEnd()
    // {

    //     string code1 = Input_1.GetComponent<TMP_InputField>().text;
        
    //     if(code1.Length == 1)
    //     {
    //     Inputfield2.Select();
    //     Inputfield2.ActivateInputField();
    //     }

    // }

    // public void FieldTwoEnd()
    // {
    //     string code2 = Input_2.GetComponent<TMP_InputField>().text;
    //     if(code2.Length == 1)
    //     {
    //     Inputfield3.Select();
    //     Inputfield3.ActivateInputField();
    //     }

    // }
}
