using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarCubeClick : MonoBehaviour
{

    public AltarCubeClick OtherSideClicked;
    public Animator FinalCubeAnimation;
    public bool Clicked;
    public bool Spin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver () {

        if (Input.GetMouseButtonDown (0)) {

            if(FinalCubeAnimation != null)
        FinalCubeAnimation.SetBool("StopAnimation", false);
            
            
            Clicked = false;
            OtherSideClicked.Clicked = true;
            Spin = true;

        }
    }
}
