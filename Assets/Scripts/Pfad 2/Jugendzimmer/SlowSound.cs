using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowSound : MonoBehaviour
{
    public AudioSource Box1;

    public float pitch;

    public GameObject PauseButton;

     public AudioSource[] Audios;

     public SpriteRenderer spriteRenderer;

    public bool selected;

    public Sprite BoxPressed;
    public Sprite BoxNotPressed;

    public GameObject PlayButton;

    // Start is called before the first frame update
    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(!Box1.isPlaying)
        {
            spriteRenderer.sprite = BoxNotPressed;
        }

        Box1 = PlayButton.GetComponent<AudioSource>();

        if(selected == true)
        {
            spriteRenderer.sprite = BoxPressed;
            if(Audios != null)
                    {
                        foreach(AudioSource Audio in Audios)
                        {
                            Audio.Stop();
                        }
                    }
                    Box1.pitch = pitch;
                    if(!Box1.isPlaying){
                        Box1 = PlayButton.GetComponent<AudioSource>();
                        spriteRenderer.sprite = BoxPressed;
                        Box1.pitch = pitch;
                        if(Box1.isPlaying)
                        {
                            spriteRenderer.sprite = BoxPressed;
                            
                        }
                        PlayButton.GetComponent<SoundBoxPress>().selected = true;
                        PlayButton.GetComponent<SoundBoxPress>().pitch = pitch;

                        

                    }
                    
                        
                        
                        

                    if(Box1.isPlaying)
                    {
                        spriteRenderer.sprite = BoxPressed;
                        
                    }

                    
        // if(!Box1.isPlaying)
        // {
        //     spriteRenderer.sprite = BoxNotPressed;
            
            
        // }
        selected = false;
        }



        // if(selected == false)
        // {
        //     spriteRenderer.sprite = BoxNotPressed;
        // }

        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {

            PauseButton.GetComponent<PauseSound>().selected = false;

        
            selected = true;

        }
    }
}
