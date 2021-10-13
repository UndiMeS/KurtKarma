using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySolution : MonoBehaviour
{
   public bool ChestColliderEnter;
    public bool ChestColliderExit;
    public GameObject OpenChest;
    public GameObject ClosedChest;
    public AudioSource KeySound;
    public GameObject Key;
    public GameObject KeyFinalParent;

    public bool KeyInPlace = false;
    // Start is called before the first frame update
    void Start () { 
        OpenChest.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (ChestColliderEnter == true && Key.GetComponent<ClickOnKey> ().selected == false) {
            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().ItemListStart = false;
            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().ItemListStart = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().ItemListStart = false;

            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().ItemListStartOne = false;
            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().ItemListStartOne = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().ItemListStartOne = false;

            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().ItemListStartTwo = false;
            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().ItemListStartTwo = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().ItemListStartTwo = false;

            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().ItemListStartThree = false;
            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().ItemListStartThree = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().ItemListStartThree = false;

            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().fullOne = false;
            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().fullTwo = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().fullThree = false;

            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().fullOne = false;
            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().fullTwo = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().fullTwo = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().fullOne = false;
            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().fullThree = false;
            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().fullThree = false;

            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().DragItemOne = false;
            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().DragItemTwo = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().DragItemOne = false;
            GameObject.Find("ItemPlace_3").GetComponent<ItemPlace>().DragItemTwo = false;
            GameObject.Find("ItemPlace_1").GetComponent<ItemPlace>().DragItemThree = false;
            GameObject.Find("ItemPlace_2").GetComponent<ItemPlace>().DragItemThree = false;

            Key.GetComponent<ClickOnKey> ().DragOne = false;
            Key.GetComponent<ClickOnKey> ().DragTwo = false;
            Key.GetComponent<ClickOnKey> ().DragThree = false;
            Key.transform.position = this.transform.position;
            Key.transform.localScale = new Vector3 (0.7f, 0.7f, 0);
            // Key.GetComponent<ClickOnKey> ().DragOne = false;
            // Key.GetComponent<ClickOnKey> ().DragTwo = false;
            Key.transform.parent = KeyFinalParent.transform;

            Destroy(Key.gameObject);
            KeyInPlace = true;

            OpenChest.SetActive(true);
            KeySound.Play();
            ClosedChest.SetActive(false);
            
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.name == "Schlüssel") {
            ChestColliderEnter = true;
            ChestColliderExit = false;
        }
    }

    void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject.name == "Schlüssel") {
            ChestColliderEnter = false;
            ChestColliderExit = true;
        }
    }
}
