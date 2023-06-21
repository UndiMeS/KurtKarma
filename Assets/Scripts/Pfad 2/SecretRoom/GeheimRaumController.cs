using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GeheimRaumController : MonoBehaviour
{

    public TMP_InputField TresureCodeBigOne;
    public TMP_InputField TresureCodeBigTwo;
    public TMP_InputField TresureCodeBigThree;

    public TMP_Text TresureCodeSmallOne;
    public TMP_Text TresureCodeSmallTwo;
    public TMP_Text TresureCodeSmallThree;
    public SpriteButton TresureButtonSkript;

    public bool RightCode;
    public GameObject GreenFrame;
    public AudioClip OpenChestBox;
    public GameObject ChestBoxClosed;
    public GameObject ChestBoxOpen;
    public GameObject ChestBoxOpenButton;
    public GameObject ChestBoxClosedButton;
    public Button ChestClosedBackButton;
    public GameObject SecretRoomEmpty;
    public GameObject SecretRoom;
    public GameObject PianoRoom;
    public GameObject PianoRoomEmpty;
    public GameObject PianoRoomButtons;

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;

    public GameObject ChestNumerOne;
    public GameObject ChestNumberTwo;
    public GameObject ChestNumberThree;

    public SpriteRenderer SmallChestBox;
    public Sprite SmallChestBoxOpen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TresureCodeSmallOne.text = TresureCodeBigOne.text;
        TresureCodeSmallTwo.text = TresureCodeBigTwo.text;
        TresureCodeSmallThree.text = TresureCodeBigThree.text;



        if(TresureCodeBigOne.text == "0" && TresureCodeBigTwo.text == "4" && TresureCodeBigThree.text == "2" && TresureButtonSkript.pressed == true)
        {
            RightCode = true;
            StartCoroutine(TresureTrue());
        }
    }

    public IEnumerator TresureTrue()
    {
        ChestClosedBackButton.interactable = false;
        GreenFrame.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        GreenFrame.GetComponent<AudioSource>().clip = OpenChestBox;
        GreenFrame.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2.2f);

        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        GreenFrame.SetActive(false);
        ChestBoxClosed.SetActive(false);
        ChestBoxOpen.SetActive(true);
        ChestBoxOpenButton.SetActive(true);
        ChestBoxClosedButton.SetActive(false);

        ChestNumerOne.SetActive(false);
        ChestNumberTwo.SetActive(false);
        ChestNumberThree.SetActive(false);

        SmallChestBox.sprite = SmallChestBoxOpen;

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ClickOnChestBoxClosed()
    {
        StartCoroutine(ToChestBoxClosedTransition());
    }

    public void ClickOnChestBoxOpen()
    {
        StartCoroutine(ToChestBoxOpenTransition());
    }

    public void BackToSecretRoom()
    {
        StartCoroutine(BackToSecretRoomTransition());
    }

    public void ToPianoRoom()
    {
        StartCoroutine(ToPianoRoomTransition());
    }

    public IEnumerator ToChestBoxClosedTransition()
    {

        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        SecretRoomEmpty.SetActive(false);
        ChestBoxClosed.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
        
    }

    public IEnumerator ToChestBoxOpenTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        SecretRoomEmpty.SetActive(false);
        ChestBoxOpen.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
        
    }

    public IEnumerator BackToSecretRoomTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        SecretRoomEmpty.SetActive(true);
        ChestBoxOpen.SetActive(false);
        ChestBoxClosed.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToPianoRoomTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        SecretRoom.SetActive(false);
        ChestBoxOpen.SetActive(false);
        ChestBoxClosed.SetActive(false);
        PianoRoom.SetActive(true);
        PianoRoomEmpty.SetActive(true);
        PianoRoomButtons.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}
