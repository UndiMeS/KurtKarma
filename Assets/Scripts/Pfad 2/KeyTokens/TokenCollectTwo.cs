using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCollectTwo : MonoBehaviour
{
    public GameObject BigToken;
    public GameObject InventoryToken;

    


    public GameObject InventoryArrowUp;

 

    public bool Collected = false;
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
            BigToken.SetActive(false);
            InventoryToken.SetActive(true);
            InventoryArrowUp.GetComponent<InventarArrow>().selected = true;
            Collected = true;


        }

    }
}

