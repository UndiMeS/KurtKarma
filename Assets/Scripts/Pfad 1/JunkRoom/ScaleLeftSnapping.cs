using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleLeftSnapping : MonoBehaviour {
    public bool BallColliderEnter = false;
    public bool BallColliderExit = false;
    public GameObject pole;
    public GameObject ScaleSnapping;

    DragAndDrop KeyballSelected;

    public GameObject KeyBall;
    public float speed = 1.0f;
    public float Zrotation;
    // Start is called before the first frame update
    void Start () {
        Zrotation = pole.transform.rotation.eulerAngles.z;
        KeyballSelected = KeyBall.GetComponent<DragAndDrop> ();
    }

    // Update is called once per frame
    void Update () {
        if (BallColliderEnter == true && KeyballSelected.selected == false) {
            KeyBall.transform.position = new Vector3 (ScaleSnapping.transform.position.x, ScaleSnapping.transform.position.y, KeyBall.transform.position.z);

            //pole.transform.rotation = Quaternion.Slerp(pole.transform.rotation, Quaternion.Euler(pole.transform.rotation.x, pole.transform.rotation.y, Zrotation - 15), Time.deltaTime * speed);
        }

        if (BallColliderExit == true) {
            //pole.transform.rotation = Quaternion.Slerp(pole.transform.rotation, Quaternion.Euler(pole.transform.rotation.x, pole.transform.rotation.y, Zrotation), Time.deltaTime * speed);

        }
    }

    void OnTriggerEnter2D (Collider2D collision) {
        if (collision.gameObject.name == "KeyBall") {
            Debug.Log ("collision");

            BallColliderEnter = true;
            BallColliderExit = false;
        }
    }

    // void OnTriggerStay2D(Collider2D collision)
    // {
    //     if(collision.gameObject.name =="KeyBall")
    //     {
    //         Debug.Log("collision");

    //         BallColliderEnter = true;
    //         BallColliderExit = false;
    //     }
    // }

    void OnTriggerExit2D (Collider2D collision) {
        if (collision.gameObject.name == "KeyBall") {
            Debug.Log ("collision exit");
            BallColliderExit = true;
            BallColliderEnter = false;
        }
    }
}