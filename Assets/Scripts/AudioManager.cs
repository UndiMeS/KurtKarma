using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Video;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioMixer MusicMixer;
    public AudioMixer EffectMixer;
    public AudioSource[] Musics;
    public AudioSource[] Effects;
    public Slider Musik;
    public Slider Effekte;

    public VideoPlayer Intro;
    public VideoPlayer Outro;
    // Start is called before the first frame update

    void awake()
    {
        Effekte.value = PlayerPrefs.GetFloat("EffectVol", 0.75f);
        Musik.value = PlayerPrefs.GetFloat("MusicVol", 0.0f);
    }
    void Start()
    {

        Effekte.value = PlayerPrefs.GetFloat("EffectVol", 0.75f);
        Musik.value = PlayerPrefs.GetFloat("MusicVol", 0.0f);




        // Musik.value = PlayerPrefs.GetFloat("MusicVolume");
        // Effekte.value = PlayerPrefs.GetFloat("EffectsVolume");
    }

    // Update is called once per frame
    void Update()
    {
        // foreach(AudioSource Music in Musics)
        // {
        //     Music.volume = Musik.value;
        // }

        // foreach(AudioSource Effect in Effects)
        // {
        //     Effect.volume = Musik.value;
        // }
        
    }

    public void VolumePrefs()
    {
        // PlayerPrefs.SetFloat("MusicVolume", Musik.value);
        // PlayerPrefs.SetFloat("EffectsVolume", Effekte.value);

        PlayerPrefs.SetFloat("MusicVol", Musik.value);
        PlayerPrefs.SetFloat("EffectVol", Effekte.value);
    }

    public void SetLevelMusic(float sliderValue)
    {
        MusicMixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);

        // if(Intro != null)
        // Intro.SetDirectAudioVolume(0,sliderValue);

        // if(Outro != null)
        // Outro.SetDirectAudioVolume(0,sliderValue);
    }

    public void SetLevelEffect(float sliderValue)
    {
        EffectMixer.SetFloat("EffectVolume", Mathf.Log10 (sliderValue) * 20);
    }
}
