using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretRoomSolutionAnalyse : MonoBehaviour
{

    public GameObject PyramideClose;
    public GameObject PyramideOpen;

    public bool SolutionOneRight;
    public bool SolutionTwoRight;
    //public bool SolutionThreeRight;

    public MayaCodePinBoard PointCode;
    public MayaCodePinBoard LineCode;
    public MayaCodePinBoard BreadCode;

    public MayaSymbolDrop PointDrop;
    public MayaSymbolDrop LineDrop;
    public MayaSymbolDrop BreadDrop;

    public GameObject Pinboard;
    public GameObject PinboardSolution;
    public GameObject PinboardSolutionSmall;

    public GameObject PinBoardButton;
    public GameObject PinBoardSolutionButton;




    // Start is called before the first frame update
    void Start()
    {
        PointCode = GameObject.Find("Punkt").GetComponent<MayaCodePinBoard>();
        LineCode = GameObject.Find("Strich").GetComponent<MayaCodePinBoard>();
        BreadCode = GameObject.Find("BreadSymbol").GetComponent<MayaCodePinBoard>();

        PointDrop = GameObject.Find("Punkt").GetComponent<MayaSymbolDrop>();
        LineDrop = GameObject.Find("Strich").GetComponent<MayaSymbolDrop>();
        BreadDrop = GameObject.Find("BreadSymbol").GetComponent<MayaSymbolDrop>();
    }

    // Update is called once per frame
    void Update()
    {





        // if(GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>() != null || GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>() != null || GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>() != null )
        // {
        // SolutionOneRight = GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().solutionOneRight;
        // SolutionTwoRight = GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().solutionTwoRight;
        // SolutionThreeRight = GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().solutionThreeRight;
        // }

        SolutionOneRight = GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>().solutionOneRight;
        SolutionTwoRight = GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>().solutionTwoRight;
        //SolutionThreeRight = GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>().solutionThreeRight;





        if(SolutionOneRight == true && SolutionTwoRight == true)
        {
            PyramideClose.SetActive(false);
            PyramideOpen.SetActive(true);
            Debug.Log("You got everything right");

            //Pinboard.SetActive(false);
            PinboardSolution.SetActive(true);
            PinBoardButton.SetActive(false);
            PinBoardSolutionButton.SetActive(true);
            PinboardSolutionSmall.SetActive(true);


            // Destroy( GameObject.Find("SolutionOne").GetComponent<SecretSolutionDetection>());
            // Destroy(GameObject.Find("SolutionTwo").GetComponent<SecretSolutionDetection>());
            // Destroy(GameObject.Find("SolutionThree").GetComponent<SecretSolutionDetection>());


            
            // Destroy(PointDrop);
            // Destroy(LineDrop);
            // Destroy(BreadDrop);

            // Destroy(PointCode);
            // Destroy(LineCode);
            // Destroy(BreadCode);

        // foreach(GameObject symbol in GameObject.FindGameObjectsWithTag("SymbolPrefab"))
        // {
        //     Destroy(symbol.GetComponent<MayaSymbolDrop>());
        // }



        }

    }
}
