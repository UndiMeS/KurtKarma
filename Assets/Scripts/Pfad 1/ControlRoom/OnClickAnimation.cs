using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickAnimation : MonoBehaviour
{
    public Animator ThreeSpin;
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
        ThreeSpin.SetTrigger("spin");
    }
}
