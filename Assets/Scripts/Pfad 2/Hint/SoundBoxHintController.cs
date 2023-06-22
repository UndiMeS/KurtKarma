using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoundBoxHintController : MonoBehaviour
{

    public TMP_InputField[] SoundBoxNumbers;
    public Image[] InputBackgrounds;
    public string[] SoundBoxSolutions = {"10","+","6","x","=","1","+","8","x"};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckSoundBoxHint()
    {


        for(int i = 0; i < SoundBoxNumbers.Length; i++)
        {
            if(SoundBoxNumbers[i].text.ToLower()  == SoundBoxSolutions[i])
            {
                InputBackgrounds[i].color = new Color32(112,173,71,255);
                SoundBoxNumbers[i].interactable = false;
            }
            else
            {
                InputBackgrounds[i].color = new Color32(255,126,121,255);
            }
        }
        
    }

}
