using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CircuitCodeAnalyse : MonoBehaviour
{
    public SpriteRenderer FinalCircuitBackground;
    public Sprite FinalCircuitGreen;
    public TMP_InputField Code1;
    public TMP_InputField Code2;
    public TMP_InputField Code3;
    public GameObject GreenFrame;

    public GameObject WeiterButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Code1.text == "13" && Code2.text == "11" && Code3.text == "26")
        {
            Code1.interactable = false;
            Code2.interactable = false;
            Code3.interactable = false;

            GreenFrame.SetActive(true);
            
            FinalCircuitBackground.sprite = FinalCircuitGreen;
            WeiterButton.SetActive(true);
        }
    }
}
