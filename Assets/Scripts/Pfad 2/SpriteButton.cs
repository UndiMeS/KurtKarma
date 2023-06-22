using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour
{
    public bool pressed;
    public Sprite PressedSprite;
    public Sprite NotPressedSprite;
    // Start is called before the first frame update
    void Start()
    {
        //Sprite ButtonRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        Sprite ButtonSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
    //     
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = PressedSprite;
         pressed = true;
    }
    /// <summary>
    /// OnMouseUp is called when the user has released the mouse button.
    /// </summary>
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = NotPressedSprite;
        pressed = false;
    }
}
