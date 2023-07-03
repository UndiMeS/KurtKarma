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
    public AudioSource ModulSound;
    public bool modulsoundplay;

    public Settings SettingsScript;
    // Start is called before the first frame update
    void Start () { 
        ModulInside.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (SNESColliderEnter == true && Modul.GetComponent<ClickOnItem> ().selected == false) {
            ItemPlaceOne.GetComponent<ItemPlaceTwo>().ItemListStart = false;
            ItemPlaceTwo.GetComponent<ItemPlaceTwo>().ItemListStart = false;
            ItemPlaceOne.GetComponent<ItemPlaceTwo>().ItemListStartOne = false;
            ItemPlaceTwo.GetComponent<ItemPlaceTwo>().ItemListStartOne = false;
            ItemPlaceOne.GetComponent<ItemPlaceTwo>().ItemListStartTwo = false;
            ItemPlaceTwo.GetComponent<ItemPlaceTwo>().ItemListStartTwo = false;
            ItemPlaceOne.GetComponent<ItemPlaceTwo>().fullOne = false;
            ItemPlaceTwo.GetComponent<ItemPlaceTwo>().fullTwo = false;
            ItemPlaceTwo.GetComponent<ItemPlaceTwo>().fullOne = false;
            ItemPlaceOne.GetComponent<ItemPlaceTwo>().fullTwo = false;
            ItemPlaceTwo.GetComponent<ItemPlaceTwo>().DragItemOne = false;
            ItemPlaceOne.GetComponent<ItemPlaceTwo>().DragItemTwo = false;
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

            


            if(modulsoundplay == false)
            {
                ModulSound.Play();
                modulsoundplay = true;

                SettingsScript.HintNumber = 3;
            }
            
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
