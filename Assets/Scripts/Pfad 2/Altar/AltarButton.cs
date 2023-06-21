using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarButton : MonoBehaviour
{
    public GameObject Altar;
    public GameObject EmptyAltar;
    public GameObject AltarHint;
    public GameObject FinalRiddle;
    public GameObject RiddleCubes;
    public SpinAltarCube[] BigCubes;
    public GameObject[] SmallCubes;

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // foreach (Animator CubeSpin in CubeAnimator)
        // {
        //     if(RiddleCubes.activeSelf == false)
        //     {
        //         CubeSpin.enabled = false;
        //     }
        // }

        for(int i = 0; i < BigCubes.Length; i++)
        {
            if(BigCubes[i].Positive == false)
            {
                SmallCubes[i].SetActive(true);
            }
            if(BigCubes[i].Positive == true)
            {
                SmallCubes[i].SetActive(false);
            }
        }
        
    }

    public void ClickOnAltarHint()
    {
        StartCoroutine(ToAltarHintTransition());
    }

    public void ClickOnFinalRiddle()
    {
        

        StartCoroutine(ToFinalRiddleTransition());
    }

    public void BackToAltar()
    {
        StartCoroutine(BackToAltarTransition());
    }

    public IEnumerator ToAltarHintTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        EmptyAltar.SetActive(false);
        AltarHint.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToFinalRiddleTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        EmptyAltar.SetActive(false);
        FinalRiddle.SetActive(true);
        RiddleCubes.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator BackToAltarTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        AltarHint.SetActive(false);
        FinalRiddle.SetActive(false);
        RiddleCubes.SetActive(false);
        EmptyAltar.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}
