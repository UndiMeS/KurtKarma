using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject TeenageRoom;
    public GameObject TetriX;

    public GameObject StartMenu;
    public GameObject WinningOne;
    public GameObject WinningTwo;
    public GameObject LevelOne;
    public GameObject LevelTwo;
    public GameObject LevelThree;
    public GameObject WinningScreenOne;
    public GameObject WinningScreenTwo;
    public GameObject LevelOneIntro;
    public GameObject LevelTwoIntro;
    public GameObject LevelThreeIntro;
    public GameObject controller;
    public GameObject PauseOne;
    public GameObject PauseTwo;
    public GameObject PauseThree;

    public GameObject LoosingScreenOne;
    public GameObject LoosingScreenTwo;
    public GameObject LoosingScreenThree;

    public GameObject LevelOneBrick;
    public GameObject LevelOneBrickWindow;

    public GameObject LevelTwoBrickOne;
    public GameObject LevelTwoBrickTwo;
    public GameObject levelTwoBrickWindowOne;
    public GameObject levelTwoBrickWindowTwo;
    public GameObject[] LevelTwoDefaultBrickLines;
    public GameObject LevelTwoNewBrickLines;
    public GameObject[] LevelTwoDefaultSolutions;
    public GameObject LevelTwoNewSolution;

    public GameObject LevelThreeBrickOne;
    public GameObject LevelThreeBrickTwo;
    public GameObject levelThreeBrickWindowOne;
    public GameObject levelThreeBrickWindowTwo;
    public GameObject[] LevelThreeDefaultBrickLines;
    public GameObject[] LevelThreeNewBrickLines;
    public GameObject[] LevelThreeDefaultSolutions;
    public GameObject[] LevelThreeNewSolutions;
    public GameObject[] LevelThreeNewBricks;
    public GameObject[] LevelThreeDefaultBricks;
    public GameObject LevelThreeDefaultTask;
    public GameObject[] LevelThreeNewTasks;

    public GameObject[] LevelThreeNewMovePositions;


    public Vector3[] LevelThreeSafedBrickPosition = new Vector3[7];
    public Vector3[] LevelThreeSafedMovePosition = new Vector3[6];

    public GameObject[] LevelThreeNewBrickWindowsOne;
    public GameObject[] LevelThreeNewBrickWindowsTwo;



    public GameObject MovePoint_1_1;
    public GameObject MovePoint_2_1;
    public GameObject MovePoint_2_2;
    public GameObject MovePoint_3_1;
    public GameObject MovePoint_3_2;

    public bool LostOne = false;
    public bool LostTwo = false;
    public bool LostThree = false;

    public bool WinOne=false;
    public bool WinTwo = false;
    public bool IntroOne = false;

    public bool WinScreenOne = false;
    public bool WinScreenTwo = false;

    public float ScreenTime;

    public bool OneFinished;
    public bool TwoFinished;
    public bool ThreeFinished;
    // Start is called before the first frame update
    void Start()
    {
        StartMenu.SetActive(true);
        LevelOneIntro.SetActive(false);
        LevelOne.SetActive(false);
        LevelTwo.SetActive(false);
        WinningScreenOne.SetActive(false);
        LevelTwoIntro.SetActive(false);
        LevelThreeIntro.SetActive(false);
        LevelThree.SetActive(false);
        WinningScreenTwo.SetActive(false);

        PauseOne.SetActive(false);



        StartCoroutine(StartOne());


    }

    // Update is called once per frame
    void Update()
    {



            StartCoroutine(StartOne());

        


            StartCoroutine(Lost());

            StartCoroutine(Win());
        
    }

    IEnumerator StartOne()
    {
                if(IntroOne == true)
        {
        LevelOneIntro.SetActive(true);
        yield return new WaitForSeconds(ScreenTime);
        LevelOneIntro.SetActive(false);
        LevelOne.SetActive(true);
        //PauseOne.SetActive(true);
        IntroOne = false;
        }
    }

    public void GameStart()
    {
        StartMenu.SetActive(false);
        IntroOne = true;


        LevelOneBrick.transform.localPosition = new Vector3(841.0f, 168.0f, 0.0f);

        


        for(int x = 0; x < LevelThreeNewBricks.Length; x++)
        {
            
            //LevelThreeDefaultBrickPositions[x].transform.position = LevelThreeDefaultBricks[x].transform.position;
            LevelThreeSafedBrickPosition[x] = LevelThreeNewBricks[x].transform.position;
        }

        for(int y = 0; y < LevelThreeNewMovePositions.Length; y++)
        {
            //LevelThreeDefaultMovePositions[y].transform.position = LevelThreeNewMovePositions[y].transform.position;
            LevelThreeSafedMovePosition[y] = LevelThreeNewMovePositions[y].transform.position;
        }
        

    }

    public void RestartOne()
    {
        LevelOneBrick.GetComponent<BrickMovement>().lost = false;
        LevelOneBrick.GetComponent<BrickMovement>().OnBottom = false;
        LevelOneBrick.GetComponent<BrickMovement>().Restart = true;


    

        StartMenu.SetActive(false);
        IntroOne = true;


        LevelOneBrickWindow.SetActive(true);

        LevelOneBrick.transform.localPosition = new Vector3(841.0f, 168.0f, 0.0f);
        //LevelOneBrick.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);

        LevelOneBrick.transform.localRotation = Quaternion.Euler(0,0,0);
        MovePoint_1_1.transform.position = LevelOneBrick.transform.position;
        MovePoint_1_1.transform.localRotation = Quaternion.Euler(0,0,0);

        PauseOne.SetActive(false);

        controller.SetActive(true);

        LostOne = false;



    }

    public void RestartTwo()
    {




        levelTwoBrickWindowOne.SetActive(true);
        levelTwoBrickWindowTwo.SetActive(true);

        LostTwo = false;

        foreach (GameObject BrickLine in LevelTwoDefaultBrickLines)
        {
            BrickLine.SetActive(true);
        }

        LevelTwoNewBrickLines.SetActive(false);

        foreach (GameObject Solution in LevelTwoDefaultSolutions)
        {
            Solution.SetActive(true);
        }

        LevelTwoNewSolution.SetActive(false);

        

        

        LevelTwoBrickOne.transform.localPosition = new Vector3(714.0f, 218.0f, 0.0f);
        LevelTwoBrickTwo.transform.localPosition = new Vector3(857.0f, 170.0f, 0.0f);

        LevelTwoBrickOne.SetActive(true);
        LevelTwoBrickTwo.SetActive(true);

        PauseTwo.SetActive(false);

        OneFinished = true;
        WinOne = false;
        TwoFinished = false;

        LevelTwoBrickOne.transform.localRotation = Quaternion.Euler(0,0,0);
        LevelTwoBrickTwo.transform.localRotation = Quaternion.Euler(0,0,0);
        MovePoint_2_1.transform.position = LevelTwoBrickOne.transform.position;
        MovePoint_2_1.transform.localRotation = Quaternion.Euler(0,0,0);


        MovePoint_2_2.transform.position = LevelTwoBrickTwo.transform.position;
        MovePoint_2_2.transform.localRotation = Quaternion.Euler(0,0,0);

        LevelTwoBrickOne.GetComponent<BrickMovement>().lost = false;
        LevelTwoBrickOne.GetComponent<BrickMovement>().OnBottom = false;

        LevelTwoBrickTwo.GetComponent<BrickMovement>().lost = false;
        LevelTwoBrickTwo.GetComponent<BrickMovement>().OnBottom = false;

        LevelTwoBrickOne.GetComponent<BrickMovement>().Restart = true;
        LevelTwoBrickTwo.GetComponent<BrickMovement>().Restart = true;



        StartCoroutine(Win());
    }

    public void RestartThree()
    {




        levelThreeBrickWindowOne.SetActive(true);
        levelThreeBrickWindowTwo.SetActive(true);

        foreach (GameObject BrickLine in LevelThreeDefaultBrickLines)
        {
            BrickLine.SetActive(true);
        }


        foreach (GameObject NewBrickLines in LevelThreeNewBrickLines)
        {
            NewBrickLines.SetActive(false);
        }

        foreach (GameObject DefaultSolution in LevelThreeDefaultSolutions)
        {
            DefaultSolution.SetActive(true);
        }

        foreach (GameObject NewSolution in LevelThreeNewSolutions)
        {
            NewSolution.SetActive(false);
        }

        foreach (GameObject DefaultBricks in LevelThreeDefaultBricks)
        {
            DefaultBricks.SetActive(true);
            DefaultBricks.GetComponent<BrickMovement>().Restart = true;
            DefaultBricks.GetComponent<BrickMovement>().lost = false;
            DefaultBricks.GetComponent<BrickMovement>().OnBottom = false;
        }

        foreach (GameObject NewBricks in LevelThreeNewBricks)
        {
            NewBricks.GetComponent<BrickMovement>().Restart = true;
            NewBricks.SetActive(false);
        }

        foreach (GameObject NewTasks in LevelThreeNewTasks)
        {
            NewTasks.SetActive(false);
            if(NewTasks.GetComponentInChildren<FirstPartWin>() != null)
            {
                NewTasks.GetComponentInChildren<FirstPartWin>().restart = true;
            }
        }

        foreach (GameObject BrickWindowOne in LevelThreeNewBrickWindowsOne)
        {
            BrickWindowOne.GetComponent<SelectBrickOne>().BrickPicked = false;
            BrickWindowOne.GetComponent<SelectBrickOne>().SelectFinished = false;
            BrickWindowOne.SetActive(false);
        }

        foreach (GameObject BrickWindowTwo in LevelThreeNewBrickWindowsTwo)
        {
            BrickWindowTwo.GetComponent<SelectBrickTwo>().BrickPicked = false;
            BrickWindowTwo.GetComponent<SelectBrickTwo>().SelectFinished = false;
            BrickWindowTwo.SetActive(false);
        }

        LevelThreeDefaultTask.SetActive(true);

        for(int x = 0; x < LevelThreeNewBricks.Length; x++)
        {
            //LevelThreeDefaultBricks[x].transform.position = LevelThreeDefaultMovePositions[x].transform.position;
            //LevelThreeDefaultBricks[x].transform.position = LevelThreeDefaultBrickPositions[x].transform.position;

            LevelThreeNewBricks[x].transform.position = LevelThreeSafedBrickPosition[x];

            LevelThreeNewBricks[x].transform.localRotation = Quaternion.Euler(0,0,0);
        }

        for(int y = 0; y < LevelThreeNewMovePositions.Length; y++)
        {
            //LevelThreeNewMovePositions[y].transform.position = LevelThreeDefaultMovePositions[y].transform.position;
            LevelThreeNewMovePositions[y].transform.position = LevelThreeSafedMovePosition[y];
            LevelThreeNewMovePositions[y].transform.localRotation = Quaternion.Euler(0,0,0);
        }


        

        LevelThreeBrickOne.transform.localPosition = new Vector3(782.0f, 249.0f, 0.0f);
        LevelThreeBrickTwo.transform.localPosition = new Vector3(904.0f, 38.0f, 0.0f);

        PauseThree.SetActive(false);

        TwoFinished = true;
        WinTwo = false;
        ThreeFinished = false;

        LostThree = false;

        LevelThreeBrickOne.transform.localRotation = Quaternion.Euler(0,0,0);
        LevelThreeBrickTwo.transform.localRotation = Quaternion.Euler(0,0,0);

        MovePoint_3_1.transform.position = LevelThreeBrickOne.transform.position;
        MovePoint_3_1.transform.localRotation = Quaternion.Euler(0,0,0);


        MovePoint_3_2.transform.position = LevelThreeBrickTwo.transform.position;
        MovePoint_3_2.transform.localRotation = Quaternion.Euler(0,0,0);

        LevelThreeBrickOne.GetComponent<BrickMovement>().lost = false;
        LevelThreeBrickOne.GetComponent<BrickMovement>().OnBottom = false;
        LevelThreeBrickOne.GetComponent<BrickMovement>().Restart = true;

        LevelThreeBrickTwo.GetComponent<BrickMovement>().lost = false;
        LevelThreeBrickTwo.GetComponent<BrickMovement>().OnBottom = false;

        
        LevelThreeBrickTwo.GetComponent<BrickMovement>().Restart = true;



        StartCoroutine(Win());
    }

    IEnumerator Win()
    {

        OneFinished = WinningOne.GetComponent<Winning>().LevelOneClear;
        //TwoFinished = WinningTwo.GetComponent<WinLevelTwo>().LevelTwoClear;
        TwoFinished = WinningTwo.GetComponent<SecondPartWin>().LevelTwoClear;
        if(OneFinished == true && WinOne == false && TwoFinished == false)
        {

            LevelOne.SetActive(false);
            

            if(WinScreenOne == false)
            {
                if(WinningScreenOne)
            {
                WinningScreenOne.SetActive(true);
                yield return new WaitForSeconds(ScreenTime);
            }
            }

            WinScreenOne = true;
            
            WinOne = true;
            


            //Destroy(WinningScreenOne);
            WinningScreenOne.SetActive(false);

            if(LevelTwoIntro)
            {
                LevelTwoIntro.SetActive(true);
            }

            

            yield return new WaitForSeconds(ScreenTime);

            //LevelTwoIntro.SetActive(false);
            //Destroy(LevelTwoIntro);
            LevelTwoIntro.SetActive(false);
            LevelTwo.SetActive(true);
            controller.SetActive(true);
            
        }

        if(TwoFinished == true && WinTwo == false)
        {

            LevelTwo.SetActive(false);
            

            if(WinScreenTwo == false)
            {
                if(WinningScreenTwo)
                {
                    WinningScreenTwo.SetActive(true);
                    yield return new WaitForSeconds(ScreenTime);
                }
            }


            WinScreenTwo = true;
            WinTwo = true;
            
            

            


            //Destroy(WinningScreenTwo);
            WinningScreenTwo.SetActive(false);

            if(LevelThreeIntro)
            {
                LevelThreeIntro.SetActive(true);
            }

            

            yield return new WaitForSeconds(ScreenTime);

            //LevelTwoIntro.SetActive(false);
            //Destroy(LevelThreeIntro);
            LevelThreeIntro.SetActive(false);
            LevelThree.SetActive(true);
            controller.SetActive(true);

            // LevelThreeBrickOne.GetComponent<BrickMovement>().Restart = false;
            // LevelThreeBrickTwo.GetComponent<BrickMovement>().Restart = false;
            
        }


    }

    IEnumerator Lost()
    {

        yield return new WaitForSeconds(0.3f);
        OneFinished = WinningOne.GetComponent<Winning>().LevelOneClear;
        //TwoFinished = WinningTwo.GetComponent<WinLevelTwo>().LevelTwoClear;
        TwoFinished = WinningTwo.GetComponent<SecondPartWin>().LevelTwoClear;

        if(OneFinished == false || TwoFinished == false)
        {
            if(LevelOneBrick.GetComponent<BrickMovement>().lost == true && LostOne ==false)
            {


            LevelOne.SetActive(false);
            if(LoosingScreenOne)
            {
                LoosingScreenOne.SetActive(true);
            }

            LostOne = true;

           

            yield return new WaitForSeconds(ScreenTime);


            //Destroy(WinningScreenOne);
            LoosingScreenOne.SetActive(false);

            LevelOne.SetActive(true);
            controller.SetActive(true);


                //yield return new WaitForSeconds(ScreenTime);

                 LevelOneBrick.GetComponent<BrickMovement>().OnBottom = false;

                RestartOne();
            }
        }



        if(OneFinished == true || TwoFinished == false)
        {
            if(LevelTwoBrickOne.GetComponent<BrickMovement>().lost == true &&  LevelTwoBrickTwo.GetComponent<BrickMovement>().lost == true && LostTwo ==false
                || LevelTwoBrickOne.GetComponent<BrickMovement>().lost == true && LostTwo ==false && LevelTwoBrickTwo.activeSelf == false )
            {


            LevelTwo.SetActive(false);
            if(LoosingScreenTwo)
            {
                LoosingScreenTwo.SetActive(true);
            }

            LostTwo = true;

           

            yield return new WaitForSeconds(ScreenTime);


            //Destroy(WinningScreenOne);
            LoosingScreenTwo.SetActive(false);

            LevelTwo.SetActive(true);
            controller.SetActive(true);


                //yield return new WaitForSeconds(ScreenTime);

                 LevelTwoBrickOne.GetComponent<BrickMovement>().OnBottom = false;
                 LevelTwoBrickTwo.GetComponent<BrickMovement>().OnBottom = false;

                RestartTwo();
            }
        }

         if(OneFinished == true || TwoFinished == true)
        {
            if(LevelThreeBrickOne.GetComponent<BrickMovement>().lost == true &&  LevelThreeBrickTwo.GetComponent<BrickMovement>().lost == true && LostThree ==false
                )
            {


            LevelThree.SetActive(false);
            if(LoosingScreenThree)
            {
                LoosingScreenThree.SetActive(true);
            }

            LostThree = true;

           

            yield return new WaitForSeconds(ScreenTime);


            //Destroy(WinningScreenOne);
            LoosingScreenThree.SetActive(false);

            LevelThree.SetActive(true);
            controller.SetActive(true);


                //yield return new WaitForSeconds(ScreenTime);

                 LevelThreeBrickOne.GetComponent<BrickMovement>().OnBottom = false;
                 LevelThreeBrickTwo.GetComponent<BrickMovement>().OnBottom = false;

                RestartThree();
            }

            for(int i = 0; i < LevelThreeNewBricks.Length; i = i+2)
            {
                if(LevelThreeNewBricks[i] != null)
                {

                
                if(LevelThreeNewBricks[i].GetComponent<BrickMovement>().lost == true && LevelThreeNewBricks[i + 1].GetComponent<BrickMovement>().lost == true && LostThree == false)
                {
                    LevelThree.SetActive(false);
                    if(LoosingScreenThree)
                    {
                        LoosingScreenThree.SetActive(true);
                    }

                    LostThree = true;

                

                    yield return new WaitForSeconds(ScreenTime);


                    //Destroy(WinningScreenOne);
                    LoosingScreenThree.SetActive(false);

                    LevelThree.SetActive(true);
                    controller.SetActive(true);


                    //yield return new WaitForSeconds(ScreenTime);

                    LevelThreeBrickOne.GetComponent<BrickMovement>().OnBottom = false;
                    LevelThreeBrickTwo.GetComponent<BrickMovement>().OnBottom = false;

                    LevelThreeNewBricks[i].GetComponent<BrickMovement>().lost = false;
                    LevelThreeNewBricks[i + 1].GetComponent<BrickMovement>().lost = false;

                    RestartThree();
                }
            }
            }
        }


    }

    public void PauseButtonOne()
    {
        PauseOne.SetActive(true);
        controller.SetActive(false);
    }

    public void PauseButtonTwo()
    {
        PauseTwo.SetActive(true);
        controller.SetActive(false);
    }

    public void PauseButtonThree()
    {
        PauseThree.SetActive(true);
        controller.SetActive(false);
    }


    public void QuitPause()
    {
        PauseOne.SetActive(false);
        PauseTwo.SetActive(false);
        PauseThree.SetActive(false);
        controller.SetActive(true);
    }

    public void ExitGame()
    {
        TetriX.SetActive(false);
        TeenageRoom.SetActive(true);
    }

    

    

}
