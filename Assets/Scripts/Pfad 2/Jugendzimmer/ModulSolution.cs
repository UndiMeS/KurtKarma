using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModulSolution : MonoBehaviour
{
    public bool SNESColliderEnter;
    public bool SNESColliderExit;
    public GameObject TetrixScreen;
    public GameObject ModulInside;

    public GameObject Modul;
    public GameObject ModulFinalParent;

    public GameObject ItemPlaceOne;
    public GameObject ItemPlaceTwo;
    // Start is called before the first frame update
    void Start () { 
        ModulInside.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (SNESColliderEnter == true && Modul.GetComponent<ClickOnItem> ().selected == false) {
            ItemPlaceOne.GetComponent<ItemPlace>().ItemListStart = false;
            ItemPlaceTwo.GetComponent<ItemPlace>().ItemListStart = false;
            ItemPlaceOne.GetComponent<ItemPlace>().ItemListStartOne = false;
            ItemPlaceTwo.GetComponent<ItemPlace>().ItemListStartOne = false;
            ItemPlaceOne.GetComponent<ItemPlace>().ItemListStartTwo = false;
            ItemPlaceTwo.GetComponent<ItemPlace>().ItemListStartTwo = false;
            ItemPlaceOne.GetComponent<ItemPlace>().fullOne = false;
            ItemPlaceTwo.GetComponent<ItemPlace>().fullTwo = false;
            ItemPlaceTwo.GetComponent<ItemPlace>().fullOne = false;
            ItemPlaceOne.GetComponent<ItemPlace>().fullTwo = false;
            ItemPlaceTwo.GetComponent<ItemPlace>().DragItemOne = false;
            ItemPlaceOne.GetComponent<ItemPlace>().DragItemTwo = false;
            Modul.GetComponent<ClickOnItem> ().DragOne = false;
            Modul.GetComponent<ClickOnItem> ().DragTwo = false;
            Modul.transform.position = this.transform.position;
            Modul.transform.localScale = new Vector3 (0.7f, 0.7f, 0);
            // Key.GetComponent<ClickOnKey> ().DragOne = false;
            // Key.GetComponent<ClickOnKey> ().DragTwo = false;
            Modul.transform.parent = ModulFinalParent.transform;

            Destroy(Modul.gameObject);

            TetrixScreen.SetActive(true);
            ModulInside.SetActive(true);
            
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
        Debug.Log("collidet");
        if (col.gameObject.name == "SNES Modul") {
            SNESColliderEnter = true;
            SNESColliderExit = false;
        }
    }

    void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject.name == "SNES Modul") {
            SNESColliderEnter = false;
            SNESColliderExit = true;
        }
    }
}
