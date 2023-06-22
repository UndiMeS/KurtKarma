using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer_Button_1_Handler : MonoBehaviour {

    public GameObject ComputerScreen_1;
    public GameObject ComputerScreen_1_2;
    public GameObject ComputerScreen_2;
    public GameObject ComputerScreen_3;
    public GameObject ComputerScreen_4;
    public GameObject ComputerScreen_5;
    public GameObject ComputerScreen_6;
    public GameObject DoorOpener;
    public GameObject ControlRoom;
    public GameObject Monitor_1_1;
    public GameObject Monitor_1_2;
    public GameObject JunkRoom;
    public GameObject DoorToJunkRoom;
    public GameObject PyramidRoom;
    public GameObject PostIt;
    public GameObject GreenCodeDoor;
    public GameObject ClassRoom;
    public GameObject SecretRoom;
    public GameObject PyramidRoomEmpty;
    public GameObject ChestBottom;
    public GameObject AllTitles;
    public GameObject DemoTitle;
    public GameObject TitleOne;
    public GameObject TitleTwo;
    public GameObject TitleThree;

    // Start is called before the first frame update
    void Start () {
        AllTitles.SetActive(true);
        DemoTitle.SetActive(true);
        TitleOne.SetActive(false);
        TitleTwo.SetActive(false);
        TitleThree.SetActive(false);
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        Monitor_1_2.SetActive (false);
        JunkRoom.SetActive (false);
        DoorToJunkRoom.SetActive (false);
        PyramidRoom.SetActive (false);
        PostIt.SetActive (false);
        GreenCodeDoor.SetActive (false);
        ClassRoom.SetActive(false);
        SecretRoom.SetActive(false);
        ChestBottom.SetActive(false);

    }

    // Update is called once per frame
    void Update () {

    }

    public void ClickDemoStart(){
        DemoTitle.SetActive(false);
        StartCoroutine(TitleScreen());
    }

    public void ComputerScreen_1Click () {

        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (true);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);

    }

    public void ComputerScreen_2Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (true);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_3Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (true);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_4Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (true);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_5Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (true);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_6Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (true);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void DoorOpener_Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (true);
        PostIt.SetActive (false);
    }

    public void BackButton () {
        ControlRoom.SetActive (true);
        //Monitor_1_2.SetActive(false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void QRMonitor_Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (true);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void QRBackButton () {
        ControlRoom.SetActive (true);
        Monitor_1_1.SetActive (false);
        Monitor_1_2.SetActive (true);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ToJunkRoom () {
        ControlRoom.SetActive (false);
        JunkRoom.SetActive (true);
        PostIt.SetActive (false);
    }
    public void PostItClick () {
        ControlRoom.SetActive (false);
        PostIt.SetActive (true);
    }

    public void ToPyramidRoom () {
        ControlRoom.SetActive (false);
        PyramidRoom.SetActive (true);
        PyramidRoomEmpty.SetActive(true);
    }

    IEnumerator TitleScreen(){
        TitleOne.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        TitleOne.SetActive(false);
        TitleTwo.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        TitleTwo.SetActive(false);
        TitleThree.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        TitleThree.SetActive(false);
        
        ControlRoom.SetActive(true);
    }
}