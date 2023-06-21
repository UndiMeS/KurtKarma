using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayaDiscSolution : MonoBehaviour {
    public bool DiscColliderEnter;
    public bool DiscColliderExit;
    public GameObject FinalScreen;

    public GameObject MayaDisc;
    public GameObject MayaDiscFinalParent;
    // Start is called before the first frame update
    void Start () { 
        FinalScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (DiscColliderEnter == true && MayaDisc.GetComponent<ClickOnKey> ().selected == false) {
            MayaDisc.transform.position = this.transform.position;
            MayaDisc.transform.localScale = new Vector3 (0.7f, 0.7f, 0);
            //MayaDisc.GetComponent<ClickOnMayaDisc> ().Drag = false;
            MayaDisc.transform.parent = MayaDiscFinalParent.transform;

            FinalScreen.SetActive(true);
        }
    }

    void OnTriggerEnter2D (Collider2D col) {
        if (col.gameObject.name == "Maya Teller") {
            DiscColliderEnter = true;
            DiscColliderExit = false;
        }
    }

    void OnTriggerExit2D (Collider2D col) {
        if (col.gameObject.name == "Maya Teller") {
            DiscColliderEnter = false;
            DiscColliderExit = true;
        }
    }
}