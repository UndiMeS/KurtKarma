﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintList : MonoBehaviour
{
    public TMP_Text List;
    public bool ShowListOnce;
    // Start is called before the first frame update
    void Start()
    {
        //List = this.gameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void ListOfHints()
    {
        if(ShowListOnce == false)
        {
                foreach(float hint in Settings.Hints)
            {
                List.text = List.text + hint + " wurde benutzt\n";
            }
            ShowListOnce = true;
        }
        
    }
}
