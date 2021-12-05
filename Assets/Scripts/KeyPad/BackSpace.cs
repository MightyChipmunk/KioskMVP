using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadPeriod))
        {
            Back();
        }
    }

    public void Back()
    {
        if (QuantityManager.quantity.Length == 2)
        {
            QuantityManager.quantity = QuantityManager.quantity.Substring(0, 1);
        }
        else if (QuantityManager.quantity.Length == 1)
        {
            QuantityManager.quantity = QuantityManager.quantity.Substring(1);
        }
        else { }
    }
}
