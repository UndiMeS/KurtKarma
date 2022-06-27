using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolybiusSecretCode : MonoBehaviour
{
    public int Number;
    public PolybiusAnalyse analyse;
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

        analyse.codeArray.Add(Number);

        // if(analyse.codeArray.Count >= 6)
        // {
            
        //     //analyse.codeArray[analyse.codeArray.Count -1] = Number;
        //     analyse.codeArray.Clear();
        //     analyse.codeArray.Add(Number);
            
        // }
        // else
        // {
        //     //analyse.codeArray.Clear();
        //     analyse.codeArray.Add(Number);
        // }
        
    }
}
