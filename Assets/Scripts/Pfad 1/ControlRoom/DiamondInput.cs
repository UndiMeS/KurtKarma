using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondInput : MonoBehaviour
{

    public TMP_InputField DiamondOneInput;
    public TMP_InputField DiamondTwoInput;
    // Start is called before the first frame update
    void Start()
    {
        //DiamondTwoInput = this.gameObject.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(DiamondOneInput != null)
        // {
        //     DiamondOneInput.text = DiamondTwoInput.text;
        // }
        // if(DiamondTwoInput != null)
        // {
        //     DiamondTwoInput.text = DiamondOneInput.text;
        // }
        
    }

        public void ValueChangeOne ()
    {
        DiamondTwoInput.text = DiamondOneInput.text;
    }
    public void ValueChangeTwo ()
    {
        DiamondOneInput.text = DiamondTwoInput.text;
    }
}
