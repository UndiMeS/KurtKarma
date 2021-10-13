using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickHint : MonoBehaviour
{

    public float aValue;
    public float aTime;
    public float p;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime/aTime;
        float alpha = transform.GetComponent<Renderer>().material.color.a;
        p = Mathf.PingPong(t, aValue);

        Color newColor = new Color(1, 1, 1, p);
        transform.GetComponent<Renderer>().material.color = newColor;
        
        

        
    }

}
