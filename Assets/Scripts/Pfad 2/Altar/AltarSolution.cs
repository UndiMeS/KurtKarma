using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;





public class AltarSolution : MonoBehaviour
{

    public AnimationCurve animationCurve;
    public AnimationCurve finalAnimationCurve;
    public float animationTime;

    public SpinAltarCube[] SolutionCubesOne;
    public SpinAltarCube[] SolutionCubesTwo;
    public GameObject Altar;
    public GameObject Inventar;
    public GameObject RiddleCubes;
    public GameObject Outro;
    public VideoPlayer OutroVideoPlayer;
    public GameObject RiddleButton;
    public Sprite ButtonTrue;
    public Sprite ButtonFalse;
    public Sprite ButtonNeutral;
    public bool Correct;
    public bool Win;

    public VideoHandler VideoScript;


    private bool AllCubesFalseOne(){
        for(int i = 0; i < SolutionCubesOne.Length; i++)
        {
            if(SolutionCubesOne[i].Positive == true)
            {
                return false;
            }
        }
        return true;
    }

    private bool AllCubesTrueOne(){
        for(int i = 0; i < SolutionCubesOne.Length; i++)
        {
            if(SolutionCubesOne[i].Positive == false)
            {
                return false;
            }
        }
        return true;
    }
            

    private bool AllCubesFalseTwo(){
        for(int i = 0; i < SolutionCubesTwo.Length; ++i)
        {
            if(SolutionCubesTwo[i].Positive == true)
            {
                return false;
            }
        }
        return true;
    }

    private bool AllCubesTrueTwo(){
        for(int i = 0; i < SolutionCubesTwo.Length; ++i)
        {
            if(SolutionCubesTwo[i].Positive == false)
            {
                return false;
            }
        }
        return true;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AltarRiddleButton()
    {
        if(AllCubesFalseOne() == true && AllCubesTrueTwo() == true || AllCubesTrueOne() == true && AllCubesFalseTwo() == true)
        {
            Correct = true;
            RiddleButton.GetComponent<Image>().sprite = ButtonTrue;

                RiddleButton.GetComponent<Button>().interactable = false;
                Invoke("FinalButtonHighlight",8.5f);
                
            

            


        }
        else
        {
            RiddleButton.GetComponent<Image>().sprite = ButtonFalse;
            RiddleButton.GetComponent<Button>().interactable = false;

            Invoke("FalseRiddleClick", 2.0f);
        }

    }

    void FalseRiddleClick()
    {
        RiddleButton.GetComponent<Image>().sprite = ButtonNeutral;
        RiddleButton.GetComponent<Button>().interactable = true;
    }

    void FinalButtonHighlight()
    {
        

        Image r = RiddleButton.GetComponent<Image>();
     LeanTween.value(gameObject, 0, 1, 1).setLoopPingPong().setOnUpdate((float val) =>
     {
         Color c = r.color;
         c.a = val;
         r.color = c;
     });

        RiddleButton.GetComponent<Button>().interactable = true;
        Win = true;
        VideoScript.OutroButton();
    }

    

    //  void FadeStart()
    //  {
    //      LeanTween.alpha (RiddleButton.rectTransForm, 0f, 1f).setEase (LeanTweenType.linear).setOnComplete( FadeFinished );
    //  }
    //  void FadeFinished()
    //  {
    //      LeanTween.alpha (RiddleButton.rectTransForm, 1f, 1f).setEase (LeanTweenType.linear).setOnComplete( FadeStart );
    //  }
}
