using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoHandler : MonoBehaviour
{

    public GameObject Intro;
    public GameObject Outro;
    public GameObject FirstRoom;
    public GameObject Inventar;

    public VideoPlayer IntroVideoPlayer;
    public VideoPlayer OutroVideoPlayer;
    public string urlIntro;
    public string urlOutro;
    public GameObject IntroButton;
    public GameObject SkipButton;
    public AltarSolution AltarScript;
    public GameObject FinalScreen;
    public bool OutroBool;
    public GameObject Altar;
    public GameObject AltarRiddle;

    public AudioSource Backgroundmusic;

    public Timer TimerScript;
    // Start is called before the first frame update
    void Start()
    {
        if (string.IsNullOrEmpty(urlIntro))
        {
            urlIntro = System.IO.Path.Combine(Application.streamingAssetsPath, "Das_weiße_Tor_Besser.m4v");
        }

        if (string.IsNullOrEmpty(urlOutro))
            {
                urlOutro = System.IO.Path.Combine(Application.streamingAssetsPath, "Weiße_Tor_Outro_Besser.m4v");
            }
            OutroVideoPlayer.url = urlOutro;

            OutroVideoPlayer.Prepare();
 
        IntroVideoPlayer.url = urlIntro;
        //IntroVideoPlayer.SetTargetAudioSource(0, audioSource);

        IntroVideoPlayer.Prepare();

        

        IntroVideoPlayer.loopPointReached += EndReached;

        
    }

    // Update is called once per frame
    void Update()
    {

        // if(AltarScript.Win == true && OutroBool == false)
        // {
        //     StartCoroutine(WaitForOutro());
        // }
        
    }

    public void ClickIntro(){
        StartCoroutine(IntroClick());
    }

    public void ClickDemoStart(){
        Intro.SetActive(false);
        IntroVideoPlayer.Stop();
        Inventar.SetActive(true);
        FirstRoom.SetActive(true);
        Backgroundmusic.Play();
    }

    IEnumerator IntroClick(){
        IntroButton.SetActive(false);
        SkipButton.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton.SetActive(false);
        IntroButton.SetActive(true);
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
      {
          Intro.SetActive(false);
          Inventar.SetActive(true);
          FirstRoom.SetActive(true);
          Backgroundmusic.Play();
        //   WhiteNoiseOne.Prepare();
        //   WhiteNoiseTwo.Prepare();
      }

      void OutroEndReached(UnityEngine.Video.VideoPlayer vp)
      {
          Outro.SetActive(false);
          FinalScreen.SetActive(true);
      }
      public IEnumerator WaitForOutro()
      {
            yield return new WaitForSeconds(1.5f);
            Backgroundmusic.Stop();
            Altar.SetActive(false);
            AltarRiddle.SetActive(false);
            Outro.SetActive(true);
            Inventar.SetActive(false);
            
    
            
            //IntroVideoPlayer.SetTargetAudioSource(0, audioSource);

            
            OutroVideoPlayer.Play();

            Backgroundmusic.Stop();

            OutroVideoPlayer.loopPointReached += OutroEndReached;
            OutroBool = true;
      }

      public void OutroButton()
    {
        if(AltarScript.Win == true && OutroBool == false)
        {
            
            
            TimerScript.StopTime();
            
            //IntroVideoPlayer.SetTargetAudioSource(0, audioSource);

            Backgroundmusic.Stop();
            
            OutroVideoPlayer.Play();
            Outro.SetActive(true);

            OutroVideoPlayer.loopPointReached += OutroEndReached;
            OutroBool = true;

            Altar.SetActive(false);
            AltarRiddle.SetActive(false);
            
            Inventar.SetActive(false);
        }
    }
}
