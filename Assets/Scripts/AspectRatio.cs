using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AspectRatio : MonoBehaviour
{

    public GameObject ScalingCanvas;
    private float screenAspect;


    // Start is called before the first frame update
    void Start()
    {
        screenAspect = Screen.width/Screen.height;


        if(ScalingCanvas != null)
        {
            if(screenAspect <= 16/9)
            {
                ScalingCanvas.GetComponent<CanvasScaler>().matchWidthOrHeight = 0;
            }
            else
            {
                ScalingCanvas.GetComponent<CanvasScaler>().matchWidthOrHeight = 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
