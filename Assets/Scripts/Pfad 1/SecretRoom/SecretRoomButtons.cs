using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretRoomButtons : MonoBehaviour
{

    public GameObject SecretRoom;
    public GameObject GeheimerRaum;
    public GameObject ClassRoom;
    public GameObject OpenPyramid;
    public GameObject ClosedPyramid;
    public GameObject MayaImage;
    public GameObject PinBoard;
    public GameObject PinBoardSolution;
    public GameObject PinBoardButton;
    public GameObject PinBoardSolutionButton;
    public GameObject PinboardSolutionSmall;

    // Start is called before the first frame update
    void Start()
    {
        SecretRoom.SetActive(true);
        GeheimerRaum.SetActive(true);
        ClassRoom.SetActive(false);
        OpenPyramid.SetActive(false);
        ClosedPyramid.SetActive(true);
        MayaImage.SetActive(false);
        PinBoard.SetActive(false);
        PinBoardSolution.SetActive(false);
        PinBoardSolutionButton.SetActive(false);
        PinboardSolutionSmall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PortalToClassroom()
    {
        SecretRoom.SetActive(false);
        ClassRoom.SetActive(true);
    }

    public void ClickOnPyramid()
    {
        OpenPyramid.SetActive(true);
        ClosedPyramid.SetActive(false);
    }

    public void ClickOnMayaImage()
    {
        GeheimerRaum.SetActive(false);
        MayaImage.SetActive(true);
    }

    public void ClickOnPinBoard()
    {
        GeheimerRaum.SetActive(false);
        PinBoard.SetActive(true);
    }

    public void ClickOnPinBoardSolution()
    {
        GeheimerRaum.SetActive(false);
        PinBoardSolution.SetActive(true);
    }

    public void BackButton()
    {
        MayaImage.SetActive(false);
        PinBoard.SetActive(false);
        GeheimerRaum.SetActive(true);
        PinBoardSolution.SetActive(false);
    }

}
