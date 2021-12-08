using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class QuantityManager : MonoBehaviour
{
    public static string quantity;
    public static int sum;
    public static int price;
    public static string m_name;
    public static Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        quantity = "";
        sum = 0;
        price = 0;
        m_name = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(quantity.Length >0)
        {
            sum = Convert.ToInt32(quantity) * price;
        }
        else
        {
            sum = 0;
        }
    }
}
