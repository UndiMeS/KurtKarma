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

    public GameObject CobainPoster_1;
    public GameObject CobainPoster_2;
    public GameObject CobainPoster_3;
    public GameObject CobainPoster_4;
    public GameObject CobainPoster_5;
    public GameObject CobainPoster_6;
    public GameObject CobainPoster_7;
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
        TeenageRoom.SetActive(false);
        PianoRoom.SetActive(true);
    }

    public void DoorToAtelier()
    {
        TeenageRoom.SetActive(false);
        Atelier.SetActive(true);
    }

    public void PitendoControlerClick()
    {
        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        PitendoControler.SetActive(true);
    }

    public void RadioClick()
    {
        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        Radio.SetActive(true);
    }

    public void PosterClick()
    {
        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        Poster.SetActive(true);
    }

    public void NoteSheetThreeClick()
    {
        TeenageRoomEmpty.SetActive(false);
        TeenageRoomButtons.SetActive(false);
        NoteSheetThree.SetActive(true);
    }

    public void BackToTeenageRoom()
    {
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


        TeenageRoomEmpty.SetActive(true);
    }

    public void ClickEyeOne()
    {
        Poster.SetActive(false);
        CobainPoster_1.SetActive(true);
    }

    public void ClickEyeTwo(){
        CobainPoster_1.SetActive(false);
        CobainPoster_2.SetActive(true);
    }

    public void ClickEyeThree(){
        CobainPoster_2.SetActive(false);
        CobainPoster_3.SetActive(true);
    }

    public void ClickEyeFour(){
        CobainPoster_3.SetActive(false);
        CobainPoster_4.SetActive(true);
    }

    public void ClickEyeFive(){
        CobainPoster_4.SetActive(false);
        CobainPoster_5.SetActive(true);
    }

        public void ClickEyeSix(){
        CobainPoster_5.SetActive(false);
        CobainPoster_6.SetActive(true);
    }

        public void ClickEyeSeven(){
        CobainPoster_6.SetActive(false);
        CobainPoster_7.SetActive(true);
    }

    public void ClickToNivrana(){
        CobainPoster_7.SetActive(false);
        TeenageRoom.SetActive(false);
        EyeButton.SetActive(false);
        StraightToNirvanaButton.SetActive(true);
        Nirvana.SetActive(true);
    }


    public void ClickTetriXScreen(){
        TeenageRoom.SetActive(false);
        TetriX.SetActive(true);
    }

    public void ClickOnRadioFull()
    {
        TeenageRoomEmpty.SetActive(false);
        RadioFull.SetActive(true);
    }
}
