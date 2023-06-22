using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

            Debug.Log("Passwort ist Korrekt");
            StartCoroutine(KorrektPasswort());
            BüsteGanz.SetActive(false);
            KlappeZu.SetActive(false);

            KlappeAuf.SetActive(true);
            GameModul.SetActive(true);
            BüsteKaputt.SetActive(true);

        }
    }

    public IEnumerator KorrektPasswort()
    {

        GrünerRand.SetActive(true);
        yield return new WaitForSeconds(2);
        GrünerRand.SetActive(false);
        Passwort = ("");
        

    }
}
