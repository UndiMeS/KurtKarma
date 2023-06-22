using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

    public bool selected;
    public bool selectedTest;

    BoxCollider2D Ball_collider;
    public GameObject KeyBallSnap;
    bool newValue;
    public bool BallSnap = false;
    public bool BallSnapToPosition = false;

    public float speed = 1.0f;
    public float step;
    public float RotationSpeed = 170.0f;

    // Start is called before the first frame update
    void Start () {

        BallSnap = false;
        BallSnapToPosition = false;

        //Ball_collider = this.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update () {

        GameObject LeftCollider = GameObject.Find ("SilberSchaale Links");

        ScaleLeftDetection LeftScript = LeftCollider.GetComponent<ScaleLeftDetection> ();

        GameObject RightCollider = GameObject.Find ("SilberSchaale Rechts");

        ScaleRightDetection RightScript = RightCollider.GetComponent<ScaleRightDetection> ();

        if (selected == true && BallSnap == true) {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

            transform.position = new Vector3 (cursorPos.x, cursorPos.y, 0);

            //Ball_collider.enabled = false;

        }

        if (BallSnap == true) {
            step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards (this.transform.position, new Vector3 (KeyBallSnap.transform.position.x, KeyBallSnap.transform.position.y, this.transform.position.z), step);

            if (BallSnapToPosition == false) {
                transform.Rotate (Vector3.forward * step * RotationSpeed);
            }

            if (this.transform.position == new Vector3 (KeyBallSnap.transform.position.x, KeyBallSnap.transform.position.y, this.transform.position.z)) {
                //selected = false;
                BallSnapToPosition = true;
                step = 0.0f;
            }
        }

        if (LeftScript.BallColliderEnter == false && RightScript.BallColliderEnter == false && selected == false && BallSnapToPosition == true) {

            this.transform.position = new Vector3 (KeyBallSnap.transform.position.x, KeyBallSnap.transform.position.y, -1);
        }

    }

    void OnMouseOver () {

        selectedTest = true;
        if (BallSnapToPosition == true) {
            if (Input.GetMouseButtonDown (0)) {
                selected = true;

            }

        }

        if (Input.GetMouseButtonUp (0)) {

            selected = false;
            selectedTest = false;

            //Ball_collider.enabled = true;

            //StartCoroutine(BallSnapping());

        }
    }

    // public void ClickAndRoll () {

    //     BallSnap = true;
    //     Destroy (GameObject.Find ("RollButton"));
    // }
}