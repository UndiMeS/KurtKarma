using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupNote : MonoBehaviour
{

    public bool selected;
    public bool MoveHint;
    public Vector2 cursorStartPos;

    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if(this.gameObject.transform.position.y <= -0.31f)
            {
                transform.position = new Vector3(this.transform.position.x, -0.3f,-1.0f);
            }
        

        if(Input.GetMouseButtonUp(0)){
            selected = false;
        }


        if(selected == true)
        {

            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 cursorMovePos = cursorPos - cursorStartPos;

            float clampedY = Mathf.Clamp( cursorMovePos.y, minY, maxY);


            transform.position = new Vector3(this.transform.position.x, clampedY, -1.0f);


            
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
                cursorStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                selected = true;
                
        }

        
    }
}
