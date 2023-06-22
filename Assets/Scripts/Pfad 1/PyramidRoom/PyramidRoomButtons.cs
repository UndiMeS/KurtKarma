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

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;



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
        PyramidRoom.SetActive(false);
        PyramidRoomTotal.SetActive(false);
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
        StartCoroutine(ToControlRoomTransition());

    }

    public IEnumerator ToControlRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidRoom.SetActive(false);
        ControlRoom.SetActive(true);
        DoorCode.SetActive(false);
        ControlRoomPic.SetActive(true);
        PyramidRoomTotal.SetActive(false);
        InventoryDown.selected = true;


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void UnfoldPaper()
    {
        FoldedPaper.SetActive(false);
        UnfoldedPaper.SetActive(true);
        Paper.Play();
    }

    public void ClickUnfoldedPaper()
    {
        StartCoroutine(ClickUnfoldedPaperTransition());
    }

    public IEnumerator ClickUnfoldedPaperTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        UnfoldedPaperBig.SetActive(true);
        PyramidButtons.SetActive(false);
        PyramidRoom.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickPyramidOne()
    {
        StartCoroutine(ClickPyramidOneTranistion());
    }

    public IEnumerator ClickPyramidOneTranistion()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidOne.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }


    public void ClickPyramidTwo()
    {
        StartCoroutine(ClickPyramidTwoTransition());
    }

    public IEnumerator ClickPyramidTwoTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidTwo.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickPyramidFour()
    {
        StartCoroutine(ClickPyramidFourTransition());
    }

    public IEnumerator ClickPyramidFourTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidFour.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickPyramidPicture()
    {
        StartCoroutine(ClickPyramidPictureTranslation());
    }

    public IEnumerator ClickPyramidPictureTranslation()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidPicture.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickPyramidNote()
    {
        StartCoroutine(ClickPyramidNoteTransition());
    }

    public IEnumerator ClickPyramidNoteTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidNote.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickPyramidNoteSecret()
    {
        StartCoroutine(ClickPyramidNoteSecretTransition());
    }

    public IEnumerator ClickPyramidNoteSecretTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidNoteSecret.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickPyramidThree()
    {
        StartCoroutine(ClickPyramidThreeTransition());
    }

    public IEnumerator ClickPyramidThreeTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidThree.SetActive(true);
        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickPyramidHint()
    {
        StartCoroutine(ClickPyramidHintTransition());
    }

    public IEnumerator ClickPyramidHintTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidRoom.SetActive(false);
        PyramidButtons.SetActive(false);
        PyramidHint.SetActive(true);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void DoorToClassRoom()
    {
        StartCoroutine(DoorToClassRoomTransition());
    }

    public IEnumerator DoorToClassRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidRoom.SetActive(false);
        ClassRoom.SetActive(true);
        PyramidRoomTotal.SetActive(false);

        InventoryDown.selected = true;


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
    

    public void MechanismOneButton()
    {
        StartCoroutine(MechanismOneButtonTransition());
    }

    public IEnumerator MechanismOneButtonTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidOne.SetActive(false);
        MechanismOne.SetActive(true);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void MechanismTwoButton()
    {
        StartCoroutine(MechanismTwoButtonTransition());
    }

    public IEnumerator MechanismTwoButtonTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidTwo.SetActive(false);
        MechanismTwo.SetActive(true);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void MechanismThreeButton()
    {
        StartCoroutine(MechanismThreeButtonTransition());
    }

    public IEnumerator MechanismThreeButtonTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidThree.SetActive(false);
        MechanismThree.SetActive(true);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void MechanismFourButton()
    {
        StartCoroutine(MechanismFourButtonTransition());
    }

    public IEnumerator MechanismFourButtonTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidFour.SetActive(false);
        MechanismFour.SetActive(true);
        PyramidButtons.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void MechanismOneReturn()
    {
        StartCoroutine(MechanismOneReturnTransition());
    }

    public IEnumerator MechanismOneReturnTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidOne.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void MechanismTwoReturn()
    {
        StartCoroutine(MechanismTwoReturnTransition());
    }

    public IEnumerator MechanismTwoReturnTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidTwo.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void MechanismThreeReturn()
    {
        StartCoroutine(MechanismThreeReturnTransition());
    }

    public IEnumerator MechanismThreeReturnTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidThree.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

        public void MechanismFourReturn()
    {
        StartCoroutine(MechanismFourReturnTransition());
    }

    public IEnumerator MechanismFourReturnTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PyramidFour.SetActive(true);
        MechanismTwo.SetActive(false);
        MechanismOne.SetActive(false);
        MechanismThree.SetActive(false);
        MechanismFour.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void returnButton()
    {
        StartCoroutine(returnButtonTransition());
    }

    public IEnumerator returnButtonTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}
