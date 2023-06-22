using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeenageRoomButtonManager : MonoBehaviour
{
    public GameObject PianoRoom;
    public GameObject TeenageRoom;
    public GameObject TetriX;
    public GameObject Atelier;
    public GameObject Nirvana;

    public GameObject EyeButton;
    public GameObject StraightToNirvanaButton;


    public GameObject TeenageRoomEmpty;
    public GameObject PitendoControler;
    public GameObject TeenageRoomButtons;
    public GameObject Radio;
    public GameObject RadioFull;
    public GameObject Poster;
    public GameObject NoteSheetThree;
    public GameObject PostIt;

    public GameObject CobainPoster_1;
    public GameObject CobainPoster_2;
    public GameObject CobainPoster_3;
    public GameObject CobainPoster_4;
    public GameObject CobainPoster_5;
    public GameObject CobainPoster_6;
    public GameObject CobainPoster_7;


    public GameObject BigClock;
    public InventarArrow InventoryDown;

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoorToPianoRoomClick()
    {
        StartCoroutine(ToPianoRoomTransition());
    }

    public void DoorToAtelier()
    {
        StartCoroutine(ToAtelieRoomTransition());
        
    }

    public void PitendoControlerClick()
    {
        StartCoroutine(ToPitendoControlerTransition());
        
    }

    public void RadioClick()
    {
        StartCoroutine(ToRadioTransition());
        
    }

    public void PosterClick()
    {
        StartCoroutine(ToPosterTransition());
        
    }

    public void NoteSheetThreeClick()
    {
        StartCoroutine(ToNoteSheetThreeTransition());
        
    }

    public void PostItClick()
    {
        StartCoroutine(ToPostItTransition());
        
    }

    public void BackToTeenageRoom()
    {
        StartCoroutine(BackToTeenageRoomTransition());

        
    }

    public void ClickEyeOne()
    {
        StartCoroutine(ToEyeOneTransition());
    }

    public void ClickEyeTwo(){
        StartCoroutine(ToEyeTwoTransition());
    }

    public void ClickEyeThree(){
        StartCoroutine(ToEyeThreeTransition());
    }

    public void ClickEyeFour(){
        StartCoroutine(ToEyeFourTransition());
    }

    public void ClickEyeFive(){
        StartCoroutine(ToEyeFiveTransition());
    }

        public void ClickEyeSix(){
        StartCoroutine(ToEyeSixTransition());
    }

        public void ClickEyeSeven(){
        StartCoroutine(ToEyeSevenTransition());
    }

    public void ClickToNivrana(){
        StartCoroutine(ToNirvanaTransition());
    }


    public void ClickTetriXScreen(){
        StartCoroutine(ToTetrixTransition());
    }

    public void ClickOnRadioFull()
    {
        StartCoroutine(ToRadioFullTransition());
    }

    public void ClickOnClock()
    {
        StartCoroutine(ToClockTransition());
    }

    public IEnumerator ToPianoRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InventoryDown.selected = true;
        TeenageRoom.SetActive(false);
        PianoRoom.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToAtelieRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InventoryDown.selected = true;
        TeenageRoom.SetActive(false);
        Atelier.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToPitendoControlerTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        PitendoControler.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToRadioTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        Radio.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToPosterTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        Poster.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToNoteSheetThreeTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        NoteSheetThree.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToPostItTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        PostIt.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator BackToTeenageRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PostIt.SetActive(false);
        PitendoControler.SetActive(false);
        NoteSheetThree.SetActive(false);
        TeenageRoomButtons.SetActive(true);
        Radio.SetActive(false);
        RadioFull.SetActive(false);
        Poster.SetActive(false);

        CobainPoster_1.SetActive(false);
        CobainPoster_2.SetActive(false);
        CobainPoster_3.SetActive(false);
        CobainPoster_4.SetActive(false);
        CobainPoster_5.SetActive(false);
        CobainPoster_6.SetActive(false);
        CobainPoster_7.SetActive(false);

        BigClock.SetActive(false);


        TeenageRoomEmpty.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToTetrixTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InventoryDown.selected = true;
        TeenageRoom.SetActive(false);
        TetriX.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToRadioFullTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        RadioFull.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToClockTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        BigClock.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
    public IEnumerator ToEyeOneTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        Poster.SetActive(false);
        CobainPoster_1.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToEyeTwoTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        CobainPoster_1.SetActive(false);
        CobainPoster_2.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToEyeThreeTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        CobainPoster_2.SetActive(false);
        CobainPoster_3.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToEyeFourTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        CobainPoster_3.SetActive(false);
        CobainPoster_4.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToEyeFiveTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        CobainPoster_4.SetActive(false);
        CobainPoster_5.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToEyeSixTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        CobainPoster_5.SetActive(false);
        CobainPoster_6.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToEyeSevenTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        CobainPoster_6.SetActive(false);
        CobainPoster_7.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToNirvanaTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InventoryDown.selected = true;
        CobainPoster_7.SetActive(false);
        TeenageRoom.SetActive(false);
        EyeButton.SetActive(false);
        StraightToNirvanaButton.SetActive(true);
        Nirvana.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}

