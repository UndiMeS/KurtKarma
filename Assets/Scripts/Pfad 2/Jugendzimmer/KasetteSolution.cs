using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KasetteSolution : MonoBehaviour
{
     public bool KasetteColliderEnter;
    public bool KasetteColliderExit;

    public AudioSource EinlegenSound;
    //public GameObject TetrixScreen;
    public GameObject RecorderFull;
    public GameObject RecorderEmpty;

    public GameObject RadioSmallEmpty;
    //public GameObject RadioSmallFull;

    public GameObject Kasette;
    public GameObject KasetteFinalParent;

    public GameObject RadioButton;
    public GameObject RadioButtonFull;

    public GameObject ItemPlaceOne;
    public GameObject ItemPlaceTwo;

    public Sprite RadioSmallFull;
    // Start is called before the first frame update
    void Start () { 
        RecorderFull.SetActive(false);
        EinlegenSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (KasetteColliderEnter == true && Kasette.GetComponent<ClickOnItem> ().selected == false) {


            if(this.gameObject.transform.parent.gameObject.name == "Radio")
            {
                RecorderEmpty.SetActive(false);
                RecorderFull.SetActive(true);
            }

           
                RadioSmallEmpty.GetComponent<SpriteRenderer>().sprite = RadioSmallFull;
                //RadioSmallFull.SetActive(true);
            

            if(this.gameObject.transform.parent.gameObject.name == "TeenageRoomEmpty")
            {
                
            }


            EinlegenSound.Play();
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
            Kasette.GetComponent<ClickOnItem> ().DragOne = false;
            Kasette.GetComponent<ClickOnItem> ().DragTwo = false;
            Kasette.transform.parent = KasetteFinalParent.transform;

            Destroy(Kasette.gameObject);

            RadioButton.SetActive(false);
            RadioButtonFull.SetActive(true);

            




            
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
        Debug.Log("collidet");
        if (col.gameObject.name == "Kasette im Tresor") {
            KasetteColliderEnter = true;
            KasetteColliderExit = false;
        }
    }

    void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject.name == "Kasette im Tresor") {
            KasetteColliderEnter = false;
            KasetteColliderExit = true;
        }
    }
}
