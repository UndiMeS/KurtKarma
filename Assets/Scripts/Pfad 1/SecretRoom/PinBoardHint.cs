using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBoardHint : MonoBehaviour
{
    public GameObject SolutionOne;
    public GameObject SolutionTwo;
    public GameObject HintFinger;
    public bool ShowHint;
    public bool WasShown;
    
    // Start is called before the first frame update
    void Start()
    {
        HintFinger.SetActive(false);
        WasShown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(SolutionOne.GetComponent<SecretSolutionDetection>().Hint == true && SolutionTwo.GetComponent<SecretSolutionDetection>().Hint == true && WasShown == false)
        {
            StartCoroutine(HintCoroutine());
            WasShown = true;

        }
    }

    IEnumerator HintCoroutine()
    {
        yield return new WaitForSeconds(20);

         if(SolutionOne.GetComponent<SecretSolutionDetection>().Hint == true && SolutionTwo.GetComponent<SecretSolutionDetection>().Hint == true)
        {
            HintFinger.SetActive(true);
        }

        
        yield return new WaitForSeconds(5);
        HintFinger.SetActive(false);

    }
}
