using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidRoomButtons : MonoBehaviour
{

    public GameObject ControlRoom;
    public GameObject PyramidRoom;
    public GameObject DoorCode;

    public GameObject ClassRoom;

    public GameObject ControlRoomPic;
    public GameObject FoldedPaper;
    public GameObject UnfoldedPaper;
    public GameObject UnfoldedPaperBig;
    public GameObject PyramidOne;
    public GameObject PyramidTwo;
    public GameObject PyramidThree;
    public GameObject PyramidFive;
    public GameObject PyramidPicture;
    public GameObject PyramidNote;
    public GameObject PyramidFour;

    public GameObject PyramidRoomTotal;

    public GameObject MechanismOne;
    public GameObject MechanismTwo;
    public GameObject PyramidButtons;

    public GameObject PyramidHint;
    //public GameObject PyramidFour;



    // Start is called before the first frame update
    void Start()
    {
        FoldedPaper.SetActive(true);
        UnfoldedPaper.SetActive(false);
        UnfoldedPaperBig.SetActive(false);
        PyramidOne.SetActive(false);
        PyramidTwo.SetActive(false);
        PyramidThree.SetActive(false);
        PyramidFive.SetActive(false);
        PyramidPicture.SetActive(false);
        PyramidNote.SetActive(false);
        ClassRoom.SetActive(false);
        PyramidFour.SetActive(false);
        PyramidRoom.SetActive(true);
        PyramidRoomTotal.SetActive(true);
        MechanismOne.SetActive(false);
        MechanismTwo.SetActive(false);
        PyramidButtons.SetActive(true);
        PyramidHint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToControlRoom()
    {
        PyramidRoom.SetActive(false);
        ControlRoom.SetActive(true);
        DoorCode.SetActive(false);
        ControlRoomPic.SetActive(true);
        PyramidRoomTotal.SetActive(false);

    }

    public void UnfoldPaper()
    {
        FoldedPaper.SetActive(false);
        UnfoldedPaper.SetActive(true);
    }

    public void ClickUnfoldedPaper()
    {
        UnfoldedPaperBig.SetActive(true);
        PyramidRoom.SetActive(false);
    }

    public void ClickPyramidOne()
    {
        PyramidOne.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidThree()
    {
        PyramidThree.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidTwo()
    {
        PyramidTwo.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidFive()
    {
        PyramidFive.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidPicture()
    {
        PyramidPicture.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidNote()
    {
        PyramidNote.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidFour()
    {
        PyramidFour.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidHint()
    {
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
        PyramidHint.SetActive(true);
    }

    public void DoorToClassRoom()
    {
        PyramidRoom.SetActive(false);
        ClassRoom.SetActive(true);
        PyramidRoomTotal.SetActive(false);
    }

    public void MechanismOneButton()
    {
        PyramidFour.SetActive(false);
        MechanismOne.SetActive(true);
        PyramidButtons.SetActive(false);
    }

    public void MechanismTwoButton()
    {
        PyramidFive.SetActive(false);
        MechanismTwo.SetActive(true);
        PyramidButtons.SetActive(false);
    }

    public void MechanismOneReturn()
    {
        PyramidFour.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
    }

    public void MechanismTwoReturn()
    {
        PyramidFive.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
    }

    public void returnButton()
    {
        UnfoldedPaperBig.SetActive(false);
        PyramidOne.SetActive(false);
        PyramidRoom.SetActive(true);
        PyramidTwo.SetActive(false);
        PyramidThree.SetActive(false);
        PyramidFive.SetActive(false);
        PyramidPicture.SetActive(false);
        PyramidNote.SetActive(false);
        PyramidFour.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismOne.SetActive(false);
        PyramidButtons.SetActive(true);
        PyramidHint.SetActive(false);
    }
}
