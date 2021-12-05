using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class OrderInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void init()
    {
        ShoplistManager.price = Convert.ToInt32(QuantityManager.quantity) * QuantityManager.price;
        ShoplistManager.quantity = QuantityManager.quantity;
        ShoplistManager.m_name = QuantityManager.m_name;
    }
}
