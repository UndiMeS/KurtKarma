using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelection : MonoBehaviour
{
    public string GameOne;
    public string GameTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectOne()
    {
        SceneManager.LoadScene(GameOne);
    }

    public void SelectTwo()
    {
        SceneManager.LoadScene(GameTwo);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
