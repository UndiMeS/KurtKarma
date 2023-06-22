using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoRoomButtonManager : MonoBehaviour
{

    public GameObject HiddenSheet;
    public GameObject PianoView;
    public GameObject NoteSheetOne;
    public GameObject NoteSheetTwo;
    public GameObject NoteSheetFour;
    public GameObject PianoRoomEmpty;
    public GameObject TeenageRoom;
    public GameObject PianoRoomButtons;

    public TastenPasswort KlaviePasswort;


    public GameObject PianoRoom;
    public GameObject Inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HiddenSheetClick()
    {
        HiddenSheet.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);

    }

    public void PianoClick()
    {
        PianoView.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);
        Inventory.SetActive(false);
    }

    public void NoteSheetOneClick()
    {
        NoteSheetOne.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);
    }

    public void NoteSheetTwoClick()
    {
        NoteSheetTwo.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);
    }

    public void NoteSheetFourClick()
    {
        NoteSheetFour.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);
    }

    public void TeenageRoomDoorClick()
    {
        PianoRoom.SetActive(false);
        TeenageRoom.SetActive(true);
    }

    public void BackToPianoRoom()
    {

        HiddenSheet.SetActive(false);
        NoteSheetOne.SetActive(false);
        NoteSheetTwo.SetActive(false);
        NoteSheetFour.SetActive(false);
        PianoView.SetActive(false);
        PianoRoomButtons.SetActive(true);
        PianoRoomEmpty.SetActive(true);
        Inventory.SetActive(true);

        KlaviePasswort.Passwort = ("");
    }
}
