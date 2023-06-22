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
    public GameObject Monitor_1_2;
    public GameObject PyramidRoom;
    public GameObject ChestBottom;
    public GameObject Rumpelkammer;

    // Start is called before the first frame update
    void Start()
    {

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
        ChestBottom.SetActive(true);
        Rumpelkammer.SetActive(false);
    }

    public void BackButton()
    {
        ChestBottom.SetActive(false);
        //JunkRoom.SetActive(true);
        Rumpelkammer.SetActive(true);
        Debug.Log("back button press");
    }

    public void ToControlRoom()
    {
        ControlRoom.SetActive(true);
        ControlRoomPic.SetActive(true);
        Computer_1_2.SetActive(false);
        Monitor_1_2.SetActive(true);
        
        Barricade.SetActive(false);
        JunkRoom.SetActive(false);
        JunkRoomDoor.SetActive(true);
        PyramidRoom.SetActive(false);
    }
}
