using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedButtonHandler : MonoBehaviour
{

    public GameObject Wall;
    private Animator WallAnimator;

    public GameObject Screens;
    private Animator ScreenAnimator;

    public GameObject GameScreen;
    private Animator GameScreenAnimator;

    public GameObject RedButton;
    public Sprite RedButtonPressed;

    public GameObject FinalScreenButton;

    public bool selected;

    public GameObject WhiteButton;

    public AudioSource WallSound;
    public Button cupButton;

    private void Awake(){
        WallAnimator = Wall.GetComponent<Animator>();
        ScreenAnimator = Screens.GetComponent<Animator>();
        GameScreenAnimator = GameScreen.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp (0)){
            selected = false;
        }


        if(selected == true)
        {

                this.GetComponent<SpriteRenderer>().sprite = RedButtonPressed;
                cupButton.interactable = false;

                WallAnimator.SetBool("OpenWall", true);
                ScreenAnimator.SetBool("ScreenShift", true);
                GameScreenAnimator.SetBool("shake", true);

                FinalScreenButton.SetActive(true);
                WhiteButton.SetActive(false);

                WallSound.Play();

                StartCoroutine(ButtonChange());

                //RedButton.SetActive(true);

                //this.gameObject.SetActive(false);
            
            
        }
        else if(selected == false)
        {

                //this.GetComponent<SpriteRenderer>().sprite = NotPressed;
            
            
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            selected = true;
            //this.gameObject.GetComponent<SpriteRenderer>().sprite = RedButtonPressed;
        }
    }

    IEnumerator ButtonChange()
    {
        yield return new WaitForSeconds(0.5f);
        RedButton.SetActive(true);

        this.gameObject.SetActive(false);
    }
}
