using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPaperEdge : MonoBehaviour
{
    public Sprite UnfoldPaperEdge;
    public SpriteRenderer PoemPaper;
    // Start is called before the first frame update
    void Start()
    {
        PoemPaper = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        PoemPaper.sprite = UnfoldPaperEdge;
        Destroy(this.gameObject.GetComponent<BoxCollider2D>());
    }
}
