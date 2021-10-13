using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajonClick : MonoBehaviour
{

    public GameObject Cajon;
    public BoxCollider2D CajonCollider;
    public bool selected;
    public float transitionSpeed;

    public AudioSource audio1;

    public GameObject HiddenSheet;

    public Vector3 newPos = new Vector3(0.7f, -1.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        audio1 = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(selected == true)
        {
            Cajon.transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * transitionSpeed);
        }
    }

    void OnMouseOver () {


        
            if (Input.GetMouseButtonDown (0)) {
                selected = true;
                audio1.Play ();

                Destroy(CajonCollider);

                HiddenSheet.SetActive(true);

            }
    }
}
