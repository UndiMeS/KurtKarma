﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SolutionNumberLine : MonoBehaviour
{
   
    public bool BallColliderEnter = false;
    public bool BallColliderExit = false;

    public GameObject RedFrame;
    public GameObject GreenFrame;

    public bool Solution;

    public GameObject SolutionLine;

    public GameObject Outro;

    public VideoPlayer OutroVideo;
    public string urlOutro;
    public GameObject ControlRoom;
    public GameObject Inventar;

    //public AudioSource RichtigSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(BallColliderEnter == true && SolutionLine.GetComponent<NumberLineDrag>().selected == false)
       {
           SolutionLine.transform.localPosition = this.transform.localPosition;
           Solution = true;
           RedFrame.SetActive(false);
           GreenFrame.SetActive(true);
           //RichtigSound.Play();
           StartCoroutine(OutroStart());
       }
    }

    void OnTriggerEnter2D(Collider2D collision)
{
    if(collision.gameObject == SolutionLine)
    {
        //Debug.Log("collision");
        
        BallColliderEnter = true;
        BallColliderExit = false;

        //BallCollider.enabled = false;
        //BallCollider.enabled = true;
    }
}

void OnTriggerStay2D(Collider2D collision)
{
    if(collision.gameObject == SolutionLine)
    {
        //Debug.Log("collision");
        
        BallColliderEnter = true;
        BallColliderExit = false;
    }
}

void OnTriggerExit2D(Collider2D collision)
{
    if(collision.gameObject == SolutionLine)
    {

        //Debug.Log("collision exit");
        BallColliderExit = true;
        BallColliderEnter = false;
    }
}

IEnumerator OutroStart()
{
    yield return new WaitForSeconds(2);
    Inventar.SetActive(false);
    

    if (string.IsNullOrEmpty(urlOutro))
    {
        urlOutro = System.IO.Path.Combine(Application.streamingAssetsPath, "Outrp.m4v");
    }

    OutroVideo.url = urlOutro;


    OutroVideo.Prepare();
    Outro.SetActive(true);
    ControlRoom.SetActive(false);
    OutroVideo.Play();
}
}
