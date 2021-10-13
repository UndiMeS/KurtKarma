using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class MayaZahlenUmrechner : MonoBehaviour
{

    public GameObject MayaAreaOne;
    public GameObject MayaAreaTwo;

    public GameObject SolutionOne;
    public GameObject SolutionTwo;
    public GameObject SolutionThree;


    public int AreaOnePoint;
    public int AreaTwoPoint;
    public int AreaOneLine;
    public int AreaTwoLine;
    public int AreaOneBread;
    public int AreaTwoBread;

    public int DisplayOne;
    public int DisplayTwo;
    public int DisplayThree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AreaOnePoint = MayaAreaOne.GetComponent<SecretSolutionDetection>().PunktCount;
        AreaTwoPoint = MayaAreaTwo.GetComponent<SecretSolutionDetection>().PunktCount;

        AreaOneLine = MayaAreaOne.GetComponent<SecretSolutionDetection>().StrichCount;
        AreaTwoLine = MayaAreaTwo.GetComponent<SecretSolutionDetection>().StrichCount;

        AreaOneBread = 0;
        AreaTwoBread = 0;

        if(MayaAreaOne.GetComponent<SecretSolutionDetection>().PunktSelected == false &&
            MayaAreaOne.GetComponent<SecretSolutionDetection>().StrichSelected == false &&
            MayaAreaTwo.GetComponent<SecretSolutionDetection>().PunktSelected == false &&
            MayaAreaTwo.GetComponent<SecretSolutionDetection>().StrichSelected == false)
            {
                DisplayOne = AreaOnePoint + AreaOneBread + (AreaOneLine * 5);
                DisplayTwo = (AreaTwoPoint + AreaTwoBread + (AreaTwoLine * 5)) * 20;
                DisplayThree = DisplayOne + DisplayTwo;
            }



        SolutionOne.GetComponent<TMP_Text>().text = DisplayOne.ToString();
        SolutionTwo.GetComponent<TMP_Text>().text = DisplayTwo.ToString();
        SolutionThree.GetComponent<TMP_Text>().text = DisplayThree.ToString();
    }
}
