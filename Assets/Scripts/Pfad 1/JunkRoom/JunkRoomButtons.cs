using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRoomButtons : MonoBehaviour
{

    public GameObject ControlRoom;
    public GameObject JunkRoom;
    public GameObject Barricade;
    public GameObject JunkRoomDoor;
    public GameObject ControlRoomPic;
    public GameObject Computer_1_2;
    //public GameObject Monitor_1_2;
    public GameObject PyramidRoom;
    public GameObject ChestBottom;
    public GameObject Rumpelkammer;


    public InventarArrow InventoryDown;
    public GameObject InventoryArrowDown;

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;



    // Start is called before the first frame update
    void Start()
    {
        InventoryDown = InventoryArrowDown.GetComponent<InventarArrow>();
    }

    void awake()
    {
        Computer_1_2.SetActive(false);
        PyramidRoom.SetActive(false);
        //ChestBottom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChestClick()
    {
        StartCoroutine(ChestClickTransition());
    }

    public IEnumerator ChestClickTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ChestBottom.SetActive(true);
        Rumpelkammer.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void BackButton()
    {
        StartCoroutine(BackButtonTransition());
    }

    public IEnumerator BackButtonTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ChestBottom.SetActive(false);
        //JunkRoom.SetActive(true);
        Rumpelkammer.SetActive(true);
        Debug.Log("back button press");


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ToControlRoom()
    {
        StartCoroutine(ToControlRoomTransition());
    }

    public IEnumerator ToControlRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ControlRoom.SetActive(true);
        ControlRoomPic.SetActive(true);
        Computer_1_2.SetActive(false);
        //Monitor_1_2.SetActive(true);

        InventoryDown.selected = true;
        
        Barricade.SetActive(false);
        JunkRoom.SetActive(false);
        JunkRoomDoor.SetActive(true);
        PyramidRoom.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}
