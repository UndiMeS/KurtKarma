using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCasette : MonoBehaviour
{

    public ClickOnItem CasetteSkript;
    public bool selected;
    public GameObject casetteSmall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(selected == true)
        {
            casetteSmall.gameObject.SetActive(false);
            Destroy(this);
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
            selected = true;
        }

    }
}
