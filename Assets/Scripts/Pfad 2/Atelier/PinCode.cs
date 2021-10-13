using System.Collections;
using System.Collections.Generic;
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

    public GameObject Lösung;

    public GameObject GrünerRand;

    public GameObject RoterRand;

    public GameObject ConfirmButton;

    public GameObject GreenButton;

    public GameObject RedButton;

    public GameObject TresorZu;

    public GameObject TresorOffen;

    public bool Richtig;
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
        yield return new WaitForSeconds (2);
        GrünerRand.SetActive (false);
        Passwort = ("");

        TresorZu.SetActive (false);
        TresorOffen.SetActive (true);

        SafeClosedButton.SetActive (false);
        SafeOpenButton.SetActive (true);

        SmallSafeClosed.SetActive (false);
        SmallSafeOpen.SetActive (true);

    }

    public IEnumerator WrongPasswort () {
        ConfirmButton.SetActive (false);
        RedButton.SetActive (true);
        RoterRand.SetActive(true);
        Passwort = ("");
        ConfirmButton.GetComponent<ButtonConfirm> ().selected = false;

        yield return new WaitForSeconds (2);

        RoterRand.SetActive(false);
        RedButton.SetActive (false);
        ConfirmButton.SetActive (true);
    }
}