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
    public GameObject SecretRoom;
    public GameObject DoorToTeenageRoom;

    public TastenPasswort KlaviePasswort;
    public GameObject KlavierItem;


    public GameObject PianoRoom;
    public GameObject Inventory;

    public InventarArrow InventoryDown;
    public bool ClosePianoOnce;

    public AudioSource BreakingVase;
    public GameObject BrokenVase;
    bool BreakingSound = true;

    public GameObject TokenOne;
    public Animator TokenOneAnim;
    public bool tokenOneBool;

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
        if(BrokenVase.activeSelf == true)
        {
            DoorToTeenageRoom.SetActive(true);
            if(BreakingSound == true)
            {
                Invoke("BreakSound", 1.5f);
                BreakingSound = false;
            }
            
        }

        if(TokenOne.activeSelf == true)
        {
            if(tokenOneBool == false)
            {
                TokenOneAnim.SetBool("Start", true);
                tokenOneBool = true;
            }
        }
    }

    void BreakSound()
    {
        BreakingVase.PlayOneShot(BreakingVase.clip);
        
        
    }

    public void HiddenSheetClick()
    {
        StartCoroutine(ToHiddenSheetTransition());
        

    }

    public void PianoClick()
    {
        StartCoroutine(ToPianoViewTransition());

        
        //Inventory.SetActive(false);
    }

    public void NoteSheetOneClick()
    {
        StartCoroutine(ToNoteSheetOneTransition());
    }

    public void NoteSheetTwoClick()
    {
        StartCoroutine(ToNoteSheetTwoTransition());
        
    }

    public void NoteSheetFourClick()
    {
        

        StartCoroutine(ToNoteSheetFourTransition());
    }

    public void TeenageRoomDoorClick()
    {
        StartCoroutine(ToTeenageRoomTransition());
    }

    public void BackToPianoRoom()
    {

        StartCoroutine(BackToPianoRoomTransition());

       
    }

    public void ClosePianoView()
    {
        StartCoroutine(ClosePianoViewTransition());
    }

    public void ToSecretRoom()
    {
        StartCoroutine(ToSecretRoomTransition());
    }
        

    public IEnumerator ToTeenageRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PianoRoom.SetActive (false);
        TeenageRoom.SetActive (true);
        InventoryDown.selected = true;

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }
    public IEnumerator ToHiddenSheetTransition(){

        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        HiddenSheet.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToPianoViewTransition(){

        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        PianoView.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToNoteSheetOneTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        NoteSheetOne.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToNoteSheetTwoTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        NoteSheetTwo.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToNoteSheetFourTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        NoteSheetFour.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoomButtons.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator BackToPianoRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

         HiddenSheet.SetActive(false);
        NoteSheetOne.SetActive(false);
        NoteSheetTwo.SetActive(false);
        NoteSheetFour.SetActive(false);
        PianoView.SetActive(false);
        PianoRoomButtons.SetActive(true);
        PianoRoomEmpty.SetActive(true);
        Inventory.SetActive(true);

        KlaviePasswort.Passwort = ("");

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ClosePianoViewTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        if(KlaviePasswort.Richtig == true && ClosePianoOnce == false)
        {
            KlavierItem.SetActive(true);
            ClosePianoOnce = true;
        }
        PianoView.SetActive(false);
        PianoRoomButtons.SetActive(true);
        PianoRoomEmpty.SetActive(true);
        //Inventory.SetActive(true);
    

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToSecretRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        SecretRoom.SetActive(true);
        PianoRoomEmpty.SetActive(false);
        PianoRoom.SetActive(false);
        PianoRoomButtons.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}
