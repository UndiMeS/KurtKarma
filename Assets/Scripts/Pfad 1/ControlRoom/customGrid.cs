using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customGrid : MonoBehaviour {

    public int columnLength, rowLength;
    public float x_Space, y_Space;
    public float x_Start, y_Start;
    public float tileSize = 0.45f;

    public int NotFinished;

    public bool BlackTileClicked;


    public GameObject Computer_1_2;
    public GameObject JunkRoom;

    public bool[, ] _IsClicked;

    public int WhiteSolutionCounter = 0;
    public int BlackSolutionCounter = 0;

    public int[, ] GridStart = new int[, ] { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 4, 0 }, { 5, 0 }, { 7, 0 }, { 9, 0 }, { 11, 0 }, { 0, 1 }, { 2, 1 }, { 4, 1 }, { 11, 1 }, { 0, 2 }, { 1, 2 }, { 2, 2 }, { 5, 2 }, { 7, 2 }, { 8, 2 }, { 4, 3 }, { 5, 3 }, { 6, 3 }, { 7, 3 }, { 9, 3 }, { 11, 3 }, { 1, 4 }, { 4, 4 }, { 6, 4 }, { 9, 4 }, { 0, 5 }, { 1, 5 }, { 2, 5 }, { 9, 5 }, { 11, 5 }, { 1, 6 }, { 3, 6 }, { 4, 6 }, { 7, 6 }, { 10, 6 }, { 11, 6 }, { 2, 7 }, { 4, 7 }, { 5, 7 }, { 6, 7 }, { 8, 7 }, { 11, 7 }, { 5, 8 }, { 7, 8 }, { 0, 9 }, { 1, 9 }, { 2, 9 }, { 5, 9 }, { 9, 9 }, { 10, 9 }, { 11, 9 }, { 0, 10 }, { 2, 10 }, { 6, 10 }, { 9, 10 }, { 11, 10 }, { 0, 11 }, { 1, 11 }, { 2, 11 }, { 5, 11 }, { 7, 11 }, { 9, 11 }, { 10, 11 }, { 11, 11 }
    };

    public int[, ] GridWhite = new int[, ] { { 3, 0 }, { 6, 0 }, { 8, 0 }, { 10, 0 }, { 1, 1 }, { 3, 1 }, { 5, 1 }, { 6, 1 }, { 7, 1 }, { 8, 1 }, { 9, 1 }, { 10, 1 }, { 3, 2 }, { 4, 2 }, { 6, 2 }, { 9, 2 }, { 10, 2 }, { 11, 2 }, { 0, 3 }, { 1, 3 }, { 2, 3 }, { 3, 3 }, { 8, 3 }, { 10, 3 }, { 0, 4 }, { 2, 4 }, { 3, 4 }, { 5, 4 }, { 7, 4 }, { 8, 4 }, { 10, 4 }, { 11, 4 }, { 3, 5 }, { 4, 5 }, { 7, 5 }, { 8, 5 }, { 10, 5 }, { 0, 6 }, { 2, 6 }, { 8, 6 }, { 9, 6 }, { 0, 7 }, { 1, 7 }, { 3, 7 }, { 7, 7 }, { 9, 7 }, { 10, 7 }, { 0, 8 }, { 1, 8 }, { 2, 8 }, { 3, 8 }, { 4, 8 }, { 6, 8 }, { 8, 8 }, { 9, 8 }, { 10, 8 }, { 11, 8 }, { 3, 9 }, { 4, 9 }, { 6, 9 }, { 7, 9 }, { 8, 9 }, { 1, 10 }, { 3, 10 }, { 4, 10 }, { 5, 10 }, { 7, 10 }, { 8, 10 }, { 10, 10 }, { 3, 11 }, { 4, 11 }, { 6, 11 }, { 8, 11 } };

    public int[, ] Grid;

    public int[, ] GridSolutionWhite = new int[, ] { { 10, 0 }, { 2, 6 } };
    public int[, ] GridSolutionBlack = new int[, ] { { 7, 11 }, { 5, 2 } };

    public int Columns = 12;
    public int Rows = 12;

    static QR_square_click QR_Square_Click;
    static QR_square_click qr_square_right;
    public GameObject StartTile;
    public GameObject CheckTile;

    public GameObject WhiteTile;

    public bool NotInSolution;

    int FeldNummer = 0;
    public bool Restart;

    public bool Black;
    public bool White;


    GameObject SolutionTile;
    static GameObject Tiles;

    public bool CodeRight;

    GameObject DestroyTile;


    public int ClickCount;
    public bool IsCounted;
    public GameObject RedFrame;
    public GameObject GreenFrame;
    public GameObject ResetButton;
    public GameObject BackButton;

    public GameObject ComputerScreenButton_1;

    // Start is called before the first frame update
    public void Start () {

        RedFrame.SetActive(false);
        GreenFrame.SetActive(false);

        NotFinished = 0;

        CodeRight = false;
        _IsClicked = new bool[Columns, Rows];
        Grid = new int[Columns, Rows];
        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {
                Grid[i, j] = FeldNummer + 1;
                SpawnTile (i, j, Grid[i, j]);
                FeldNummer++;
            }
        }

    }

    // Update is called once per frame
    void Update () {

        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {

                SolutionAnalyse (i, j);

            }
        }

        if (CodeRight == false) {
            if (White == true) {
                if (Black == true) {

                    CodeRight = true;


                    StartCoroutine(Finishwaiter());


                }

            }
        }

    }

    public void SolutionAnalyse (int i, int j) {

        if (i == 5 && j == 5 || i == 6 && j == 5 || i == 5 && j == 6 || i == 6 && j == 6) {

        } else {

            

            for (int x = 0; x < GridSolutionBlack.GetLength (0); x++) {
                if (Grid[i, j] == Grid[GridSolutionBlack[x, 0], GridSolutionBlack[x, 1]]) {
                    GameObject.Find ("QR_Square_" + GridSolutionBlack[x, 0].ToString () + "_" + GridSolutionBlack[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution = false;
                    NotInSolution = GameObject.Find ("QR_Square_" + GridSolutionBlack[x, 0].ToString () + "_" + GridSolutionBlack[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution;

                } else {
                    GameObject.Find ("QR_Square_" + GridSolutionBlack[x, 0].ToString () + "_" + GridSolutionBlack[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution = true;
                    NotInSolution = GameObject.Find ("QR_Square_" + GridSolutionBlack[x, 0].ToString () + "_" + GridSolutionBlack[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution;

                    for (int q = 0; q < GridStart.GetLength (0); q++) {
                        if (Grid[i, j] == Grid[GridStart[q, 0], GridStart[q, 1]] && NotInSolution == true) {

                            StartTile = GameObject.Find ("QR_Square_" + GridStart[q, 0].ToString () + "_" + GridStart[q, 1].ToString ());
                            QR_square_click qr_wrong_click = StartTile.GetComponent<QR_square_click> ();

                            if (qr_wrong_click.isClicked == false && qr_wrong_click.WrongClick == false) {
                                ClickCount++;
                                qr_wrong_click.WrongClick = true;
                                
                            } else if(qr_wrong_click.isClicked == true && qr_wrong_click.WrongClick == true) {
                                ClickCount--;
                                qr_wrong_click.WrongClick = false;
                                
                            }

                            if (Grid[i, j] != Grid[GridSolutionBlack[0, 0], GridSolutionBlack[0, 1]] && Grid[i, j] == Grid[GridStart[q, 0], GridStart[q, 1]] && GameObject.Find ("QR_Square_" + GridStart[q, 0].ToString () + "_" + GridStart[q, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution == false && qr_wrong_click.WrongClick == true && qr_wrong_click.NotFinishedAdd == false) {

                                NotFinished++;
                                qr_wrong_click.NotFinishedAdd = true;

                            } else if (Grid[i, j] == Grid[GridStart[q, 0], GridStart[q, 1]] && qr_wrong_click.WrongClick == false && GameObject.Find ("QR_Square_" + GridStart[q, 0].ToString () + "_" + GridStart[q, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution == false && qr_wrong_click.NotFinishedAdd == true) {
                                NotFinished--;
                                qr_wrong_click.NotFinishedAdd = false;
                            } else if (qr_wrong_click.WrongClick == true && GameObject.Find ("QR_Square_2_6").GetComponent<QR_square_click> ().notinsolution == true && qr_wrong_click.NotFinishedAdd == true || qr_wrong_click.WrongClick == true && GameObject.Find ("QR_Square_10_0").GetComponent<QR_square_click> ().notinsolution == true && qr_wrong_click.NotFinishedAdd == true) {
                                NotFinished += 0;
                            }

                        }

                    }
                }
            }

            for (int x = 0; x < GridSolutionWhite.GetLength (0); x++) {
                if (Grid[i, j] == Grid[GridSolutionWhite[x, 0], GridSolutionWhite[x, 1]]) {
                    GameObject.Find ("QR_Square_" + GridSolutionWhite[x, 0].ToString () + "_" + GridSolutionWhite[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution = false;
                    NotInSolution = GameObject.Find ("QR_Square_" + GridSolutionWhite[x, 0].ToString () + "_" + GridSolutionWhite[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution;

                } else {
                    GameObject.Find ("QR_Square_" + GridSolutionWhite[x, 0].ToString () + "_" + GridSolutionWhite[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution = true;
                    NotInSolution = GameObject.Find ("QR_Square_" + GridSolutionWhite[x, 0].ToString () + "_" + GridSolutionWhite[x, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution;

                    for (int q = 0; q < GridWhite.GetLength (0); q++) {
                        if (Grid[i, j] == Grid[GridWhite[q, 0], GridWhite[q, 1]] && NotInSolution == true) {

                            StartTile = GameObject.Find ("QR_Square_" + GridWhite[q, 0].ToString () + "_" + GridWhite[q, 1].ToString ());
                            QR_square_click qr_wrong_click = StartTile.GetComponent<QR_square_click> ();

                            if (qr_wrong_click.isClicked == true && qr_wrong_click.WrongClick == false) {
                                ClickCount++;
                                qr_wrong_click.WrongClick = true;
                                
                            } else if(qr_wrong_click.isClicked == false && qr_wrong_click.WrongClick == true){
                                ClickCount--;
                                qr_wrong_click.WrongClick = false;
                                
                            }

                            if (Grid[i, j] != Grid[GridSolutionWhite[0, 0], GridSolutionWhite[0, 1]] && Grid[i, j] == Grid[GridWhite[q, 0], GridWhite[q, 1]] && GameObject.Find ("QR_Square_" + GridWhite[q, 0].ToString () + "_" + GridWhite[q, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution == false && qr_wrong_click.WrongClick == true && qr_wrong_click.NotFinishedAdd == false) {

                                NotFinished++;
                                qr_wrong_click.NotFinishedAdd = true;

                            } else if (Grid[i, j] == Grid[GridWhite[q, 0], GridWhite[q, 1]] && qr_wrong_click.WrongClick == false && GameObject.Find ("QR_Square_" + GridWhite[q, 0].ToString () + "_" + GridWhite[q, 1].ToString ()).GetComponent<QR_square_click> ().notinsolution == false && qr_wrong_click.NotFinishedAdd == true) {
                                NotFinished--;
                                qr_wrong_click.NotFinishedAdd = false;
                            } else if (qr_wrong_click.WrongClick == true && GameObject.Find ("QR_Square_5_2").GetComponent<QR_square_click> ().notinsolution == true && qr_wrong_click.NotFinishedAdd == true || qr_wrong_click.WrongClick == true && GameObject.Find ("QR_Square_7_11").GetComponent<QR_square_click> ().notinsolution == true && qr_wrong_click.NotFinishedAdd == true) {
                                NotFinished += 0;
                            }

                        }

                    }
                }
            }

            for (int x = 0; x < GridSolutionBlack.GetLength (0); x++) {
                SolutionTile = GameObject.Find ("QR_Square_" + GridSolutionBlack[x, 0].ToString () + "_" + GridSolutionBlack[x, 1].ToString ());
                QR_square_click qr_square_click = SolutionTile.GetComponent<QR_square_click> ();

                if (Grid[i, j] == Grid[GridSolutionBlack[x, 0], GridSolutionBlack[x, 1]] && qr_square_click.WrongClick == true && NotFinished == 0) {

                    Black = true;

                } else if (Grid[i, j] == Grid[GridSolutionBlack[0, 0], GridSolutionBlack[0, 1]] && qr_square_click.WrongClick == false || Grid[i, j] == Grid[GridSolutionBlack[1, 0], GridSolutionBlack[1, 1]] && qr_square_click.WrongClick == false || NotFinished > 0) {
                    Black = false;
                }

            }

            for (int x = 0; x < GridSolutionWhite.GetLength (0); x++) {
                SolutionTile = GameObject.Find ("QR_Square_" + GridSolutionWhite[x, 0].ToString () + "_" + GridSolutionWhite[x, 1].ToString ());
                QR_square_click qr_square_click = SolutionTile.GetComponent<QR_square_click> ();

                if (Grid[i, j] == Grid[GridSolutionWhite[x, 0], GridSolutionWhite[x, 1]] && qr_square_click.WrongClick == true && NotFinished == 0) {

                    White = true;

                } else if (Grid[i, j] == Grid[GridSolutionWhite[0, 0], GridSolutionWhite[0, 1]] && qr_square_click.WrongClick == false || Grid[i, j] == Grid[GridSolutionWhite[1, 0], GridSolutionWhite[1, 1]] && qr_square_click.WrongClick == false || NotFinished > 0) {
                    White = false;
                }

            }

            if(ClickCount >= 4)
            {

                
                StartCoroutine(secondwaiter());
                
                

                
            }




        }
    }

    public GameObject SpawnTile (int x, int y, int value) {

        GameObject tile = GameObject.Instantiate (Resources.Load<GameObject> ("prefabs/QR_Square"), transform) as GameObject;
        QR_square_click qr_square_click = tile.GetComponent<QR_square_click> ();
        tile.transform.position = transform.position + new Vector3 (10, 10, 0);
        float posX = x_Space * x * tileSize;
        float posY = y_Space * y * tileSize;

        tile.name = "QR_Square_" + x.ToString () + "_" + y.ToString ();

        tile.transform.position = new Vector2 (posX + x_Start, posY + y_Start);

        if (Grid[x, y] == Grid[6, 6] || Grid[x, y] == Grid[6, 5] || Grid[x, y] == Grid[5, 5] || Grid[x, y] == Grid[5, 6]) {
            Destroy (tile);
        }

        for (int j = 0; j < GridStart.GetLength (0); j++) {
            if (Grid[x, y] == Grid[GridStart[j, 0], GridStart[j, 1]]) {

                qr_square_click.isClicked = !qr_square_click.isClicked;

            }

        }

        return tile;
    }

    public void restart () {

        Restart = true;
        ClickCount = 0;

        

        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {
                DestroyTile = GameObject.Find ("QR_Square_" + i.ToString () + "_" + j.ToString ());

                Destroy (DestroyTile);

            }
        }

        Grid = new int[Columns, Rows];
        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {
                Grid[i, j] = FeldNummer + 1;
                SpawnTile (i, j, Grid[i, j]);
                FeldNummer++;
            }
        }

        


        NotFinished = 1;

        StartCoroutine (waiter ());
    }

    IEnumerator waiter () {
        yield return new WaitForSeconds (0.1f);
        NotFinished = 0;
    }

    IEnumerator secondwaiter()
    {

        ClickCount = 0;

        ResetButton.GetComponent<Button>().interactable = false;
        BackButton.GetComponent<Button>().interactable = false;

        
        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {

                if (i == 5 && j == 5 || i == 6 && j == 5 || i == 5 && j == 6 || i == 6 && j == 6) {

        } else {

                GameObject.Find("QR_Square_" + i.ToString() + "_" + j.ToString()).GetComponent<BoxCollider2D>().enabled = false;
        }

            }
        }

        RedFrame.SetActive(true);

                yield return new WaitForSeconds(1.5f);

                RedFrame.SetActive(false);

                
        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {

                if (i == 5 && j == 5 || i == 6 && j == 5 || i == 5 && j == 6 || i == 6 && j == 6) {

        } else {

                GameObject.Find("QR_Square_" + i.ToString() + "_" + j.ToString()).GetComponent<BoxCollider2D>().enabled = true;

        }

            }
        }
        ResetButton.GetComponent<Button>().interactable = true;
        BackButton.GetComponent<Button>().interactable = true;

                restart();
                

                
        
    }

    IEnumerator Finishwaiter()
    {

        ClickCount = 0;

        ResetButton.GetComponent<Button>().interactable = false;
        BackButton.GetComponent<Button>().interactable = false;

        
        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {

                if (i == 5 && j == 5 || i == 6 && j == 5 || i == 5 && j == 6 || i == 6 && j == 6) {

        } else {

                GameObject.Find("QR_Square_" + i.ToString() + "_" + j.ToString()).GetComponent<BoxCollider2D>().enabled = false;
        }

            }
        }
        RedFrame.SetActive(false);
        GreenFrame.SetActive(true);

                yield return new WaitForSeconds(1.5f);

                GreenFrame.SetActive(false);
                ComputerScreenButton_1.GetComponent<Button>().interactable = false;

                
        for (int i = 0; i < Columns; i++) {
            for (int j = 0; j < Rows; j++) {

                if (i == 5 && j == 5 || i == 6 && j == 5 || i == 5 && j == 6 || i == 6 && j == 6) {

        } else {

                GameObject.Find("QR_Square_" + i.ToString() + "_" + j.ToString()).GetComponent<BoxCollider2D>().enabled = true;

        }

            }
        }

        Computer_1_2.SetActive (false);

        JunkRoom.SetActive (true);
        ResetButton.GetComponent<Button>().interactable = true;
        BackButton.GetComponent<Button>().interactable = true;

                
                

                
        
    }

}