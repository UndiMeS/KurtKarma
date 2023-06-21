using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAltarCube : MonoBehaviour
{

    public AltarSolution altarSolution;
    public AnimationCurve animationCurve;
    public AnimationCurve finalAnimationCurve;

    public float pitchValue = 1.0f;
    public float showspin;

    public AltarCubeClick RiddleCubeFront;
    public AltarCubeClick RiddleCubeBack;
    public AudioSource RotationSound;
    public AudioClip FinalSpin;
    public bool Positive = true;

    Animator SpinAnimation;

 
    private bool boolValueFront;
    private bool boolValueBack;
    public bool WinningSpin = true;

    public Sprite finalSprite;
    SpriteRenderer thisSpriteRendererBack;
    SpriteRenderer thisSpriteRendererFront;

    public int FinalDrehung;

    public float nowRot;
    public float actualRot;

    public bool UnMute;
    public bool SpinSound = false;

    public float SoundDegree;

    public float StartVolume;



    void Awake()
    {
        //SpinAnimation = this.gameObject.GetComponent<Animator>();

        actualRot = this.gameObject.transform.rotation.eulerAngles.z;
        nowRot = actualRot;
        
    }
 
    void Start() {

        StartVolume = RotationSound.volume;

        animationCurve = altarSolution.animationCurve;
        finalAnimationCurve = altarSolution.finalAnimationCurve;
        thisSpriteRendererBack = RiddleCubeBack.gameObject.GetComponent<SpriteRenderer>();
        thisSpriteRendererFront = RiddleCubeFront.gameObject.GetComponent<SpriteRenderer>();
    }
 



    // Update is called once per frame
    void Update()
    {
        // if(RotationSound != null)
        //             {

        //                 actualRot = this.gameObject.transform.rotation.eulerAngles.y;

        //                 actualRot = (int) actualRot;

        //                 actualRot = (int) actualRot;
        //                 if(actualRot == 0)
        //                 nowRot = 0;

        //                 if (actualRot - nowRot >= SoundDegree || actualRot - nowRot < -SoundDegree)
        //                 {

        //                     if(UnMute == true)
        //                     RotationSound.Play();

        //                     nowRot = this.gameObject.transform.rotation.eulerAngles.y;

        //                     nowRot = (int) actualRot;

        //                     UnMute = true;
        //                 }
                            

        //             }


        // if(SpinSound == true)
        // {
        //     float angle  = Quaternion.Angle(Quaternion.Euler(new Vector3(0,0,0)),transform.rotation); 
        //  float pitchValue = (angle / (360.0f * (10.0f + 0.5f*FinalDrehung))) * (1.25f - 0.75f) + 0.75f;
        //  RotationSound.pitch = pitchValue;

        // showspin = this.gameObject.transform.eulerAngles.y / 360*FinalDrehung;
        // }
        
        if(RiddleCubeFront.Clicked == true)
        {

            Positive = true;
            
        }
        if(RiddleCubeFront.Spin == true)
        {
            TweenCubeFront();

            RiddleCubeFront.GetComponent<BoxCollider2D>().enabled = false;
            RiddleCubeBack.GetComponent<BoxCollider2D>().enabled = false;

            Invoke("ColliderSpin",1.0f);
            
            
        }

        if(RiddleCubeBack.Clicked == true)
        {
            

            Positive = false;
        }

        if(RiddleCubeBack.Spin == true)
        {
            TweenCubeFront();
            Invoke("ColliderSpin",1.0f);
            RiddleCubeFront.GetComponent<BoxCollider2D>().enabled = false;
            RiddleCubeBack.GetComponent<BoxCollider2D>().enabled = false;

            
        }

        if(altarSolution.Correct == true && WinningSpin == true)
        {
            RiddleCubeFront.GetComponent<BoxCollider2D>().enabled = false;
            RiddleCubeBack.GetComponent<BoxCollider2D>().enabled = false;


            LeanTween.rotateAroundLocal(this.gameObject, Vector3.up, 360.0f * (10.0f + 0.5f*FinalDrehung), altarSolution.animationTime*(2.0f + 0.5f*FinalDrehung)).setEase(finalAnimationCurve);

            // RotationSound.clip = FinalSpin;
            // RotationSound.loop = true;
            // RotationSound.Play();
            // SoundDegree = 225.0f;
            //  //LeanTween.value(RotationSound.pitch, 2.0f,altarSolution.animationTime).setEase(finalAnimationCurve);
             
             
            //  LeanTween.value(RotationSound.gameObject, 1.0f, 0.25f, altarSolution.animationTime*(2.0f + 0.5f*FinalDrehung)).setEase(finalAnimationCurve).setOnUpdate(SetPitch);
             
            StartCoroutine(FinalSpinning());

             SpinSound = true;
            
            WinningSpin = false;

            Invoke("WinningSpinText", 0.5f);

        }

        
    }

    void TweenCubeFront()
    {
        
        if(RiddleCubeBack.Spin == true)
        {

            LeanTween.rotateAroundLocal(this.gameObject, Vector3.up, 180.0f, altarSolution.animationTime).setEase(animationCurve);
            RiddleCubeBack.Spin = false;
             RotationSound.Play();
        }
        if(RiddleCubeFront.Spin == true)
        {
            LeanTween.rotateAroundLocal(this.gameObject, Vector3.up, 180.0f, altarSolution.animationTime).setEase(animationCurve);
            Debug.Log("lean tween front");
            RiddleCubeFront.Spin = false;
             RotationSound.Play();
        }
    }

    void ColliderSpin()
    {
        RiddleCubeFront.GetComponent<BoxCollider2D>().enabled = true;
        RiddleCubeBack.GetComponent<BoxCollider2D>().enabled = true;
    }

    void WinningSpinText()
    {
        thisSpriteRendererFront.sprite = finalSprite;
        thisSpriteRendererBack.sprite = finalSprite;

    }

    public IEnumerator FinalSpinning()
    {
        RotationSound.loop = true;
            
            SoundDegree = 225.0f;
             //LeanTween.value(RotationSound.pitch, 2.0f,altarSolution.animationTime).setEase(finalAnimationCurve);
             
             yield return new WaitForSeconds(0.1f * FinalDrehung);
             RotationSound.Play();
             LeanTween.value(RotationSound.gameObject, 1.0f, 0.3f, (altarSolution.animationTime*(2.0f + 0.5f*FinalDrehung))).setEase(finalAnimationCurve).setOnUpdate(SetPitch);
             LeanTween.value(RotationSound.gameObject, 0.5f, 0.0f, (altarSolution.animationTime*(2.0f + 0.5f*FinalDrehung))).setEase(finalAnimationCurve).setOnUpdate(SetVolume);

             yield return new WaitForSeconds(altarSolution.animationTime*(2.0f + 0.5f*FinalDrehung));
             RotationSound.loop = false;
             RotationSound.Stop();
    }

    public void SetPitch(float value)
    {
        RotationSound.pitch = value;
    }
    public void SetVolume(float value)
    {
        RotationSound.volume = value;
    }

}
