using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CancelOrder : MonoBehaviour
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
        ShoplistManager.shoplists.Clear();
        ShoplistManager.sum = 0;
        ShoplistManager.price = 0;
        ShoplistManager.quantity = "";
        ShoplistManager.m_name = "";
    }
}