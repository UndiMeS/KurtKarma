using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretSolutionDetection : MonoBehaviour {

    public int PunktCount;
    public int StrichCount;
    public int BreadCount;
    public bool PunktSelected;
    public bool PointSelected;
    public bool StrichSelected;
    public bool BreadSelected;
    private MayaSymbolDrop SymbolDrop;
    public bool selected;
    private MayaCodePinBoard BreadDrop;
    public bool solutionOneRight = false;
    public bool solutionTwoRight = false;
    public bool solutionThreeRight = false;
    public bool PunktDestroy;
    public bool StrichDestroy;
    public bool BreadDestroy;

    public bool Hint;

    public GameObject DefaultPoint;
    public GameObject DefaultLine;
    public GameObject DefaultBread;

    // Start is called before the first frame update
    void Start () {
        Hint = true;
    }

    // Update is called once per frame
    void Update () {

        //BreadSelected = GameObject.Find("BreadSymbol").GetComponent<MayaSymbolDrop>().selected;

        PunktSelected = DefaultPoint.GetComponent<MayaCodePinBoard>().selected;
        StrichSelected = DefaultLine.GetComponent<MayaCodePinBoard>().selected;
        BreadSelected = DefaultBread.GetComponent<MayaCodePinBoard>().selected;

        if (this.gameObject.name == "SolutionOne") {
            if (PunktCount == 2 && StrichCount == 0 && BreadCount == 0 && PunktSelected == false) {
                Debug.Log ("Solution One is right");
                solutionOneRight = true;
            } else {
                solutionOneRight = false;
            }
        }

        if (this.gameObject.name == "SolutionTwo") {
            if (PunktCount == 1 && StrichCount == 3 && BreadCount == 0 && StrichSelected == false) {
                Debug.Log ("Solution Two is right");
                solutionTwoRight = true;
            } else {
                solutionTwoRight = false;
            }
        }

        // if (this.gameObject.name == "SolutionThree") {
        //     if (PunktCount == 0 && StrichCount == 0 && BreadCount == 1 && BreadSelected == false) {
        //         Debug.Log ("Solution Three is right");
        //         solutionThreeRight = true;
        //     } else {
        //         solutionThreeRight = false;
        //     }
        // }

    }

    void OnTriggerEnter2D (Collider2D col) {

        Hint = false;

        if (col.gameObject.name == "Punkt") {
            PunktCount++;
            //PunktSelected = col.gameObject.GetComponent<MayaSymbolDrop> ().selected;
        }
        if (PunktCount > 4) {
            if (col.gameObject.name == "Punkt") {

                PunktDestroy = true;

                //Destroy(col.gameObject);

            }

        } else {
            PunktDestroy = false;
        }

        if (col.gameObject.name == "Strich") {
            StrichCount++;
            //StrichSelected = col.gameObject.GetComponent<MayaSymbolDrop> ().selected;
        }
        if (StrichCount > 3) {
            if (col.gameObject.name == "Strich") {
                StrichDestroy = true;
                //Destroy(col.gameObject);
            }
        } else {
            StrichDestroy = false;
        }

        if (col.gameObject.name == "BreadSymbol") {
            BreadCount++;
            //BreadSelected = col.gameObject.GetComponent<MayaSymbolDrop>().selected;
        }
        if (BreadCount > 1) {
            if (col.gameObject.name == "BreadSymbol") {
                BreadDestroy = true;
                //Destroy(col.gameObject);
            }
        } else {
            BreadDestroy = false;
        }

    }

    void OnTriggerStay2D (Collider2D col) {

        if (col.gameObject.name == "Punkt") {
            PunktSelected = col.gameObject.GetComponent<MayaSymbolDrop> ().selected;
        }
       
        if (col.gameObject.name == "Strich") {

            StrichSelected = col.gameObject.GetComponent<MayaSymbolDrop> ().selected;
        }
       
       
        if (col.gameObject.name == "BreadSymbol") {

            BreadSelected = col.gameObject.GetComponent<MayaSymbolDrop>().selected;
        }

    }

    void OnTriggerExit2D (Collider2D col) {

        if (col.gameObject.name == "Punkt") {
            PunktCount--;
            PunktSelected = col.gameObject.GetComponent<MayaSymbolDrop> ().selected;
        }

        if (col.gameObject.name == "Strich") {
            StrichCount--;
            StrichSelected = col.gameObject.GetComponent<MayaSymbolDrop> ().selected;
        }

        if (col.gameObject.name == "BreadSymbol") {
            BreadCount--;
            BreadSelected = col.gameObject.GetComponent<MayaSymbolDrop> ().selected;
        }

    }

}