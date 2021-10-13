using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSound : MonoBehaviour
{
    public AudioSource Box1;

     public AudioSource[] Audios;
     
     public GameObject PauseButton;

     public SpriteRenderer spriteRenderer;

    public bool selected;

    public Sprite BoxPressed;
    public Sprite BoxNotPressed;

    // Start is called before the first frame update
    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {



        if(Box1.isPlaying)
        {
            //spriteRenderer.sprite = BoxPressed;
            
        }
        else
        {
            //spriteRenderer.sprite = BoxNotPressed;
        }
        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {

            PauseButton.GetComponent<PauseSound>().selected = false;

        if(Audios != null)
        {
            foreach(AudioSource Audio in Audios)
            {
                Audio.Stop();
            }
        }
            
            Box1.Stop();
            StartCoroutine(ButtonDown());
            selected = true;

        }
    }
    public IEnumerator ButtonDown(){
        spriteRenderer.sprite = BoxPressed;
        yield return new WaitForSeconds(0.5f);
        spriteRenderer.sprite = BoxNotPressed;
    }
}
