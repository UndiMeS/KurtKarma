using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHands : MonoBehaviour
{
    public bool MouseActive;
    public GameObject TurningClockHand;

    private Vector3 screenPos;
    private Camera myCam;
    private float angleOffset;
    // Start is called before the first frame update
    void Start()
    {
        myCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) {
                if (MouseActive == true) {
                    screenPos = myCam.WorldToScreenPoint (transform.position);
                    Vector3 v3 = Input.mousePosition - screenPos;
                    angleOffset = (Mathf.Atan2 (transform.right.y, transform.right.x) - Mathf.Atan2 (v3.y, v3.x)) * Mathf.Rad2Deg;
                }
            }
            //This fires while the button is pressed down
            if (Input.GetMouseButton (0)) {
                if (MouseActive == true) {
                    Vector3 v3 = Input.mousePosition - screenPos;
                    float angle = Mathf.Atan2 (v3.y, v3.x) * Mathf.Rad2Deg;
                    TurningClockHand.transform.eulerAngles = new Vector3 (0, 0, angle + angleOffset);
                    // GearOne.transform.eulerAngles = transform.eulerAngles;
                    // GearTwo.transform.eulerAngles = -transform.eulerAngles;
                    // GearThree.transform.eulerAngles = transform.eulerAngles;

                }
            }
    }

    void OnMouseDown () {
        MouseActive = true;
    }

    void OnMouseUp () {
        MouseActive = false;
    }
}
