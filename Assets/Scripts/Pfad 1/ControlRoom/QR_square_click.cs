using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QR_square_click : MonoBehaviour
{

    private SpriteRenderer sprite;
    public bool isClicked = true;
    public bool WrongClick;
    public bool NotFinishedAdd;
    public bool notinsolution = false;
    public int ClickedCount;
    // Start is called before the first frame update
    void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>();
        ClickedCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked == true)
        {
            sprite.color = Color.black;
        }
        else
        {
            sprite.color = Color.white;
        }
    }

    void OnMouseDown()
    {

        if (EventSystem.current.IsPointerOverGameObject())
         return;
        

        isClicked = !isClicked;

        if(ClickedCount == 0)
        {
            ClickedCount = 1;
        }

        if(ClickedCount == 1)
        {
            ClickedCount = 0;
        }


    }
}
