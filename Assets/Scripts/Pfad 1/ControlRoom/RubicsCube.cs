using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubicsCube : MonoBehaviour
{


    public int ClickCount;

    public SpriteRenderer Cube;

    public Sprite WürfelSpriteTwo;
    public Sprite WürfelSpriteThree;
    public Sprite WürfelSpriteFour;

    public Sprite TasseVornGrün;
    public Sprite TasseHintenGrün;

    public SpriteRenderer TasseVorn;
    public SpriteRenderer TasseHinten;

    public GameObject TassenZettel;
    public GameObject TassenButton;
    public Animator ZettelAnimation;
    AudioSource RubikCubeSound;

    // Start is called before the first frame update
    void Start()
    {
        ZettelAnimation.enabled = false;
        Cube = this.gameObject.GetComponent<SpriteRenderer>();
        RubikCubeSound = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ClickCount == 1)
        {
            
            Cube.sprite = WürfelSpriteTwo;
            //RubikCubeSound.Play();
        }
        else if(ClickCount == 2)
        {
            Cube.sprite = WürfelSpriteThree;
            //RubikCubeSound.Play();
        }
        else if(ClickCount == 3)
        {
            Cube.sprite = WürfelSpriteFour;
            //RubikCubeSound.Play();

            TasseHinten.sprite = TasseHintenGrün;
            TasseVorn.sprite = TasseVornGrün;


            //TassenZettel.SetActive(true);
            if(ZettelAnimation != null)
            {
                ZettelAnimation.enabled = true;
            ZettelAnimation.Play("TassenZettel");
            //ZettelAnimation.SetTrigger("ZettelBool");
            Destroy (ZettelAnimation, ZettelAnimation.GetCurrentAnimatorStateInfo(0).length); 
            }
            
            TassenButton.SetActive(true);
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
            ClickCount++;

            if(ClickCount < 4)
            {
                RubikCubeSound.Play();
            }
            
        }
    }
}
