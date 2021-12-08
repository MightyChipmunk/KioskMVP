using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour
{
    public Text sumlabel;
    
    // Start is called before the first frame update
    void Start()
    {
        sumlabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShoplistManager.shoplists.Count > 0)
        {
            sumlabel.text = ShoplistManager.sum.ToString() + "¿ø ";
        }
    }
}
