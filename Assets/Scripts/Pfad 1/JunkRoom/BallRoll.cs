using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoll : MonoBehaviour
{

    public GameObject KeyBall;
    public bool selected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnMouseOver () {


        
            if (Input.GetMouseButtonDown (0)) {
                selected = true;

                KeyBall.GetComponent<DragAndDrop>().BallSnap = true;

                Destroy(this.gameObject);

            }
    }
}
