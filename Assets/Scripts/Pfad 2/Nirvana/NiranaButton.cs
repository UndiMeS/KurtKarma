using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiranaButton : MonoBehaviour
{

    public GameObject Nirvana;

    public GameObject GameScreen;
    public GameObject FinalScreen;

    public GameObject TeenageRoomButtons;
    public GameObject TeenageRoomEmpty;

    public GameObject CobainPoster;

    public GameObject NirvanaEmpty;
    public GameObject TeenageRoom;
    public GameObject SolutionInput;

    public GameObject OktaederBunt;
    public GameObject PrismaBunt;
    public GameObject TorusBunt;
    public GameObject IkosaederBunt;
    public Animator[] TokenSpins;
    public Animator NirvanaColorAnim;
    public GameObject NirvanaBunt;
    public GameObject WhiteTokens;
    public GameObject ColoredTokens;
    public GameObject BigIkosaeder;
    public GameObject WhiteNirvanaButtons;
    public InventarArrow InventoryDown;
    public bool SpinBool;

    public GameObject AltarDoor;

    public GameObject TransitionIn;
    public GameObject TransitionOut;
    public float TransitionTime;

    public Settings SettingsScript;
    public bool HintBool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ItemSpinAnimation());
        if(SpinBool == false)
        {
            
            SpinBool = true;
        }
        
    }
    public void ClickOnRoomPicture()
    {
        StartCoroutine(ToRoomPictureTransition());
    }

    public void ClickOnSolutionInput()
    {
        StartCoroutine(ToSolutionInputTransition());
    }

    public void BackToNirvana()
    {
        StartCoroutine(BackToNirvanaTransition());
        
    }

    public void FinalDoor()
    {
        StartCoroutine(FinalDoorTransition());
        
        //GameScreen.SetActive(false);
    }

    public IEnumerator ItemSpinAnimation()
    {


        if(OktaederBunt.activeSelf == true && PrismaBunt.activeSelf == true && TorusBunt.activeSelf == true && IkosaederBunt.activeSelf == true)
        {
            
                

            if(HintBool == false)
            {
                WhiteTokens.SetActive(false);
                
                yield return new WaitForSeconds(1.0f);
            
            foreach (Animator TokenSpin in TokenSpins)
            {
                TokenSpin.enabled = true;
                TokenSpin.SetBool("Spin", true);
                
            }
            NirvanaColorAnim.SetBool("NirvanaColor", true);

            WhiteNirvanaButtons.SetActive(false);
            
            NirvanaBunt.SetActive(true);




                SettingsScript.HintNumber = 7;
                HintBool = true;


                yield return new WaitForSeconds(3.5f);
                AltarDoor.SetActive(true);
            }

            
        }

        
        
    }


    public IEnumerator ToRoomPictureTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InventoryDown.selected = true;
        Nirvana.SetActive(false);
        CobainPoster.SetActive(false);
        TeenageRoom.SetActive(true);
        TeenageRoomEmpty.SetActive(true);
        TeenageRoomButtons.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator ToSolutionInputTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        NirvanaEmpty.SetActive(false);
        WhiteTokens.SetActive(false);
        ColoredTokens.SetActive(false);
        BigIkosaeder.SetActive(false);
        SolutionInput.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator BackToNirvanaTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        SolutionInput.SetActive(false);
        ColoredTokens.SetActive(true);
        WhiteTokens.SetActive(true);
        if(NirvanaBunt.activeSelf == false)
        {
            BigIkosaeder.SetActive(true);
        }
        
        NirvanaEmpty.SetActive(true);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }

    public IEnumerator FinalDoorTransition(){
        TransitionIn.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionIn.SetActive(false);

        InventoryDown.selected = true;
        FinalScreen.SetActive(true);
        Nirvana.SetActive(false);

        TransitionOut.SetActive(true);
        yield return new WaitForSeconds(TransitionTime);
        TransitionOut.SetActive(false);
    }
}
