using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public string GameName;
    public string SelectionMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(GameName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void BackToSelection()
    {
        SceneManager.LoadScene(SelectionMenu);
    }
}
