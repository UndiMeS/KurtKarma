using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickOutline : MonoBehaviour
{

    public Material M_material;

    public Color MaterialColor;

    public Color Outlinecolor;

    public bool selected = false;

    public int SelectionCount = 0;
    // Start is called before the first frame update
    void Start()
    {

        


        M_material = this.GetComponent<Renderer>().material;

        MaterialColor = M_material.GetColor("_OutlineColor");

        Outlinecolor = new Color32((byte)(MaterialColor.r * 255), (byte)(MaterialColor.g * 255), (byte)(MaterialColor.b * 255), (byte)255);
        M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){

        if(GetComponent<OnClickOutline>().enabled == true)
        {
            selected = !selected;
            if(selected == true)
            {
                M_material.SetColor("_OutlineColor", Outlinecolor);
                SelectionCount = 1;
            }

            if(selected == false)
            {
                M_material.SetColor("_OutlineColor", new Color32((byte) 0, (byte) 0, (byte) 0, (byte) 0));
                SelectionCount = 0;
            }
        }


        
    }
}
