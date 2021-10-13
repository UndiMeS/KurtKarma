using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class FinalSolution : MonoBehaviour
{

    public GameObject InputFieldUp;
    public GameObject InputFieldDown;
    public GameObject NirvanaEmpty;
    public GameObject NirvanaEmptyBlack;
    public GameObject PasswordScreen;

    public bool selected;

    public Sprite NotPressed;
    public Sprite Pressed;

    public GameObject Wrong;

    //public  Default;

    public bool Correct;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Correct == true)
        {
            NirvanaEmpty.SetActive(false);
            PasswordScreen.SetActive(false);
            NirvanaEmptyBlack.SetActive(true);
        }   

        if(Input.GetMouseButtonUp (0)){
            selected = false;
        }


        if(selected == true)
        {

            if(Correct == false)
            {
                StartCoroutine(FalseAnswer());
            }
            else {
                this.GetComponent<SpriteRenderer>().sprite = Pressed;
            }

                
            
            
        }
        else if(selected == false)
        {

                this.GetComponent<SpriteRenderer>().sprite = NotPressed;
            
            
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown (0)) {
            selected = true;
            if(InputFieldUp.GetComponent<TMP_InputField>().text == "9" && InputFieldDown.GetComponent<TMP_InputField>().text == "2")
            {
                Correct = true;
            }
            else
            {
                Correct = false;
                
                
            }
        }
    }

    public IEnumerator FalseAnswer()
    {
        selected = false;
        this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        Wrong.SetActive(true);
        yield return new WaitForSeconds(2);
        this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        Wrong.SetActive(false);
        
    }
}
