using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSound : MonoBehaviour
{
    public AudioSource Thunder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayThunder()
    {
        if(Thunder != null)
        Thunder.Play();
    }
}
