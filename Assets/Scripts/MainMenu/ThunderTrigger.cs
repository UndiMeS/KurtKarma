using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderTrigger : MonoBehaviour
{

    public Animator KurtKarma;
    public Animator ThunderOne;
    public Animator ThunderTwo;
    public Animator XBert;
    public AudioSource thunder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

        void OnMouseDown()
    {
        KurtKarma.SetTrigger("light");
        ThunderOne.SetTrigger("light");
        ThunderTwo.SetTrigger("light");
        XBert.SetTrigger("light");
        //thunder.Play();

        
    }
}
