using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSliderSound : MonoBehaviour
{
    public AudioSource FXSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseUp()
    {
        FXSound.Play();
    }
}
