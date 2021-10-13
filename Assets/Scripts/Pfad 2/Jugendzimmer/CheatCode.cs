using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCode : MonoBehaviour
{
    
    public string Passwort;

    public string PasswortLösung;
    public GameObject GrüneLampe;
    public GameObject RoteLampe;
    public GameObject Tür;

    public GameObject SmallSafeOpen;
    public GameObject SmallSafeClosed;

    public GameObject SafeOpenButton;
    public GameObject SafeClosedButton;


    public GameObject Lösung;

    public GameObject GrünerRand;

    public GameObject ConfirmButton;

    public GameObject GreenButton;

    public GameObject RedButton;

    public GameObject TresorZu;

    public GameObject TresorOffen;

    public bool Richtig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Passwort.Contains(PasswortLösung))
        {

            

            if(this.gameObject.name == "CheatAnalyse")
            {
            Debug.Log("Passwort ist Korrekt");
            StartCoroutine(KorrektPasswort());
            GrüneLampe.SetActive(true);
            RoteLampe.SetActive(false);
            Tür.SetActive(true);
            }

            if(this.gameObject.name == "PinAnalyse" && ConfirmButton.GetComponent<ButtonConfirm>().selected == true)
            {
                Debug.Log("Passwort ist Korrekt");
                ConfirmButton.SetActive(false);
                GreenButton.SetActive(true);
                StartCoroutine(KorrektPasswort());

            }



            //BüsteGanz.SetActive(false);
            //KlappeZu.SetActive(false);

            //KlappeAuf.SetActive(true);
            //GameModul.SetActive(true);
            //BüsteKaputt.SetActive(true);

        }
        else{
            if(this.gameObject.name == "PinAnalyse" && ConfirmButton.GetComponent<ButtonConfirm>().selected == true)
            {
                

                StartCoroutine(WrongPasswort());

            }
        }
    }

    public IEnumerator KorrektPasswort()
    {

        GrünerRand.SetActive(true);
        yield return new WaitForSeconds(2);
        GrünerRand.SetActive(false);
        Passwort = ("");

        if(this.gameObject.name == "PinAnalyse")
        {
                TresorZu.SetActive(false);
                TresorOffen.SetActive(true);

                SafeClosedButton.SetActive(false);
                SafeOpenButton.SetActive(true);

                SmallSafeClosed.SetActive(false);
                SmallSafeOpen.SetActive(true);
        }
        

    }

    public IEnumerator WrongPasswort()
    {
        ConfirmButton.SetActive(false);
        RedButton.SetActive(true);
        Passwort = ("");

        yield return new WaitForSeconds(2);

        RedButton.SetActive(false);
        ConfirmButton.SetActive(true);
    }
}
