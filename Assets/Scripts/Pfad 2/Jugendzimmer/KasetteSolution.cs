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
