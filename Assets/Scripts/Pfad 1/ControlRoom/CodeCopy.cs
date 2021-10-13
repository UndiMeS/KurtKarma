using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeCopy : MonoBehaviour
{

    public GameObject CodeInput;
    public GameObject CodeOutput;

    public string Code;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Code = CodeInput.GetComponent<TMP_InputField>().text.ToString();

        CodeOutput.GetComponent<TMP_Text>().SetText(Code);
    }
}
