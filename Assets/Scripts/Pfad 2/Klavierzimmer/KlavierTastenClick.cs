using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlavierTastenClick : MonoBehaviour
{

    public AudioSource audio1;

    public bool selected;

    public long TastenNummer;

    public TastenPasswort PasswortAnalyse;
    // Start is called before the first frame update
    void Start()
    {
        audio1 = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {
            
            audio1.Play ();
            selected = true;
            PasswortAnalyse.Passwort = PasswortAnalyse.Passwort + TastenNummer;

        }
    }
}
