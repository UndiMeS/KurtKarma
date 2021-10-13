using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberLineDrag : MonoBehaviour
{

    public bool selected;
    public Vector3 StartPosition;

    public SolutionNumberLine solution;


    // Start is called before the first frame update
    void Start()
    {
        StartPosition = this.gameObject.transform.localPosition;




    }

    // Update is called once per frame
    void Update()
    {
        if(selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

            transform.position = new Vector3 (cursorPos.x, cursorPos.y, 0);
        }


        if(solution != null)
        {
            if(selected == false && solution.Solution == false)
            {
                transform.localPosition = StartPosition;
            }
            
        }
        else
        {
            if(selected == false)
            {
                transform.localPosition = StartPosition;
            }
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            selected = true;
        }

        if(Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }
}
