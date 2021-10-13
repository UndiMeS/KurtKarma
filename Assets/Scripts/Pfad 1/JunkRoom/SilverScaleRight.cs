using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverScaleRight : MonoBehaviour
{
   public bool BallColliderEnter = false;
    public bool BallColliderExit = false;
    public GameObject pole;
    public GameObject ScaleSnapping;
    public GameObject KeyBall;
    public DragAndDrop KeyballSelected;
    public GameObject KeyBallSnapping;
    Collider2D BallCollider;
    public float speed = 1.0f;
    public float Zrotation;

    public GameObject InventoryDekaeder;
    // Start is called before the first frame update
    void Start()
    {
        //Zrotation = pole.transform.rotation.eulerAngles.z;
        Zrotation = 0.0f;
        KeyballSelected = KeyBall.GetComponent<DragAndDrop>();
        BallCollider = KeyBall.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {


        if(BallColliderEnter == true && KeyballSelected.selected == false )
        {
            KeyBall.transform.position = new Vector3(ScaleSnapping.transform.position.x, ScaleSnapping.transform.position.y, -1);

           
            

            // if(KeyBall.transform.position.x == ScaleSnapping.transform.position.x && KeyBall.transform.position.y == ScaleSnapping.transform.position.y)
            // {
                if(InventoryDekaeder.active == true)
                {
                    pole.transform.rotation = Quaternion.Slerp(pole.transform.rotation, Quaternion.Euler(pole.transform.rotation.x, pole.transform.rotation.y, Zrotation - 15), Time.deltaTime * speed);
                }
                
            //}

            //KeyBall.transform.position = KeyBall.transform.position;

            
        }

        if(BallColliderEnter == false && KeyballSelected.selected == false)
        {
            //KeyBall.transform.position = new Vector3(KeyBallSnapping.transform.position.x, KeyBallSnapping.transform.position.y, 1);
             if(InventoryDekaeder.active == true)
                {
                    pole.transform.rotation = Quaternion.Slerp(pole.transform.rotation, Quaternion.Euler(pole.transform.rotation.x, pole.transform.rotation.y, Zrotation), Time.deltaTime * speed);
                }
        }
        
       


        if(BallColliderExit == true || BallColliderEnter == true && KeyballSelected.selected == true)
        {
            //KeyBall.transform.position = KeyBall.transform.position;
            if(InventoryDekaeder.active == true)
            {
                pole.transform.rotation = Quaternion.Slerp(pole.transform.rotation, Quaternion.Euler(pole.transform.rotation.x, pole.transform.rotation.y, Zrotation), Time.deltaTime * speed);
            }
            //  if(KeyballSelected.selected == false)
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

        //BallCollider.enabled = false;
        //BallCollider.enabled = true;
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
