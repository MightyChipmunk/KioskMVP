using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class NoOrder : MonoBehaviour
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
        ShoplistManager.price = 0;
        ShoplistManager.quantity = "";
        ShoplistManager.m_name = "";
    }
}
