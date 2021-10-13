using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenHandler : MonoBehaviour
{
    public GameObject TokenDekaeder;
    public GameObject TokenCylinder;
    public GameObject TokenCube;
    public GameObject TokenPyramid;

    public GameObject RedButton;
    public GameObject RedButtonShining;

    

    public bool OnlyOnce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TokenDekaeder.active == true && TokenCylinder.active == true && TokenCube.active == true && TokenPyramid.active == true && OnlyOnce == false)
        {
            RedButton.SetActive(false);
            RedButtonShining.SetActive(true);


            OnlyOnce = true;
        }
    }
}
