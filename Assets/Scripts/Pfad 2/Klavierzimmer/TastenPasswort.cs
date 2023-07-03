using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TastenPasswort : MonoBehaviour
{

    public string Passwort;

    public string PasswortLösung;
    public GameObject BüsteKaputt;
    public GameObject GameModul;
    public GameObject BüsteGanz;
    public GameObject KlappeZu;
    public GameObject KlappeAuf;

    public GameObject Lösung;

    public GameObject GrünerRand;
    public Button BackButton;

    public SpriteRenderer DoorLight;
    public Sprite GreenDoorLight;

    public bool Richtig;

    public string GeheimPasswortLösung;
    public SpriteRenderer SecretDoor;
    public Sprite SecretDoorOpen;
    public GameObject ButtonToSecretRoom;
    public AudioSource SecretDoorCreak;    // Start is called before the first frame update
    public bool secret;
    public Animator TokenAnim;

    public Settings SettingsScript;

    public bool solved;

    public bool secretsolved;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Passwort.Contains(PasswortLösung) && solved == false)
        {

            solved = true;

            Debug.Log("Passwort ist Korrekt");
            StartCoroutine(KorrektPasswort());
            DoorLight.sprite = GreenDoorLight;
            BüsteGanz.SetActive(false);
            KlappeZu.SetActive(false);

            KlappeAuf.SetActive(true);
            GameModul.SetActive(true);
            BüsteKaputt.SetActive(true);
            TokenAnim.SetBool("Start", true);

        }
        if(Passwort.Contains(GeheimPasswortLösung) && secretsolved == false)
        {
            secretsolved = true;
            
            StartCoroutine(KorrektSecret());
        }
    }

    public IEnumerator KorrektPasswort()
    {

        GrünerRand.SetActive(true);
        BackButton.interactable = false;
        yield return new WaitForSeconds(2);
        BackButton.interactable = true;
        GrünerRand.SetActive(false);
        Passwort = ("");
        Richtig = true;

        SettingsScript.HintNumber = 2;
        

    }

    public IEnumerator KorrektSecret(){
        SecretDoor.sprite = SecretDoorOpen;
        yield return new WaitForSeconds(1.5f);
        if(secret == false)
        {
            SecretDoorCreak.Play();
        }
        
        ButtonToSecretRoom.SetActive(true);
        secret = true;
    }
}
