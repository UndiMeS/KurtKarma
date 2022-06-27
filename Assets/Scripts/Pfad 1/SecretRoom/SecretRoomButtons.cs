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

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;
    public AudioSource Backgroundmusic;

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
        StartCoroutine(PortalToClassroomTransition());
        
        
    }

    public IEnumerator PortalToClassroomTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ClassRoom.SetActive(true);
        ArcadeRoom.SetActive(false);
        InventoryDown.selected = true;


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickOnPyramid()
    {
        StartCoroutine(ClickOnPyramidTranstion());
    }

    public IEnumerator ClickOnPyramidTranstion()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        OpenPyramid.SetActive(true);
        ClosedPyramid.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickOnMayaImage()
    {
        StartCoroutine(ClickOnMayaImageTransition());
    }

    public IEnumerator ClickOnMayaImageTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        GeheimerRaum.SetActive(false);
        MayaImage.SetActive(true);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickOnPinBoard()
    {
        StartCoroutine(ClickOnPinBoardTransition());
    }

    public IEnumerator ClickOnPinBoardTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        GeheimerRaum.SetActive(false);
        InventoryDown.selected = true;
        InventoryArrowUp.SetActive(false);


        PinBoard.SetActive(true);
        
        XBertStartScreen.SetActive(true);
        //StartCoroutine(FadeOut(Backgroundmusic, 400.0f));
        Backgroundmusic.Stop();
        StartCoroutine(IntroScreen());


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
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
        StartCoroutine(ClickOnPinBoardSolutionTransition());
    }

    public IEnumerator ClickOnPinBoardSolutionTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        GeheimerRaum.SetActive(false);
        PinBoardSolution.SetActive(true);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickOnChestPicture()
    {
        StartCoroutine(ClickOnChestPictureTransition());
    }

    public IEnumerator ClickOnChestPictureTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        GeheimerRaum.SetActive(false);
        ChestPicture.SetActive(true);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void BackButton()
    {
        StartCoroutine(BackButtonTransition());
    }

    public IEnumerator BackButtonTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        

        MayaImage.SetActive(false);
        PinBoard.SetActive(false);
        ChestPicture.SetActive(false);
        GeheimerRaum.SetActive(true);
        PinBoardSolution.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

        Backgroundmusic.Play();
    }

    public void FinishedArcadeButton()
    {
        StartCoroutine(FinishedArcadeButtonTransition());
        
        //ArcadeRoom.SetActive(false);
    }

    public IEnumerator FinishedArcadeButtonTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PinBoard.SetActive(true);
        InventoryDown.selected = true;
        InventoryArrowUp.SetActive(false);
        XBertFinalScreen.SetActive(true);
        GeheimerRaum.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }



    public static IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {
        float startVolume = audioSource.volume;
 
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop ();
        audioSource.volume = startVolume;
    }


}
