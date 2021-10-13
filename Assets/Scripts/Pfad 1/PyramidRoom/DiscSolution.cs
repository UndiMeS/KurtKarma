using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscSolution : MonoBehaviour
{

    public GameObject[] DiscOne;
    public GameObject[] DiscTwo;
    public GameObject[] DiscThree;
    public GameObject[] DiscFour;
    public bool DiscOneSolution;
    public bool DiscTwoSolution;
    public bool DiscThreeSolution;
    public bool DiscFourSolution;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DiscOne[0].transform.rotation.z == DiscOne[1].transform.rotation.z )
        {
            DiscOneSolution = true;
        }
        else
        {
            DiscOneSolution = false;
        }

                if(DiscTwo[0].transform.rotation.z == DiscTwo[1].transform.rotation.z)
        {
            DiscTwoSolution = true;
        }
        else
        {
            DiscTwoSolution = false;
        }

                if(DiscThree[0].transform.rotation.z == DiscThree[1].transform.rotation.z && DiscThree[2].transform.rotation.z == DiscThree[1].transform.rotation.z)
        {
            DiscThreeSolution = true;
        }
        else
        {
            DiscThreeSolution = false;
        }

                if(DiscFour[0].transform.rotation.z == DiscFour[1].transform.rotation.z && DiscFour[2].transform.rotation.z == DiscFour[1].transform.rotation.z)
        {
            DiscFourSolution = true;
        }
        else
        {
            DiscFourSolution = false;
        }
    }
}
