using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickNoChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GameObject QRtile = GameObject.Find("QR_square");
        // QR_square_click qrScript = QRtile.GetComponent<QR_square_click>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameObject QRtile = GameObject.Find("QR_square");
        QR_square_click qrScript = QRtile.GetComponent<QR_square_click>();

        qrScript.isClicked = false;


    }
}
