using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassRoomButtons : MonoBehaviour
{

    public GameObject PyramidRoom;
    public GameObject PyramidRoomTotal;
    public GameObject ClassRoom;
    public GameObject Closet;
    public GameObject ClosetDoor;
    public GameObject SecretRoom;
    public GameObject RedFrame;
    public GameObject GreenFrame;
    public AudioSource ClosetSound;
    public InventarArrow InventoryDown;
    public GameObject InventoryArrowDown;

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;


    // Start is called before the first frame update
    void Start()
    {
        PyramidRoom.SetActive(false);
        ClassRoom.SetActive(true);
        Closet.SetActive(true);
        ClosetDoor.SetActive(false);
        SecretRoom.SetActive(false);
        PyramidRoomTotal.SetActive(false);
        RedFrame.SetActive(false);
        GreenFrame.SetActive(false);

        InventoryDown = InventoryArrowDown.GetComponent<InventarArrow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ToPyramidRoom()
    {
        StartCoroutine(ToPyramidRoomTransition());
    }

    public IEnumerator ToPyramidRoomTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ClassRoom.SetActive(false);
        PyramidRoom.SetActive(true);
        PyramidRoomTotal.SetActive(true);
        InventoryDown.selected = true;


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void OpenCloset()
    {

        Closet.SetActive(false);
        ClosetDoor.SetActive(true);

        //StartCoroutine(OpenClosetTransition());
        //ClosetSound.Play();
    }

    public IEnumerator OpenClosetTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        Closet.SetActive(false);
        ClosetDoor.SetActive(true);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClosetPortal()
    {
        StartCoroutine(ClosetPortalTransition());
    }

    public IEnumerator ClosetPortalTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ClassRoom.SetActive(false);
        SecretRoom.SetActive(true);
        InventoryDown.selected = true;


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

}
