using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuantityUpdate : MonoBehaviour
{
    public Text quantitylabel;
    // Start is called before the first frame update
    void Start()
    {
        quantitylabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        quantitylabel.text = QuantityManager.quantity;
    }
}
