using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PolybiusAnalyse : MonoBehaviour
{

    public List<int> codeArray;
    public int temp;
    public bool correct;
    public GameObject DK;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // S
        if(codeArray.Count >= 6)
            if(correct == false)
            {
                //
                    //
                    for(int i = 0; i <= codeArray.Count - 6; i++)
                    {
                        if(codeArray[i] == 2 && codeArray[i+1] == 2 && codeArray[i+2] == 3 && codeArray[i+3] == 2 && codeArray[i+4] == 1 && codeArray[i+5] == 3
                        || codeArray[i] == 3 && codeArray[i+1] == 2 && codeArray[i+2] == 2 && codeArray[i+3] == 3 && codeArray[i+4] == 2 && codeArray[i+5] == 1 
                        || codeArray[i] == 1 && codeArray[i+1] == 3 && codeArray[i+2] == 2 && codeArray[i+3] == 2 && codeArray[i+4] == 3 && codeArray[i+5] == 2
                        || codeArray[i] == 2 && codeArray[i+1] == 1 && codeArray[i+2] == 3 && codeArray[i+3] == 2 && codeArray[i+4] == 2 && codeArray[i+5] == 3
                        || codeArray[i] == 3 && codeArray[i+1] == 2 && codeArray[i+2] == 1 && codeArray[i+3] == 3 && codeArray[i+4] == 2 && codeArray[i+5] == 2
                        || codeArray[i] == 2 && codeArray[i+1] == 3 && codeArray[i+2] == 2 && codeArray[i+3] == 1 && codeArray[i+4] == 3 && codeArray[i+5] == 2 )
                        {
                            correct = true;
                            DK.SetActive(true);
                        }
                    }
                //}
                //codeArray[0] = temp;

                
            }
            
        //}
        else if( codeArray.Count == 7)
        {
            //codeArray.Clear();
        }
    }
}
