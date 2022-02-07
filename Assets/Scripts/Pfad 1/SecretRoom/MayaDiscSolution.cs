using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayaDiscSolution : MonoBehaviour {
    public bool DiscColliderEnter;
    public bool DiscColliderExit;
    public GameObject PyramidTokenBig;

    public GameObject MayaDisc;
    public GameObject MayaDiscFinalParent;
    public Sprite PyramidPictureEmpty;
    public SpriteRenderer PyramidPicture;

    public Sprite PyramidPictureSmallEmpty;
    public SpriteRenderer PyramidPictureSmall;

    public bool Collected;
    // Start is called before the first frame update
    void Start () { 
        PyramidTokenBig.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (DiscColliderEnter == true && MayaDisc.GetComponent<ClickOnKey> ().selected == false && MayaDisc != null) {
            MayaDisc.transform.position = this.transform.position;
            MayaDisc.transform.localScale = new Vector3 (0.7f, 0.7f, 0);
            //MayaDisc.GetComponent<ClickOnMayaDisc> ().Drag = false;
            MayaDisc.transform.parent = MayaDiscFinalParent.transform;

            Destroy(MayaDisc.GetComponent<ClickOnKey> ());

            if(Collected == false)
            {
                PyramidPicture.sprite = PyramidPictureEmpty;
                PyramidPictureSmall.sprite = PyramidPictureSmallEmpty;
                PyramidTokenBig.SetActive(true);
                Collected = true;
            }

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