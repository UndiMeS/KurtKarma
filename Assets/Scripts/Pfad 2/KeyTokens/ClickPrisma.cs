using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPrisma : MonoBehaviour
{

    public GameObject CloseButton;
    public LevelManager LevelSkript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //LevelSkript.FadeMusicOut();
            
            CloseButton.SetActive(true);

        }

    }
}
