using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCollect : MonoBehaviour
{
    public GameObject ControllRoom;
    public GameObject TokenPlaced;
    public GameObject BigToken;

    public Material Ripple;
    public bool RippleBool = true;
    public Vector2 RipplePlace;

    public float RippleTime;

    public bool Collected;

    public float RippleRadius;

    public Animator TokenAnimation;
    public bool AnimBool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.activeSelf == true)
        {
            Collected = true;
            
            if(RippleBool == true)
            {
                //this.gameObject.GetComponent<AudioSource>().Play(0);
                StartCoroutine(RippleWaiter());

                StartCoroutine(ChangeSomeValue(0.0f,1.0f, RippleTime));

            }
            
        }
        if(this.gameObject.activeSelf == true && ControllRoom.activeSelf == true && BigToken.GetComponent<TokenCatch>().Collected == true)
        {
            

            TokenPlaced.SetActive(true);


            
                //TokenAnimation.enabled = false;
            StartCoroutine(AnimationWaiter());

            
            BigToken.GetComponent<TokenCatch>().Collected = false;
        }
    }

        IEnumerator RippleWaiter()
    {




        Ripple.SetVector("_FocalPoint", RipplePlace);
        Ripple.SetFloat("_Size",0.05f);
        Ripple.SetFloat("_Speed",1.0f);

        // float currentTime = 0;
        // while (currentTime < RippleTime)
        // {
        //     Ripple.SetFloat("_Radius", RippleRadius);
        //     RippleRadius = currentTime / RippleTime;
        //     currentTime += Time.deltaTime;

            
        // }


        yield return new WaitForSeconds(RippleTime);
        Ripple.SetFloat("_Speed",0.0f);
        Ripple.SetFloat("_Size",0.0f);
        Ripple.SetFloat("_Radius", 0.0f);
        RippleBool = false;
    }

    public IEnumerator ChangeSomeValue(float oldValue, float newValue, float duration) {
        for (float t = 0f; t < duration; t += Time.deltaTime) {
        RippleRadius = Mathf.Lerp(oldValue, newValue, t / duration);
        Ripple.SetFloat("_Radius", RippleRadius);
        yield return null;
        }
        //Ripple.SetFloat("_Radius", RippleRadius);
    }

    IEnumerator AnimationWaiter()
    {
        yield return new WaitForSeconds(0.5f);
        TokenAnimation.enabled = false;
    }
}
