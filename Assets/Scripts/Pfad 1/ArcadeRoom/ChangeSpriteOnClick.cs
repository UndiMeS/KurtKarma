using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteOnClick : MonoBehaviour
{

    public Sprite NewSprite;
    public Sprite OldSprite;
    public SpriteRenderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        Renderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    Renderer.sprite = NewSprite;
    }
    void OnMouseUp()
    {
        Renderer.sprite = OldSprite;
    }
}
