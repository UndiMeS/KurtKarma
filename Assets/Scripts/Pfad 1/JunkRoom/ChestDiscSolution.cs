using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestDiscSolution : MonoBehaviour
{

    public DiscSolution Solution;
    public GameObject[] GreenPyramids;
    public Sprite SolutionBackground;
    public Sprite ChestBackground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Solution.DiscOneSolution == true)
        {
            GreenPyramids[1].SetActive(true);
        }
        else
        {
            GreenPyramids[1].SetActive(false);
        }

        if(Solution.DiscTwoSolution == true)
        {
            GreenPyramids[2].SetActive(true);
        }
        else
        {
            GreenPyramids[2].SetActive(false);
        }

        if(Solution.DiscThreeSolution == true)
        {
            GreenPyramids[0].SetActive(true);
        }
        else
        {
            GreenPyramids[0].SetActive(false);
        }

        if(Solution.DiscFourSolution == true)
        {
            GreenPyramids[3].SetActive(true);
        }
        else
        {
            GreenPyramids[3].SetActive(false);
        }

        if(Solution.DiscOneSolution == true && Solution.DiscTwoSolution == true && Solution.DiscThreeSolution == true && Solution.DiscFourSolution == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SolutionBackground;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ChestBackground;
        }
    }
}
