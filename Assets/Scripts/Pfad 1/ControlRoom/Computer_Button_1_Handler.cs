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

    public GameObject ComputerScreen_1Button;
    public GameObject ComputerScreen_1_2Button;
    public GameObject ComputerScreen_2Button;
    public GameObject ComputerScreen_3Button;
    public GameObject ComputerScreen_4Button;
    public GameObject ComputerScreen_5Button;
    public GameObject ComputerScreen_6Button;
    public GameObject DoorOpener;
    public GameObject ControlRoom;
    public GameObject Monitor_1_1;
    //public GameObject Monitor_1_2;
    public GameObject ControllRoomBackground;
    public GameObject FinalComputer;
    public GameObject FinalComputerBig;
    public GameObject FinalEquation;

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

    public AudioSource Backgroundmusic;

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
    public GameObject TasseButton;
    public GameObject PostItButton;
    public GameObject Cube;
    public GameObject ZettelGross;

    public GameObject InstructionBig;

    public Settings SettingScript;

    public GameObject TransitionIn;
    public float TransitionTime;
    public GameObject TransitionOut;


    

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
        StartCoroutine(ClickDemoStartTransition());
    }

    public IEnumerator ClickDemoStartTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        Intro.SetActive(false);
        IntroVideoPlayer.Stop();
        Inventar.SetActive(true);
        ControlRoom.SetActive(true);

        Backgroundmusic.Play();

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ComputerScreen_1Click () {

        StartCoroutine(ComputerScreen_1ClickTransition());

    }
    public IEnumerator ComputerScreen_1ClickTransition () {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TransitionOut.SetActive(true);
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

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }

    public void ComputerScreen_2Click () {
        StartCoroutine(ComputerScreen_2ClickTransition());
    }

    public IEnumerator ComputerScreen_2ClickTransition() {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ComputerScreen_3Click () {
        StartCoroutine(ComputerScreen_3ClickTransition());
    }


    
    public IEnumerator ComputerScreen_3ClickTransition() {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }

    
    public void ComputerScreen_4Click () {
        StartCoroutine(ComputerScreen_4ClickTransition());
    }

    public IEnumerator ComputerScreen_4ClickTransition() {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }

    public void ComputerScreen_5Click () {
        StartCoroutine(ComputerScreen_5ClickTransition());
    }

    public IEnumerator ComputerScreen_5ClickTransition() {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }

    public void ComputerScreen_6Click () {
        StartCoroutine(ComputerScreen_6ClickTransition());
    }

     public IEnumerator ComputerScreen_6ClickTransition() {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

     }

    

    public void FinalComputerScreenClick(){
        
        StartCoroutine(FinalComputerScreenClickTransition());
    }

    public IEnumerator FinalComputerScreenClickTransition() {

        PostIt.SetActive(false);
        ComputerScreen_1Button.SetActive(false);
        ComputerScreen_2Button.SetActive(false);
        ComputerScreen_3Button.SetActive(false);
        ComputerScreen_4Button.SetActive(false);
        ComputerScreen_5Button.SetActive(false);
        ComputerScreen_6Button.SetActive(false);
        InventoryDown.selected = true;

        FinalComputer.SetActive(false);
        TasseButton.SetActive(false);
        Cube.SetActive(false);

        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ControllRoomBackground.SetActive (false);
        FinalComputerBig.SetActive(true);
        SettingScript.HintNumber = 6;

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }


    public void FinalTimeStop()
    {
        StartCoroutine(FinalTimeStopTransition());

    }

    public IEnumerator FinalTimeStopTransition()
    {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);



        FinalComputerBig.SetActive(false);
        
        FinalEquation.SetActive(true);
        SettingScript.HintNumber = 7;
        OutroVideoPlayer.Prepare();

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);


    }

    public void DoorOpener_Click () {
        StartCoroutine(DoorOpener_ClickTransition());
    }

    public IEnumerator DoorOpener_ClickTransition(){

        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }

    public void BackButton () {
        StartCoroutine(BackButtonTransition());
    }

    public IEnumerator BackButtonTransition() {
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

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
        InstructionBig.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);


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
        StartCoroutine(ToJunkRoomTransition());
        
    }

    public IEnumerator ToJunkRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ControlRoom.SetActive (false);
        JunkRoom.SetActive (true);
        PostIt.SetActive (false);
        InventoryDown.selected = true;

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);

    }
    public void PostItClick () {
        StartCoroutine(PostItClickTransition());
    }
    public IEnumerator PostItClickTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ControlRoom.SetActive (false);
        PostIt.SetActive (true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void TasseClick(){
        StartCoroutine(TasseClickTransition());
    }

    public IEnumerator TasseClickTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ControlRoom.SetActive(false);
        TasseGross.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public void ToPyramidRoom () {
        StartCoroutine(ToPyramidRoomTransition());
        
    }

    public IEnumerator ToPyramidRoomTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        DoorSound.Play();
        ControlRoom.SetActive (false);
        PyramidRoom.SetActive (true);
        PyramidRoomEmpty.SetActive(true);
        InventoryDown.selected = true;


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
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
          Backgroundmusic.Play();
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
          StartCoroutine(ToZettelTransition());
      }
      public IEnumerator ToZettelTransition(){

          TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        TasseGross.SetActive(false);
          ZettelGross.SetActive(true);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
      }

      public void BackToTasse()
      {
          StartCoroutine(BackToTasseTransition());
      }

      public IEnumerator BackToTasseTransition(){
          TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        ZettelGross.SetActive(false);
          TasseGross.SetActive(true);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
      }

      public void InstructionClick(){
          StartCoroutine(InstructionClickTransition());
      }
      public IEnumerator InstructionClickTransition(){
          TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InstructionBig.SetActive(true);
          ControlRoom.SetActive(false);


        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
      }
}