using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiranaButton : MonoBehaviour
{

    public GameObject Nirvana;

    public GameObject GameScreen;
    public GameObject FinalScreen;

    public GameObject TeenageRoomButtons;
    public GameObject TeenageRoomEmpty;

    public GameObject CobainPoster;

    public GameObject NirvanaEmpty;
    public GameObject TeenageRoom;
    public GameObject SolutionInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickOnRoomPicture()
    {
        Nirvana.SetActive(false);
        CobainPoster.SetActive(false);
        TeenageRoom.SetActive(true);
        TeenageRoomEmpty.SetActive(true);
        TeenageRoomButtons.SetActive(true);
    }

    public void ClickOnSolutionInput()
    {
        NirvanaEmpty.SetActive(false);
        SolutionInput.SetActive(true);
    }

    public void BackToNirvana()
    {
        SolutionInput.SetActive(false);

        NirvanaEmpty.SetActive(true);
        
    }

    public void FinalDoor()
    {
        FinalScreen.SetActive(true);
        GameScreen.SetActive(false);
    }
}
