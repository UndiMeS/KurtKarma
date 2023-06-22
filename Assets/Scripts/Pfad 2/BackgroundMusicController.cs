using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{

    public AudioSource GameMusic;
    //public AudioSource TetrixMusic;
    public float startVolume;

    public  bool keepfadein;
    public  bool keepfadeout;
    // Start is called before the first frame update
    void Start()
    {
        //startVolume = GameMusic.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MusicFadeOut()
    {
        StartCoroutine(FadeOut(GameMusic, 0.004f));
        //StartCoroutine(FadeIn(TetrixMusic, 0.004f));

    }

    public void MusicFadeIn()
    {
        StartCoroutine(FadeIn(GameMusic, 0.004f));
        //StartCoroutine(FadeOut(TetrixMusic, 0.004f));
    }

    public  IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {

        keepfadein = false;
        keepfadeout = true;

        float startVolume = audioSource.volume;
 
        while (audioSource.volume > 0 && keepfadeout) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop ();
        //audioSource.volume = startVolume;
    }

    public  IEnumerator FadeIn (AudioSource audioSource, float FadeTime) {

        keepfadein = true;
        keepfadeout = false;

        float startVolume = 0.001f;

        audioSource.Play ();

        audioSource.volume = startVolume;
 
        while (audioSource.volume < 1 && keepfadein) {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

 
            yield return null;
        }
 
        
        //audioSource.volume = startVolume;
    }
}
