using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SolutionNumbers : MonoBehaviour {
    public float NumbersSolution;

    public float VariableSolution;

    public float Solution;

    public GameObject LevelOne;
    public GameObject LevelOneComplete;
    public int EatenNumberCounter;

    public bool spinOne = false;
    public bool spinTwo = false;
    public bool spinThree = false;

    public GameObject FinalScreen;

    public GameObject LevelTwo;

    public GameObject LevelThree;

    public GameObject Xbert;
    public float speed = 50.0f;

    public bool LevelOneFinished;
    public bool LevelTwoFinished;
    public bool LevelThreeFinished;

    public GameObject Particles;
    public bool PlayParticle = true;

    public float rotationSpeed = 50.0f;


    public GameObject Pause;

    Vector3 destination = new Vector3 (0, 0, 359);
    // Start is called before the first frame update
    void Start () {
        //Particles.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update () {

        if (VariableSolution != 0) {
            Solution = NumbersSolution / VariableSolution;
        }

        if (VariableSolution == 0 && NumbersSolution == 0) {
            GetComponent<TMP_Text> ().text = "L = Q";
        }
        if (VariableSolution == 0 && NumbersSolution != 0) {
            GetComponent<TMP_Text> ().text = "Leere Menge";
        }
        if (VariableSolution != 0 && NumbersSolution != 0) {
            GetComponent<TMP_Text> ().text = "L = " + Solution.ToString ();
        }
        if (VariableSolution != 0 && NumbersSolution == 0) {
            GetComponent<TMP_Text> ().text = "L = " + Solution.ToString ();
        }
        // if(Solution >= 10.0f && LevelOneFinished == false)
        // {
        //     LevelOne.SetActive(false);
        //     LevelOneComplete.SetActive(true);
        //     Solution = 0.0f;
        //     LevelOneFinished = true; 
        // }

        // if(LevelOneFinished == true && LevelTwoFinished == false && Solution < 0.0f)
        // {
        //     LevelOne.SetActive(false);
        //     LevelOneComplete.SetActive(true);
        //     Solution = 0.0f;
        //     LevelTwoFinished = true; 
        // }

        // if(LevelTwoFinished == true && Solution < -100.0f)
        // {
        //     LevelOne.SetActive(false);
        //     LevelOneComplete.SetActive(true);
        //     Solution = 0.0f;
        //     LevelThreeFinished = true; 
        // }


        StartCoroutine (WinningTime ());

    }

    public IEnumerator WinningTime () {

        if (Solution >= 10.0f && LevelOneFinished == false) {

            LevelOneFinished = true;

            yield return new WaitForSeconds (1.0f);

            Particles.transform.SetParent (null);

            if (PlayParticle) {
                Particles.GetComponent<ParticleSystem> ().Play ();
                PlayParticle = false;
            }

            yield return new WaitForSeconds (0.5f);

            Xbert.SetActive (false);

            Pause.GetComponent<PauseScript> ().CompleteOne = true;

            yield return new WaitForSeconds (1.0f);

            Xbert.transform.Rotate (Vector3.forward * 0);
            //Xbert.SetActive(true);

            LevelOne.SetActive (false);
            LevelOneComplete.SetActive (true);

            Solution = 0;

            spinOne = true;

            PlayParticle = true;

        }

        if (LevelOneFinished == true && LevelTwoFinished == false && Solution < 0.0f) {


            LevelTwoFinished = true;

            yield return new WaitForSeconds (1.0f);

            Particles.transform.SetParent (null);

            if (PlayParticle) {
                Particles.GetComponent<ParticleSystem> ().Play ();
                PlayParticle = false;
            }

            yield return new WaitForSeconds (0.5f);

            Xbert.SetActive (false);

            Pause.GetComponent<PauseScript> ().CompleteTwo = true;

            yield return new WaitForSeconds (1.0f);

            Xbert.transform.Rotate (Vector3.forward * 0);
            //Xbert.SetActive(true);

            LevelTwo.SetActive (false);
            LevelOneComplete.SetActive (true);

            spinTwo = true;

            PlayParticle = true;

            Solution =0;
            NumbersSolution = 0;
            VariableSolution = 0;


        }

        if (LevelTwoFinished == true && Solution < -100.0f) {

            LevelThreeFinished = true;

            yield return new WaitForSeconds (1.0f);

            Particles.transform.SetParent (null);

            if (PlayParticle) {
                Particles.GetComponent<ParticleSystem> ().Play ();
                PlayParticle = false;
            }

            yield return new WaitForSeconds (0.5f);

            Xbert.SetActive (false);

            Pause.GetComponent<PauseScript> ().CompleteThree = true;

            yield return new WaitForSeconds (1.0f);

            Xbert.transform.Rotate (Vector3.forward * 0);
            //Xbert.SetActive(true);

            LevelThree.SetActive (false);
            LevelOneComplete.SetActive (true);

            spinThree = true;
            PlayParticle = true;


        }

    }

}