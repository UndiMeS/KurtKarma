using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_switch : MonoBehaviour
{

    public GameObject mainCamera;
    public GameObject arCamera;
    public GameObject arScreen;
    public GameObject gameScreen;
    public GameObject controlRoom;
    public GameObject junkRoom;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.SetActive(true);
        arCamera.SetActive(false);
        gameScreen.SetActive(true);
        arScreen.SetActive(false);
        // controlRoom.SetActive(true);
        // junkRoom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scanner()
    {
        mainCamera.SetActive(false);
        gameScreen.SetActive(false);
        arCamera.SetActive(true);
        arScreen.SetActive(true);
        // controlRoom.SetActive(false);
        // junkRoom.SetActive(false);
    }
    public void BackToGame()
    {
        mainCamera.SetActive(true);
        arCamera.SetActive(false);
        gameScreen.SetActive(true);
        arScreen.SetActive(false);
        // controlRoom.SetActive(false);
        // junkRoom.SetActive(true);
    }
}
