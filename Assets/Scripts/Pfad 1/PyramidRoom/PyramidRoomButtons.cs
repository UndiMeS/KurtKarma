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
    public GameObject PyramidFour;
    public GameObject PyramidPicture;
    public GameObject PyramidNote;
    public GameObject PyramidNoteSecret;
    public GameObject PyramidThree;

    public GameObject PyramidRoomTotal;

    public GameObject MechanismOne;
    public GameObject MechanismTwo;
    public GameObject MechanismThree;
    public GameObject MechanismFour;
    public GameObject PyramidButtons;

    public GameObject PyramidHint;
    //public GameObject PyramidThree;


    public AudioSource Paper;

    public InventarArrow InventoryDown;
    public GameObject InventoryArrowDown;



    // Start is called before the first frame update
    void Start()
    {
        FoldedPaper.SetActive(true);
        UnfoldedPaper.SetActive(false);
        UnfoldedPaperBig.SetActive(false);
        PyramidOne.SetActive(false);
        PyramidTwo.SetActive(false);
        PyramidFour.SetActive(false);
        PyramidPicture.SetActive(false);
        PyramidNote.SetActive(false);
        ClassRoom.SetActive(false);
        PyramidThree.SetActive(false);
        PyramidRoom.SetActive(true);
        PyramidRoomTotal.SetActive(true);
        MechanismOne.SetActive(false);
        MechanismTwo.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);
        PyramidButtons.SetActive(true);
        PyramidHint.SetActive(false);

        InventoryDown = InventoryArrowDown.GetComponent<InventarArrow>();
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
        InventoryDown.selected = true;

    }

    public void UnfoldPaper()
    {
        FoldedPaper.SetActive(false);
        UnfoldedPaper.SetActive(true);
        Paper.Play();
    }

    public void ClickUnfoldedPaper()
    {
        UnfoldedPaperBig.SetActive(true);
        PyramidButtons.SetActive(false);
        PyramidRoom.SetActive(false);
    }

    public void ClickPyramidOne()
    {
        PyramidOne.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }


    public void ClickPyramidTwo()
    {
        PyramidTwo.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidFour()
    {
        PyramidFour.SetActive(true);
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

    public void ClickPyramidNoteSecret()
    {
        PyramidNoteSecret.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
    }

    public void ClickPyramidThree()
    {
        PyramidThree.SetActive(true);
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

        InventoryDown.selected = true;
    }

    public void MechanismOneButton()
    {
        PyramidOne.SetActive(false);
        MechanismOne.SetActive(true);
        PyramidButtons.SetActive(false);
    }

    public void MechanismTwoButton()
    {
        PyramidTwo.SetActive(false);
        MechanismTwo.SetActive(true);
        PyramidButtons.SetActive(false);
    }

    public void MechanismThreeButton()
    {
        PyramidThree.SetActive(false);
        MechanismThree.SetActive(true);
        PyramidButtons.SetActive(false);
    }

    public void MechanismFourButton()
    {
        PyramidFour.SetActive(false);
        MechanismFour.SetActive(true);
        PyramidButtons.SetActive(false);
    }

    public void MechanismOneReturn()
    {
        PyramidOne.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);
    }

    public void MechanismTwoReturn()
    {
        PyramidTwo.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);
    }

    public void MechanismThreeReturn()
    {
        PyramidThree.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);
    }

        public void MechanismFourReturn()
    {
        PyramidFour.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);
    }

    public void returnButton()
    {
        UnfoldedPaperBig.SetActive(false);
        PyramidOne.SetActive(false);
        PyramidRoom.SetActive(true);
        PyramidTwo.SetActive(false);
        PyramidFour.SetActive(false);
        PyramidPicture.SetActive(false);
        PyramidNote.SetActive(false);
        PyramidNoteSecret.SetActive(false);
        PyramidThree.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismOne.SetActive(false);
        PyramidButtons.SetActive(true);
        PyramidHint.SetActive(false);
    }
}
