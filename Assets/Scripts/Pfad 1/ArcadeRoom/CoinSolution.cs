using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSolution : MonoBehaviour
{
    public bool ChestColliderEnter;
    public bool ChestColliderExit;
    public GameObject XBertButton;
    public GameObject ErrorButton;
    public AudioSource CoinSound;
    public GameObject Coin;
    public GameObject CoinFinalParent;
    public GameObject CoinScreen;
    public GameObject SmallStartScreen;

    public bool CoinInPlace = false;
    // Start is called before the first frame update
    void Start () { 
        XBertButton.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (ChestColliderEnter == true && Coin.GetComponent<ClickOnKey> ().selected == false) {
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

            Coin.GetComponent<ClickOnKey> ().DragOne = false;
            Coin.GetComponent<ClickOnKey> ().DragTwo = false;
            Coin.GetComponent<ClickOnKey> ().DragThree = false;
            Coin.transform.position = this.transform.position;
            Coin.transform.localScale = new Vector3 (0.7f, 0.7f, 0);
            // Key.GetComponent<ClickOnKey> ().DragOne = false;
            // Key.GetComponent<ClickOnKey> ().DragTwo = false;
            Coin.transform.parent = CoinFinalParent.transform;

            Destroy(Coin.gameObject);
            CoinInPlace = true;

            XBertButton.SetActive(true);
            CoinSound.Play();
            ErrorButton.SetActive(false);
            CoinScreen.SetActive(false);
            SmallStartScreen.SetActive(true);
            
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.name == "Münze") {
            ChestColliderEnter = true;
            ChestColliderExit = false;
        }
    }

    void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject.name == "Münze") {
            ChestColliderEnter = false;
            ChestColliderExit = true;
        }
    }
}
