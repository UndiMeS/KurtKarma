using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretRoomButtons : MonoBehaviour
{

    public GameObject ArcadeRoom;
    public GameObject GeheimerRaum;
    public GameObject ClassRoom;
    public GameObject OpenPyramid;
    public GameObject ClosedPyramid;
    public GameObject MayaImage;
    public GameObject PinBoard;
    public GameObject PinBoardSolution;
    public GameObject PinBoardButton;
    public GameObject PinBoardSolutionButton;
    public GameObject XBertArcade;


    public InventarArrow InventoryDown;
    public GameObject InventoryArrowDown;
    public GameObject Inventory;
    public GameObject InventoryArrowUp;

    public GameObject ChestPictureButton;
    public GameObject ChestPicture;
    public GameObject XBertStartScreen;
    public GameObject XBertFinalScreen;
    public GameObject StartMenu;

    // Start is called before the first frame update
    void Start()
    {
        ArcadeRoom.SetActive(true);
        GeheimerRaum.SetActive(true);
        ClassRoom.SetActive(false);
        OpenPyramid.SetActive(false);
        //ClosedPyramid.SetActive(true);
        MayaImage.SetActive(false);
        PinBoard.SetActive(false);
        PinBoardSolution.SetActive(false);
        PinBoardSolutionButton.SetActive(false);
        //XBertArcade.SetActive(false);
        ChestPictureButton.SetActive(false);
        ChestPicture.SetActive(false);

        InventoryDown = InventoryArrowDown.GetComponent<InventarArrow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PortalToClassroom()
    {
        ClassRoom.SetActive(true);
        ArcadeRoom.SetActive(false);
        InventoryDown.selected = true;
        
        
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
        InventoryDown.selected = true;
        InventoryArrowUp.SetActive(false);


        PinBoard.SetActive(true);
        
        XBertStartScreen.SetActive(true);
        StartCoroutine(IntroScreen());
    }

        IEnumerator IntroScreen()
    {
        StartMenu.SetActive(false);
        XBertStartScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        XBertStartScreen.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void ClickOnPinBoardSolution()
    {
        GeheimerRaum.SetActive(false);
        PinBoardSolution.SetActive(true);
    }

    public void ClickOnChestPicture()
    {
        GeheimerRaum.SetActive(false);
        ChestPicture.SetActive(true);
    }

    public void BackButton()
    {
        MayaImage.SetActive(false);
        PinBoard.SetActive(false);
        ChestPicture.SetActive(false);
        GeheimerRaum.SetActive(true);
        PinBoardSolution.SetActive(false);
    }

    public void FinishedArcadeButton()
    {
        PinBoard.SetActive(true);
        InventoryDown.selected = true;
        InventoryArrowUp.SetActive(false);
        XBertFinalScreen.SetActive(true);
        GeheimerRaum.SetActive(false);
        
        //ArcadeRoom.SetActive(false);
    }


}
