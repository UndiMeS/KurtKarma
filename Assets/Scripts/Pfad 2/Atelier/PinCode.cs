using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PinCode : MonoBehaviour {
    public string Passwort;

    public string PasswortLösung;

    public float SpinSpeed;

    public GameObject SmallSafeOpen;
    public GameObject SmallSafeClosed;

    public GameObject SafeOpenButton;
    public GameObject SafeClosedButton;

    public GameObject Handle;
    public AudioSource HandleSound;
    public bool playhandle;

    public GameObject Lösung;

    public GameObject GrünerRand;

    public GameObject RoterRand;

    public GameObject ConfirmButton;

    public GameObject GreenButton;

    public GameObject RedButton;

    public GameObject TresorZu;

    public GameObject TresorOffen;
    public Button BackButton;

    public bool Richtig;

    public BoxCollider2D[] PinButtons;

    public Settings SettingsScript;
    public bool HintBool;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (Passwort.Length >= 3 && Passwort != PasswortLösung) {
            StartCoroutine (WrongPasswort ());
        }

        if (Passwort == PasswortLösung) {

            if (ConfirmButton.GetComponent<ButtonConfirm> ().selected == true) {
                if(playhandle == false)
                {
                    HandleSound.Play();
                    playhandle = true;
                }
                
                Debug.Log ("Passwort ist Korrekt");
                Richtig = true;
                ConfirmButton.SetActive (false);
                GreenButton.SetActive (true);
                StartCoroutine (KorrektPasswort ());

            }

        } else {
            if (ConfirmButton.GetComponent<ButtonConfirm> ().selected == true) {

                StartCoroutine (WrongPasswort ());

            }
        }

        if(Richtig == true)
        {
            Quaternion newRotation = Quaternion.AngleAxis(90, Vector3.forward);
            
            //Handle.transform.rotation= Quaternion.Slerp(Handle.transform.rotation, newRotation, SpinSpeed * Time.deltaTime);
            Handle.transform.rotation = Quaternion.RotateTowards(Handle.transform.rotation, newRotation, SpinSpeed * Time.deltaTime); 
        }
    }

    public IEnumerator KorrektPasswort () {

          

        GrünerRand.SetActive (true);
        BackButton.interactable = false;
        yield return new WaitForSeconds (2);
        BackButton.interactable = true;
        GrünerRand.SetActive (false);
        Passwort = ("");

        TresorZu.SetActive (false);
        TresorOffen.SetActive (true);

        SafeClosedButton.SetActive (false);
        SafeOpenButton.SetActive (true);

        SmallSafeClosed.SetActive (false);
        SmallSafeOpen.SetActive (true);

        if(HintBool == false)
        {
            SettingsScript.HintNumber = 5;
            HintBool = true;
        }

    }

    public IEnumerator WrongPasswort () {
        ConfirmButton.SetActive (false);
        RedButton.SetActive (true);
        RoterRand.SetActive(true);
        Passwort = ("");
        ConfirmButton.GetComponent<ButtonConfirm> ().selected = false;

        BackButton.interactable = false;

        foreach(BoxCollider2D PinButton in PinButtons)
        {
            PinButton.enabled = false;
        }

        yield return new WaitForSeconds (2);

        foreach(BoxCollider2D PinButton in PinButtons)
        {
            PinButton.enabled = true;
        }

        BackButton.interactable = true;

        RoterRand.SetActive(false);
        RedButton.SetActive (false);
        ConfirmButton.SetActive (true);
    }
}