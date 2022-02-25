using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodeCheck : MonoBehaviour
{


    public TMP_InputField[] Code;
    public string[] CodeSolution;
    public GameObject[] RedSquare;
    public GameObject[] GreenSquare;
    public int ClickCount = 0;
    public Button CodeButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
        Code[3].text = Code[1].text;
        Code[1].text = Code[3].text;
            

        
    }

    public void CheckCode(){

        if(ClickCount == 0)
        {
            for(int i = 0; i < Code.Length; i++)
            {
                if(Code[i].text == CodeSolution[i])
                {
                    GreenSquare[i].SetActive(true);
                    RedSquare[i].SetActive(false);
                }
                else
                {
                    RedSquare[i].SetActive(true);
                    GreenSquare[i].SetActive(false);
                }

                Code[i].enabled = false;
            }
            ClickCount += 1;
            CodeButton.interactable = false;

        }
        else
        {
            
        }
        
    }
}
