﻿using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ToPyramidRoom()
    {
        ClassRoom.SetActive(false);
        PyramidRoom.SetActive(true);
        PyramidRoomTotal.SetActive(true);
    }

    public void OpenCloset()
    {
        Closet.SetActive(false);
        ClosetDoor.SetActive(true);
    }

    public void ClosetPortal()
    {
        ClassRoom.SetActive(false);
        SecretRoom.SetActive(true);
    }

}
