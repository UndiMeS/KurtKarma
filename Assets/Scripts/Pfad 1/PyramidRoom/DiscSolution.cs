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

    public float DiscThreeOneAngle;
    public float DiscThreeTwoAngle;
    public float DiscThreeThreeAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        DiscThreeOneAngle = DiscThree[0].transform.eulerAngles.z;
        DiscThreeTwoAngle = DiscThree[1].transform.eulerAngles.z;
        DiscThreeThreeAngle = DiscThree[2].transform.eulerAngles.z;



        if(DiscOne[0].transform.eulerAngles.z == DiscOne[1].transform.eulerAngles.z )
        {
            DiscOneSolution = true;
        }
        else
        {
            DiscOneSolution = false;
        }

                if(DiscTwo[0].transform.eulerAngles.z == DiscTwo[1].transform.eulerAngles.z)
        {
            DiscTwoSolution = true;
        }
        else
        {
            DiscTwoSolution = false;
        }

                if(DiscThree[0].transform.eulerAngles.z == DiscThree[1].transform.eulerAngles.z && DiscThree[2].transform.eulerAngles.z == DiscThree[1].transform.eulerAngles.z)
        {
            DiscThreeSolution = true;
        }
        else
        {
            DiscThreeSolution = false;
        }

                if(DiscFour[0].transform.eulerAngles.z == DiscFour[1].transform.eulerAngles.z && DiscFour[2].transform.eulerAngles.z == DiscFour[1].transform.eulerAngles.z)
        {
            DiscFourSolution = true;
        }
        else
        {
            DiscFourSolution = false;
        }
    }
}
