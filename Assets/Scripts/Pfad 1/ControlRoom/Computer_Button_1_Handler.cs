using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Computer_Button_1_Handler : MonoBehaviour {

    public GameObject ComputerScreen_1;
    public GameObject ComputerScreen_1_2;
    public GameObject ComputerScreen_2;
    public GameObject ComputerScreen_3;
    public GameObject ComputerScreen_4;
    public GameObject ComputerScreen_5;
    public GameObject ComputerScreen_6;
    public GameObject DoorOpener;
    public GameObject ControlRoom;
    public GameObject Monitor_1_1;
    //public GameObject Monitor_1_2;
    public GameObject ControllRoomBackground;
    public GameObject FinalComputer;
    public GameObject FinalComputerBig;

    public AudioSource DoorSound;


    public GameObject JunkRoom;
    public GameObject DoorToJunkRoom;
    public GameObject PyramidRoom;
    public GameObject PostIt;
    public GameObject GreenCodeDoor;
    public GameObject ClassRoom;
    public GameObject SecretRoom;
    public GameObject PyramidRoomEmpty;
    public GameObject ChestBottom;
    public GameObject AllTitles;

    public GameObject Intro;
    public GameObject IntroButton;
    public GameObject SkipButton;
    public VideoPlayer IntroVideoPlayer;
    public VideoPlayer OutroVideoPlayer;
    public GameObject Outro;
    public GameObject FinalScreen;
    public bool IntroCheck;

    // public VideoPlayer WhiteNoiseOne;
    // public VideoPlayer WhiteNoiseTwo;

    public GameObject Inventar;
    public GameObject InventoryArrowDown;

    public InventarArrow InventoryDown;


    public GameObject TitleOne;
    public GameObject TitleTwo;
    public GameObject TitleThree;

    public string urlIntro;
    public string urlOutro;
    // public string urlNoise1;
    // public string urlNoise2;

    public GameObject TasseGross;
    public GameObject ZettelGross;

    public Settings SettingScript;

    // Start is called before the first frame update
    void Start () {
        AllTitles.SetActive(true);
        Intro.SetActive(true);
        TitleOne.SetActive(false);
        TitleTwo.SetActive(false);
        TitleThree.SetActive(false);
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        TasseGross.SetActive(false);

        FinalComputer.SetActive(false);
        FinalComputerBig.SetActive(false);

        DoorOpener.SetActive (false);
        //Monitor_1_2.SetActive (false);
        JunkRoom.SetActive (false);
        DoorToJunkRoom.SetActive (false);
        PyramidRoom.SetActive (false);
        PostIt.SetActive (false);
        GreenCodeDoor.SetActive (false);
        ClassRoom.SetActive(false);
        SecretRoom.SetActive(false);
        ChestBottom.SetActive(false);
        Inventar.SetActive(false);

        InventoryDown = InventoryArrowDown.GetComponent<InventarArrow>();

        if (string.IsNullOrEmpty(urlIntro))
        {
            urlIntro = System.IO.Path.Combine(Application.streamingAssetsPath, "KurtKarma.m4v");
        }
 
        IntroVideoPlayer.url = urlIntro;
        //IntroVideoPlayer.SetTargetAudioSource(0, audioSource);

        IntroVideoPlayer.Prepare();



        
        //OutroVideoPlayer.Prepare();
        
        

        IntroVideoPlayer.loopPointReached += EndReached;
        OutroVideoPlayer.loopPointReached += OutroEndReached;

    }

    // Update is called once per frame
    void Update () {
        // if(IntroVideoPlayer.isPlaying == false && IntroCheck == false)
        // {
        //     Intro.SetActive(false);
        //     ControlRoom.SetActive(true);
        //     IntroCheck = true;
        // }
    }

    public void ClickIntro(){
        StartCoroutine(IntroClick());
    }

    public void ClickDemoStart(){
        Intro.SetActive(false);
        IntroVideoPlayer.Stop();
        Inventar.SetActive(true);
        ControlRoom.SetActive(true);


        // if (string.IsNullOrEmpty(urlNoise1))
        // {
        //     urlNoise1 = System.IO.Path.Combine(Application.streamingAssetsPath, "NoiseScreen1.1.mp4");
        // }
        // WhiteNoiseOne.url = urlNoise1;


        



        // if (string.IsNullOrEmpty(urlNoise2))
        // {
        //     urlNoise2 = System.IO.Path.Combine(Application.streamingAssetsPath, "NoiseScreen2.mp4");
        // }
        // WhiteNoiseTwo.url = urlNoise2;

        // WhiteNoiseOne.Prepare();
        // WhiteNoiseTwo.Prepare();
        //StartCoroutine(TitleScreen());
    }

    public void ComputerScreen_1Click () {

        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (true);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);

    }

    public void ComputerScreen_2Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (true);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_3Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (true);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_4Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (true);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_5Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (true);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ComputerScreen_6Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (true);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void FinalComputerScreenClick(){
        ControllRoomBackground.SetActive (false);
        FinalComputerBig.SetActive(true);
        SettingScript.HintNumber = 6;
        OutroVideoPlayer.Prepare();
    }

    public void DoorOpener_Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (true);
        PostIt.SetActive (false);
    }

    public void BackButton () {
        ControlRoom.SetActive (true);
        //Monitor_1_2.SetActive(false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        TasseGross.SetActive(false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void QRMonitor_Click () {
        ControlRoom.SetActive (false);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (true);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void QRBackButton () {
        ControlRoom.SetActive (true);
        Monitor_1_1.SetActive (false);
        //Monitor_1_2.SetActive (true);
        ComputerScreen_1.SetActive (false);
        ComputerScreen_1_2.SetActive (false);
        ComputerScreen_2.SetActive (false);
        ComputerScreen_3.SetActive (false);
        ComputerScreen_4.SetActive (false);
        ComputerScreen_5.SetActive (false);
        ComputerScreen_6.SetActive (false);
        DoorOpener.SetActive (false);
        PostIt.SetActive (false);
    }

    public void ToJunkRoom () {
        //DoorSound.Play();
        ControlRoom.SetActive (false);
        JunkRoom.SetActive (true);
        PostIt.SetActive (false);
        InventoryDown.selected = true;
        
    }
    public void PostItClick () {
        ControlRoom.SetActive (false);
        PostIt.SetActive (true);
    }

    public void TasseClick(){
        ControlRoom.SetActive(false);
        TasseGross.SetActive(true);
    }

    public void ToPyramidRoom () {
        DoorSound.Play();
        ControlRoom.SetActive (false);
        PyramidRoom.SetActive (true);
        PyramidRoomEmpty.SetActive(true);
        InventoryDown.selected = true;
        
    }

    IEnumerator TitleScreen(){
        TitleOne.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        TitleOne.SetActive(false);
        TitleTwo.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        TitleTwo.SetActive(false);
        TitleThree.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        TitleThree.SetActive(false);

        //ControllRoomDoorSound.playOnAwake = true;
        
        
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
          ControlRoom.SetActive(true);
        //   WhiteNoiseOne.Prepare();
        //   WhiteNoiseTwo.Prepare();
      }
    void OutroEndReached(UnityEngine.Video.VideoPlayer vp)
      {
          Outro.SetActive(false);
          FinalScreen.SetActive(true);
      }

      public void ToZettel()
      {
          TasseGross.SetActive(false);
          ZettelGross.SetActive(true);
      }

      public void BackToTasse()
      {
          ZettelGross.SetActive(false);
          TasseGross.SetActive(true);
      }
}