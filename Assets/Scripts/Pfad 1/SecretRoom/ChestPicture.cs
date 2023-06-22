using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestPicture : MonoBehaviour
{

    public KeySolution KeySolution;

    public bool ChestOpen;

    public Sprite ChestPictureOpen;
    public Sprite ChestSprite;

    public GameObject ChestPictureButton;
    // Start is called before the first frame update
    void Start()
    {
        ChestSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        // if(KeySolution.KeyInPlace == true)
        // {
        //     ChestOpen = true;
        //     this.gameObject.GetComponent<SpriteRenderer>().sprite = ChestPictureOpen;
        //     ChestPictureButton.SetActive(true);
        // }
    }
}
