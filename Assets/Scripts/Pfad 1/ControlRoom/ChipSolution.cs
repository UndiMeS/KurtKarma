using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipSolution : MonoBehaviour
{

    public CircuitDragAndDrop[] Circuit;

    public GameObject CircuitOne;
    public GameObject CircuitTwo;
    public GameObject CircuitThree;

    public Sprite CircuitOneBackground;
    public Sprite CircuitTwoBackground;
    public Sprite CircuitThreeBackground;

    public GameObject ChipSlot_1_1;
    public GameObject ChipSlot_1_2;
    public GameObject ChipSlot_2_1;
    public GameObject ChipSlot_2_2;
    public GameObject ChipSlot_3_1;
    public GameObject ChipSlot_3_2;

    public GameObject CircuitOneSolution;
    public GameObject CircuitTwoSolution;
    public GameObject CircuitThreeSolution;

    public Sprite CircuitOneSolutionGreen;
    public Sprite CircuitTwoSolutionGreen;
    public Sprite CircuitThreeSolutionGreen;


    public Sprite ChipSlotLightGreen;
    public Sprite ChipSlotDarkGreen;

    public GameObject CircuitBackground;
    public Sprite CircuitBackgroundGreen;

    public bool CircuitOneRight;
    public bool CircuitTwoRight;
    public bool CircuitThreeRight;

    public GameObject CircuitScreenSmall;
    public Sprite CircuitScreenSmallGreen;

    public GameObject WhiteNoiseScreens;

    public GameObject[] ScreenButtons;

    public AudioSource Electricity;
    private bool Sound = true;

    public bool playAudioOne;
    public bool playAudioTwo;
    public bool playAudioThree;
    public int countAudio = 0;

    public AudioSource ShortTrue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Circuit[0].RightInPlace == true && Circuit[1].RightInPlace == true && Circuit[2].RightInPlace == true && Circuit[3].RightInPlace == true && Circuit[4].RightInPlace == true && Circuit[5].RightInPlace == true)
        {
            CircuitBackground.GetComponent<SpriteRenderer>().sprite = CircuitBackgroundGreen;
            CircuitScreenSmall.GetComponent<SpriteRenderer>().sprite = CircuitScreenSmallGreen;

            if(Sound == true)
            {
                Electricity.Play();
                Sound = false;
            }
            

            WhiteNoiseScreens.SetActive(false);

            for(int i = 0; i <=4; i++)
            {
                ScreenButtons[i].SetActive(true);
            }
        }


        if(Circuit[0].RightInPlace == true && Circuit[1].RightInPlace == true)
        {
            if(countAudio < 2)
            {
                
                if(playAudioOne == false)
                    {
                        countAudio = countAudio + 1;
                        ShortTrue.Play();
                        playAudioOne = true;
                    }
            }
            
            CircuitOne.GetComponent<SpriteRenderer>().sprite = CircuitOneBackground;

            ChipSlot_1_1.GetComponent<SpriteRenderer>().sprite = ChipSlotLightGreen;
            ChipSlot_1_2.GetComponent<SpriteRenderer>().sprite = ChipSlotDarkGreen;

            CircuitOneSolution.GetComponent<SpriteRenderer>().sprite = CircuitOneSolutionGreen;

            Circuit[0].Draggable = false;
            Circuit[1].Draggable = false;
        }

        if(Circuit[2].RightInPlace == true && Circuit[3].RightInPlace == true)
        {

            if(countAudio < 2)
            {
                
                if(playAudioTwo == false)
                {
                    countAudio = countAudio + 1;
                    ShortTrue.Play();
                    playAudioTwo = true;
                }
            }
            CircuitTwo.GetComponent<SpriteRenderer>().sprite = CircuitTwoBackground;

            ChipSlot_2_1.GetComponent<SpriteRenderer>().sprite = ChipSlotLightGreen;
            ChipSlot_2_2.GetComponent<SpriteRenderer>().sprite = ChipSlotDarkGreen;

            CircuitTwoSolution.GetComponent<SpriteRenderer>().sprite = CircuitTwoSolutionGreen;

            Circuit[2].Draggable = false;
            Circuit[3].Draggable = false;
        }

        if(Circuit[4].RightInPlace == true && Circuit[5].RightInPlace == true)
        {

            if(countAudio < 2)
            {
                
                if(playAudioThree == false)
                {
                    countAudio = countAudio + 1;
                    ShortTrue.Play();
                    playAudioThree = true;
                    
                }
            }

            

            CircuitThree.GetComponent<SpriteRenderer>().sprite = CircuitThreeBackground;

            ChipSlot_3_1.GetComponent<SpriteRenderer>().sprite = ChipSlotLightGreen;
            ChipSlot_3_2.GetComponent<SpriteRenderer>().sprite = ChipSlotDarkGreen;

            CircuitThreeSolution.GetComponent<SpriteRenderer>().sprite = CircuitThreeSolutionGreen;

            Circuit[4].Draggable = false;
            Circuit[5].Draggable = false;
        }

        
    }
}
