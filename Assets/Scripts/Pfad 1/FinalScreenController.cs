using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScreenController : MonoBehaviour
{

    public TMP_Text BlueCountText;
    public TMP_Text RedCountText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BlueCountText.text = Settings.BlueBulbCount + "x";
        RedCountText.text = Settings.RedBulbCount + "x";
    }
}
