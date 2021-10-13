using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretNoteControler : MonoBehaviour
{

    public GameObject HintSmall;
    public Sprite HintWithLightSmall;
    public Sprite HintNoLightSmall;

    public SpriteRenderer HintRenderer;

    public GameObject LampLightOff;
    public GameObject LampLightOn;
    public GameObject HintWithLightButton;

    public GameObject HintWithLightOffButton;

    public TriggerLight LampOn;
    public TriggerLight LampOff;
    // Start is called before the first frame update
    void Start()
    {
        LampOn = LampLightOn.GetComponent<TriggerLight>();
        LampOff = LampLightOff.GetComponent<TriggerLight>();

        HintRenderer = HintSmall.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(LampOff.selected == true)
        {
            LampLightOn.SetActive(true);
            HintWithLightButton.SetActive(true);
            HintWithLightOffButton.SetActive(false);
            HintRenderer.sprite = HintWithLightSmall;
            LampOff.selected = false;
            LampLightOff.SetActive(false);

        }

        if(LampOn.selected == true)
        {
            LampLightOff.SetActive(true);
            HintWithLightButton.SetActive(false);
            HintWithLightOffButton.SetActive(true);
            HintRenderer.sprite = HintNoLightSmall;
            LampOn.selected = false;
            LampLightOn.SetActive(false);

        }
    }
}
