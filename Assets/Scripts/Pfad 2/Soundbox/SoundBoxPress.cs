using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBoxPress : MonoBehaviour
{
     public AudioSource Box1;

     public AudioSource[] Audios;

     public SpriteRenderer spriteRenderer;

     public GameObject PauseButton;

    public bool selected;

    public float pitch = 1.0f;

    public Sprite BoxPressed;
    public Sprite BoxNotPressed;

    // Start is called before the first frame update
    void Start()
    {
        Box1 = GetComponent<AudioSource> ();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {



        if(Box1.isPlaying)
        {
            spriteRenderer.sprite = BoxPressed;
        }
        else
        {
            spriteRenderer.sprite = BoxNotPressed;
        }

        if(selected == true)
        {
            if(Audios != null)
        {
            foreach(AudioSource Audio in Audios)
            {
                Audio.Stop();
            }
        }

            Box1.pitch = pitch;
            Box1.Play ();
            selected = false;
        }
        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {

            if(PauseButton != null)
            {
                PauseButton.GetComponent<PauseSound>().selected = false;
            }

            

            pitch = 1.0f;
            selected = true;

        }
    }
}
