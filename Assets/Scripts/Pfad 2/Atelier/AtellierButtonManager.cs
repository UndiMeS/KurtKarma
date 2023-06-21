using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtellierButtonManager : MonoBehaviour
{

    public GameObject TeenageRoom;
    public GameObject TeenageRoomEmpty;
    public GameObject Atelier;

    public GameObject HintNote;

    public GameObject AtelierEmpty;


    public GameObject LeftPainting;
    public GameObject MiddlePainting;
    public GameObject RightPainting;
    public GameObject TresorOpen;

    public GameObject SafeClosed;
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

    public void DoorToTeenageRoom()
    {
        StartCoroutine(ToTeenageRoomTransition());
    }

    public void ClickLeftPainting()
    {
        StartCoroutine(ToLeftPictureTransition());
    }

    public void ClickMiddlePainting()
    {
        StartCoroutine(ToMiddlePictureTransition());
    }

    public void ClickRightPainting()
    {
        StartCoroutine(ToRightPictureTransition());
    }

    public void ClickSafe()
    {
        StartCoroutine(ToSafeTransition());
    }

    public void ClickSafeOpen()
    {
        StartCoroutine(ToSafeOpenTransition());
    }

    public void BackToAtelier()
    {
        StartCoroutine(BackToAtelierTransition());
        
    }

    public void ClickOnNote()
    {
        StartCoroutine(ToNoteTransition());
    }

    public IEnumerator ToTeenageRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InventoryDown.selected = true;
        Atelier.SetActive(false);
        TeenageRoom.SetActive(true);
        
        TeenageRoomEmpty.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToLeftPictureTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        AtelierEmpty.SetActive(false);
        LeftPainting.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToMiddlePictureTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        AtelierEmpty.SetActive(false);
        MiddlePainting.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToRightPictureTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        AtelierEmpty.SetActive(false);
        RightPainting.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToSafeTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        AtelierEmpty.SetActive(false);
        SafeClosed.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToSafeOpenTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        AtelierEmpty.SetActive(false);
        TresorOpen.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator BackToAtelierTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        LeftPainting.SetActive(false);
        MiddlePainting.SetActive(false);
        RightPainting.SetActive(false);
        SafeClosed.SetActive(false);
        TresorOpen.SetActive(false);
        HintNote.SetActive(false);
        AtelierEmpty.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToNoteTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        AtelierEmpty.SetActive(false);
        HintNote.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}
