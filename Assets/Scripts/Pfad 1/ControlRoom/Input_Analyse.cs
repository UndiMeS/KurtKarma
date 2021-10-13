using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Input_Analyse : MonoBehaviour
{
    public GameObject Input_1;
    public GameObject Input_2;
    public GameObject Input_3;
    public GameObject ComputerScreen_1;
    public GameObject ComputerScreen_1_2;
    public GameObject CorrectButton;
    public GameObject ErrorButton;
    public GameObject ConfirmButton;
    TMP_InputField Inputfield1;


    public float WaitTime = 1.0f;

    public bool CorrectPw = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



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


        
    }

    public void confirm()
    {

        string code1 = Input_1.GetComponent<TMP_InputField>().text;

         if(code1.Length > 2)
        {
             if(code1[0] == '2' && code1[1] == '2' && code1[2] == '4')
        {
             CorrectPw = true;


            }
            else
            {
                CorrectPw = false;
            }
        }

        if(CorrectPw == true)
        {
            ConfirmButton.SetActive(false);
            CorrectButton.SetActive(true);
            StartCoroutine(WaitAndConfirm(WaitTime));
        }
        else if(CorrectPw == false)
        {
            ConfirmButton.SetActive(false);
            ErrorButton.SetActive(true);
            StartCoroutine(ErrorWait(WaitTime));
        }
    }

    IEnumerator WaitAndConfirm(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ComputerScreen_1.SetActive(false);
        ComputerScreen_1_2.SetActive(true);
        Debug.Log("confirm");
    }

    IEnumerator ErrorWait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ConfirmButton.SetActive(true);
        ErrorButton.SetActive(false);
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
