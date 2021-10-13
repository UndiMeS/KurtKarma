using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSound : MonoBehaviour
{
    public AudioSource Box1;

     public AudioSource[] Audios;

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



        if(selected == true)
        {
            spriteRenderer.sprite = BoxPressed;
            
        }
        else
        {
            spriteRenderer.sprite = BoxNotPressed;
        }
        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {

        if(Audios != null)
        {
            foreach(AudioSource Audio in Audios)
            {
                Audio.Stop();
            }
        }
            
            Box1.Pause();
            selected = true;
            
            //StartCoroutine(ButtonDown());

        }
    }

    public IEnumerator ButtonDown(){
        spriteRenderer.sprite = BoxPressed;
        yield return new WaitForSeconds(0.5f);
        spriteRenderer.sprite = BoxNotPressed;
    }
}
