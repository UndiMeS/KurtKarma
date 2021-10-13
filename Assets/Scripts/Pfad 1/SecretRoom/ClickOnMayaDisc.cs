using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnMayaDisc : MonoBehaviour
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
    public bool Drag;
    public GameObject InventoryArrow;

    public Material M_material;

    public Color MaterialColor;

    public Color Outlinecolor;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        M_material = InventoryArrow.GetComponent<Renderer>().material;

        MaterialColor = M_material.GetColor("_OutlineColor");

        Outlinecolor = new Color32((byte)(MaterialColor.r * 255), (byte)(MaterialColor.g * 255), (byte)(MaterialColor.b * 255), (byte)255);
        M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));
    }

    // Update is called once per frame
    void Update()
    {

        InItemBarOne = ItemPlaceOne.GetComponent<ItemPlace>().fullOne;
        InItemBarTwo = ItemPlaceTwo.GetComponent<ItemPlace>().fullTwo;

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
                    if(this.gameObject.transform.position == new Vector3(ItemPlace.transform.position.x, ItemPlace.transform.position.y, -1.0f))
                {
                    Drag = true;

                     
                }
        }


        if(Drag == true && selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(cursorPos.x, cursorPos.y, -1.0f);
        }

        if(selected == false && Drag == true)
        {
            this.gameObject.transform.position = new Vector3(ItemPlace.transform.position.x, ItemPlace.transform.position.y, -1.0f);
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0)){
                selected = true;

                if(InItemBarOne == false)
                {
                this.gameObject.transform.position = new Vector3(ItemPlace.transform.position.x, ItemPlace.transform.position.y, -1.0f);
                this.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0);
                this.gameObject.transform.parent = ItemPlace.transform;
                sprite.sortingOrder = sortingorder;

                StartCoroutine(InventoryBlink());

                InItemBarOne=true;
                selected = false;
                }

                if(InItemBarTwo == false)
                {
                this.gameObject.transform.position = new Vector3(ItemPlace.transform.position.x, ItemPlace.transform.position.y, -1.0f);
                this.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0);
                this.gameObject.transform.parent = ItemPlace.transform;
                sprite.sortingOrder = sortingorder;

                StartCoroutine(InventoryBlink());

                InItemBarTwo=true;
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
