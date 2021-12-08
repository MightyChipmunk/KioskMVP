using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ShopList
{
    public string quantity;
    public int price;
    public string m_name;

    public int sum() { return Convert.ToInt32(quantity) * price; }

    public ShopList(string _quantity, int _price, string _m_name)
    {
        quantity = _quantity;
        price = _price;
        m_name = _m_name;
    }
}

public class ShoplistManager : MonoBehaviour
{
    public static string quantity;
    public static int price;
    public static string m_name;
    public static int sum = 0;

    public static List<ShopList> shoplists = new List<ShopList>();

    // Start is called before the first frame update
    void Start()
    {
        if(price != 0 && shoplists.Count < 4)
        {
            int nodup = 1;
            for(int i = 0; i < shoplists.Count; i++)
            {
                if(shoplists[i].m_name == m_name)
                {
                    shoplists[i].price += price;
                    shoplists[i].quantity = (Convert.ToInt32(shoplists[i].quantity) + Convert.ToInt32(quantity)).ToString();
                    nodup = 0;
                }
            }
            if (nodup == 1) 
            { 
                shoplists.Add(new ShopList(quantity, price, m_name)); 
            }
            sum += price;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

