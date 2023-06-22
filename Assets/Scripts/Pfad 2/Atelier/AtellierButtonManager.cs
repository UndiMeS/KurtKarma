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
        Atelier.SetActive(false);
        TeenageRoom.SetActive(true);
        
        TeenageRoomEmpty.SetActive(true);
    }

    public void ClickLeftPainting()
    {
        AtelierEmpty.SetActive(false);
        LeftPainting.SetActive(true);
    }

    public void ClickMiddlePainting()
    {
        AtelierEmpty.SetActive(false);
        MiddlePainting.SetActive(true);
    }

    public void ClickRightPainting()
    {
        AtelierEmpty.SetActive(false);
        RightPainting.SetActive(true);
    }

    public void ClickSafe()
    {
        AtelierEmpty.SetActive(false);
        SafeClosed.SetActive(true);
    }

    public void ClickSafeOpen()
    {
        AtelierEmpty.SetActive(false);
        TresorOpen.SetActive(true);
    }

    public void BackToAtelier()
    {
        LeftPainting.SetActive(false);
        MiddlePainting.SetActive(false);
        RightPainting.SetActive(false);
        SafeClosed.SetActive(false);
        TresorOpen.SetActive(false);
        HintNote.SetActive(false);
        AtelierEmpty.SetActive(true);
    }

    public void ClickOnNote()
    {
        AtelierEmpty.SetActive(false);
        HintNote.SetActive(true);
    }
}
