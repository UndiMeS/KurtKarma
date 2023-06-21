using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleLeftDetection : MonoBehaviour
{

    public bool BallColliderEnter;
    public bool BallColliderExit;
    public GameObject KeyBallSnapping;
    DragAndDrop KeyballSelected;

    public GameObject pole;
    public GameObject ScaleSnapping;
    public GameObject KeyBall;
    public float speed = 1.0f;
    static float Zrotation;
    // Start is called before the first frame update
    void Start()
    {
        Zrotation = pole.transform.rotation.eulerAngles.z;
        KeyballSelected = KeyBall.GetComponent<DragAndDrop>();
    }

    // Update is called once per frame
    void LateUpdate()
    {


        if(BallColliderEnter == true && KeyballSelected.selected == false)
        {
            KeyBall.transform.position = new Vector3(ScaleSnapping.transform.position.x, ScaleSnapping.transform.position.y, -1);

            // if(KeyBall.transform.position.x == ScaleSnapping.transform.position.x && KeyBall.transform.position.y == ScaleSnapping.transform.position.y)
            // {

                pole.transform.rotation = Quaternion.Slerp(pole.transform.rotation, Quaternion.Euler(pole.transform.rotation.x, pole.transform.rotation.y, Zrotation + 15.0f), Time.deltaTime * speed);
                Debug.Log("sollte rotieren");
            
            //}
        }

        

        if(BallColliderEnter == false && KeyballSelected.selected == false)
        {
            //KeyBall.transform.position = new Vector3(KeyBallSnapping.transform.position.x, KeyBallSnapping.transform.position.y, 1);
        }

        
        

        if(BallColliderExit == true)
        {
            pole.transform.rotation = Quaternion.Slerp(pole.transform.rotation, Quaternion.Euler(pole.transform.rotation.x, pole.transform.rotation.y, Zrotation), Time.deltaTime * speed);
            
            // if(KeyballSelected.selected == false)
            // {
            //     KeyBall.transform.position = KeyBallSnapping.transform.position;
            // }
        }
    }



void OnTriggerEnter2D(Collider2D collision)
{
    if(collision.gameObject.name =="KeyBall")
    {
        Debug.Log("collision");
        
        BallColliderEnter = true;
        BallColliderExit = false;
    }
}

void OnTriggerStay2D(Collider2D collision)
{
    if(collision.gameObject.name =="KeyBall")
    {
        Debug.Log("collision");
        
        BallColliderEnter = true;
        BallColliderExit = false;
    }
}

void OnTriggerExit2D(Collider2D collision)
{
    if(collision.gameObject.name =="KeyBall")
    {

        
        Debug.Log("collision exit");
        BallColliderExit = true;
        BallColliderEnter = false;
    }
}

IEnumerator wait()
{
    yield return new WaitForSeconds(1.0f);
}

}
