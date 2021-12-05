using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumUpdate : MonoBehaviour
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
        sumlabel.text = QuantityManager.sum.ToString() + "¿ø";
    }
}
