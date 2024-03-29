﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnItem : MonoBehaviour
{
     public bool selected;
    public GameObject ItemPlaceOne;
    public GameObject ItemPlaceTwo;
    public GameObject ItemPlace;
    public int sortingorder = 8;
    private SpriteRenderer sprite;
    public bool InItemBarOne;
    public bool InItemBarTwo;
    public bool InItemBar;
    public bool DragOne;
    public bool DragTwo;
    public GameObject InventoryArrow;
    public bool ItemBarStartOne;
    public bool ItemBarStartTwo;

    public Material M_material;

    public Color MaterialColor;

    public Color Outlinecolor;
    public AudioSource ItemSound;

    // Start is called before the first frame update
    void Start()
    {
        ItemSound = this.gameObject.GetComponent<AudioSource>();
        sprite = GetComponent<SpriteRenderer>();

        M_material = InventoryArrow.GetComponent<Renderer>().material;

        MaterialColor = M_material.GetColor("_OutlineColor");

        Outlinecolor = new Color32((byte)255, (byte)255, (byte)0, (byte)255);
        M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));
    }

    // Update is called once per frame
    void Update()
    {

        InItemBarOne = ItemPlaceOne.GetComponent<ItemPlaceTwo>().fullOne;
        InItemBarTwo = ItemPlaceTwo.GetComponent<ItemPlaceTwo>().fullTwo;
        ItemBarStartOne = ItemPlaceOne.GetComponent<ItemPlaceTwo>().ItemListStart;
        ItemBarStartTwo = ItemPlaceTwo.GetComponent<ItemPlaceTwo>().ItemListStart;

        if(InItemBarTwo == true)
        {
            ItemPlace = ItemPlaceOne;
            InItemBar = true;
        }

        if(InItemBarOne == true)
        {
            ItemPlace = ItemPlaceTwo;
            InItemBar = true;
        }

        if(Input.GetMouseButtonUp(0)){
                    selected = false;

        }


        if(DragOne == true && selected == true || DragTwo == true && selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(cursorPos.x, cursorPos.y, -1.0f);

        }

        if(selected == false && DragOne == true && InItemBarTwo == false  && DragTwo == false)
        {

            this.gameObject.transform.position = new Vector3(ItemPlaceOne.transform.position.x, ItemPlaceOne.transform.position.y, -1.0f);

        }
        else if(selected == false && DragTwo == true && InItemBarTwo == false && InItemBarOne == true  && DragOne == false)
        {

            this.gameObject.transform.position = new Vector3(ItemPlaceTwo.transform.position.x, ItemPlaceTwo.transform.position.y, -1.0f);
        }
        else if(selected == false && DragOne == true && InItemBarTwo == true )
        {

            this.gameObject.transform.position = new Vector3(ItemPlaceOne.transform.position.x, ItemPlaceOne.transform.position.y, -1.0f);

        }



    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
                selected = true;
                

                if(InItemBarOne == false && DragOne == false && InItemBarTwo == false && selected == true)
                {
                this.gameObject.transform.position = new Vector3(ItemPlaceOne.transform.position.x, ItemPlaceOne.transform.position.y, -1.0f);

                if(this.gameObject.name == "SNES Modul")
                {
                    ItemSound.Play();
                    this.gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 0);

                    this.gameObject.transform.rotation = Quaternion.Euler(0.0f,0.0f, -37.0f);
                }
                if(this.gameObject.name == "Kasette im Tresor")
                {
                    ItemSound.Play();
                    this.gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0);
                }
                
                this.gameObject.transform.parent = ItemPlaceOne.transform;
                sprite.sortingOrder = sortingorder;

                DragOne = true;

                StartCoroutine(InventoryBlink());

                //InItemBarOne=true;
                selected = false;
                }

                if(InItemBarTwo == false && DragTwo == false && InItemBarOne == true && selected == true && DragOne == false)
                {
                    
                this.gameObject.transform.position = new Vector3(ItemPlaceTwo.transform.position.x, ItemPlaceTwo.transform.position.y, -1.0f);
                 if(this.gameObject.name == "SNES Modul")
                {
                    
                    this.gameObject.transform.localScale = new Vector3(0.6f, 0.6f, 0);

                    this.gameObject.transform.rotation = Quaternion.Euler(0.0f,0.0f, -37.0f);
                }
                if(this.gameObject.name == "Schlüssel")
                {
                    this.gameObject.transform.localScale = new Vector3(50.0f, 50.0f, 0);
                }
                if(this.gameObject.name == "Kasette im Tresor")
                {
                    ItemSound.Play();
                    this.gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0);
                }
                this.gameObject.transform.parent = ItemPlaceTwo.transform;
                sprite.sortingOrder = sortingorder;

                StartCoroutine(InventoryBlink());

                DragTwo = true;

                //InItemBarTwo=true;
                selected = false;
                }






                
                }

                if(Input.GetMouseButtonUp(0)){
                    selected = false;
                
                }
    }

    IEnumerator InventoryBlink()
    {
        M_material.SetColor("_OutlineColor", Outlinecolor);

        yield return new WaitForSeconds(1);

        M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));

        yield return new WaitForSeconds(1);

        M_material.SetColor("_OutlineColor", Outlinecolor);

        yield return new WaitForSeconds(1);

        M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));

        yield return new WaitForSeconds(1);
    }
}
