using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitarrenClick : MonoBehaviour
{
    BoxCollider2D GitarrenBox;
    Animator GitarrenAnimation;
    public AudioSource GuitarSound;
    public AudioClip GuitarClip;
    // Start is called before the first frame update
    void Start()
    {
        GitarrenBox = this.gameObject.GetComponent<BoxCollider2D>();
        GitarrenAnimation = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GitarrenAnimation.SetTrigger("ClickGitarre");
        GuitarSound.PlayOneShot(GuitarClip);
    }
}
